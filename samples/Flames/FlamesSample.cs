using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;

namespace Flames
{
    public unsafe class FlamesSample : Sample
    {
        private static readonly uint[] _fireColors = new uint[] {
            0x00000000,
            0xC0070707,
            0xC007071f,
            0xC0070f2f,
            0xC0070f47,
            0xC0071757,
            0xC0071f67,
            0xC0071f77,
            0xC007278f,
            0xC0072f9f,
            0xC0073faf,
            0xC00747bf,
            0xC00747c7,
            0xC0074FDF,
            0xC00757DF,
            0xC00757DF,
            0xC0075FD7,
            0xC00F67D7,
            0xC00f6fcf,
            0xC00f77cf,
            0xC00f7fcf,
            0xC01787CF,
            0xC01787C7,
            0xC0178FC7,
            0xC01F97C7,
            0xC01F9FBF,
            0xC01F9FBF,
            0xC027A7BF,
            0xC027A7BF,
            0xC02FAFBF,
            0xC02FAFB7,
            0xC02FB7B7,
            0xC037B7B7,
            0xC06FCFCF,
            0xC09FDFDF,
            0xC0C7EFEF,
            0xC0FFFFFF,
        };

        private uint _program;
        private int _vertTransformLocation;
        private int _fragTextureLocation;
        
        private int _backgroundWidth;
        private int _backgroundHeight;
        private uint _backgroundTexture;

        private const int _fireWidth = 450;
        private const int _firePadding = 50;
        private const int _fireHeight = 120;
        private uint _fireTexture;
        private uint[] _firePixels;

        private Random _random;

        public static void Main(string[] args)
        {
            using (var sample = new FlamesSample())
                sample.Run();
        }

        public FlamesSample()
            : base("Flames")
        {
            _firePixels = new uint[_fireWidth * _fireHeight];

            _random = new Random();
        }

        private static uint CompileShader(string shaderSrc, uint type)
        {
            var shader = glCreateShader(type);

            if (shader == 0)
                return 0;

            var shaderSrcTmp = new string[] { shaderSrc };
            var shaderLength = shaderSrc.Length;
            glShaderSource(shader, 1, shaderSrcTmp, &shaderLength);

            glCompileShader(shader);

            int compiled;
            glGetShaderiv(shader, GL_COMPILE_STATUS, &compiled);

            if (compiled == 0)
            {
                int infoLength;
                glGetShaderiv(shader, GL_INFO_LOG_LENGTH, &infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetShaderInfoLog(shader, infoLength, null, infoLog);
                    glDeleteShader(shader);
                    throw new InvalidOperationException($"Error compiling shader:\n{infoLog}");
                }
            }

            return shader;
        }

        private static void LinkProgram(uint program)
        {
            glLinkProgram(program);

            int linked;
            glGetProgramiv(program, GL_LINK_STATUS, &linked);

            if (linked == 0)
            {
                int infoLength;
                glGetProgramiv(program, GL_INFO_LOG_LENGTH, &infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetProgramInfoLog(program, infoLength, null, infoLog);
                    glDeleteProgram(program);
                    throw new InvalidOperationException($"Error linking program:\n{infoLog}");
                }
            }
        }

        private int GetFireColorIndex(uint pixel)
        {
            for (int i = 0; i < _fireColors.Length; i++)
            {
                if (_fireColors[i] == pixel)
                    return i;
            }

            return 0;
        }

        private uint GetFirePixel(int x, int y)
        {
            return _firePixels[y * _fireWidth + x];
        }

        private void SetFirePixel(int x, int y, int colorIndex)
        {
            if (colorIndex < 0)
                colorIndex = 0;

            if (colorIndex > _fireColors.Length - 1)
                colorIndex = _fireColors.Length - 1;

            if (x < 0)
                return;

            _firePixels[y * _fireWidth + x] = _fireColors[colorIndex];
        }

        private void SpreadFire(int x, int y)
        {
            uint pixel = GetFirePixel(x, y);
            int colorIndex = GetFireColorIndex(pixel);
            int random = _random.Next(0, 100);
            SetFirePixel(x - (random % 5), y - 1, colorIndex - (random % 3));
        }

        private void UpdateFire()
        {
            for (int x = 0; x < _fireWidth; x++)
                for (int y = 1; y < _fireHeight; y++)
                    SpreadFire(x, y);
        }

        protected override void Initialize()
        {
            string vertShader =
@"attribute vec3 vertPosition;
attribute vec2 vertTexCoord;

varying vec2 fragTexCoord;

uniform mat4 vertTransform; 

void main()
{
    gl_Position = vertTransform * vec4(vertPosition, 1.0);
    fragTexCoord = vertTexCoord;
}";

            string fragShader =
@"precision mediump float;

varying vec3 fragColor;
varying vec2 fragTexCoord;

uniform sampler2D fragTexture;

void main()
{
    gl_FragColor = texture2D(fragTexture, fragTexCoord);
}";

            uint vertexShader = CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = CompileShader(fragShader, GL_FRAGMENT_SHADER);

            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);

            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertTexCoord");
            LinkProgram(_program);

            _vertTransformLocation = glGetUniformLocation(_program, "vertTransform");
            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            uint[] textures = new uint[2];
            fixed (uint* texturesPtr = textures)
            {
                glGenTextures(2, texturesPtr);
            }

            _backgroundTexture = textures[0];
            _fireTexture = textures[1];

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _backgroundTexture);

            var image = Image.LoadPng("opengles.png").To<Rgba32>();
            _backgroundWidth = image.Width;
            _backgroundHeight = image.Height;
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, image.Width, image.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, (void*)data.Pointer);
            }
                        
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glBindTexture(GL_TEXTURE_2D, _fireTexture);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, _fireWidth - _firePadding, _fireHeight, 0, GL_RGBA, GL_UNSIGNED_BYTE, null);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glEnable(GL_BLEND);
            glBlendFuncSeparate(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA, GL_ONE, GL_ZERO);
            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);

            // Initialize the bottom row of pixels with the last color.
            for (int x = 0; x < _fireWidth; x++)
                SetFirePixel(x, _fireHeight - 1, _fireColors.Length - 1);
        }

        private static float[] GenerateVertPositions(float x, float y, int width, int height)
        {
            float xPlusWidth = x + width;
            float yPlusHeight = y + height;

            return new float[]
            {
                x, y, 0.0f,
                xPlusWidth, y, 0.0f,
                x, yPlusHeight, 0.0f,

                xPlusWidth, y, 0.0f,
                xPlusWidth, yPlusHeight, 0.0f,
                x, yPlusHeight, 0.0f,
            };
        }

        protected override void Update(float elapsed)
        {
            UpdateFire();
        }

        protected override void Draw()
        {
            int[] viewport = new int[4];

            fixed (int* viewportPtr = viewport)
            {
                glGetIntegerv(GL_VIEWPORT, viewportPtr);
            }

            float m11 = 2f / viewport[2];
            float m22 = -2f / viewport[3];

            float[] transform = new float[]
            {
                m11, 0.0f, 0.0f, 0.0f,
                0.0f, m22, 0.0f, 0.0f,
                0.0f, 0.0f, 1.0f, 0.0f,
                -1.0f, 1.0f, 0.0f, 1.0f,
            };

            float centerX = WindowWidth / 2.0f;
            float centerY = WindowHeight / 2.0f;
            
            float[] vertPositions = GenerateVertPositions(
                centerX - (_backgroundWidth / 2.0f),
                centerY - (_backgroundHeight / 2.0f),
                _backgroundWidth,
                _backgroundHeight);

            float[] vertTexCoords = new float[]
            {
                0.0f, 0.0f,
                1.0f, 0.0f,
                0.0f, 1.0f,

                1.0f, 0.0f,
                1.0f, 1.0f,
                0.0f, 1.0f
            };

            glViewport(0, 0, WindowWidth, WindowHeight);
            glClear(GL_COLOR_BUFFER_BIT);

            glUseProgram(_program);

            fixed (void* vertPositionsPtr = vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositionsPtr);
            }

            fixed (void* vertTexCoordsPtr = vertTexCoords)
            {
                glVertexAttribPointer(1, 2, GL_FLOAT, false, 0, vertTexCoordsPtr);
            }

            fixed (float* transformPtr = transform)
            {
                glUniformMatrix4fv(_vertTransformLocation, 1, false, transformPtr);
            }

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _backgroundTexture);            
            glUniform1i(_fragTextureLocation, 0);
            glDrawArrays(GL_TRIANGLES, 0, 6);

            glBindTexture(GL_TEXTURE_2D, _fireTexture);
            fixed (uint* flamePixelsPtr = _firePixels)
            {
                for (int y = 0; y < _fireHeight; y++)
                    glTexSubImage2D(GL_TEXTURE_2D, 0, 0, y, _fireWidth - _firePadding, 1, GL_RGBA, GL_UNSIGNED_BYTE, &flamePixelsPtr[y * _fireWidth + (_firePadding / 2)]);
            }
            glUniform1i(_fragTextureLocation, 0);

            vertPositions = GenerateVertPositions(0, 0, WindowWidth, WindowHeight);

            fixed (void* vertPositionsPtr = vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositionsPtr);
            }

            glDrawArrays(GL_TRIANGLES, 0, 6);
        }
    }
}
