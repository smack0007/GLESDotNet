using System;
using System.Linq;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;

namespace Flames
{
    public unsafe class FlamesSample : Sample
    {
        private static readonly uint[] _fireColors = new uint[] {
            0x00070707,
            0x0007071f,
            0x00070f2f,
            0x00070f47,
            0x00071757,
            0x00071f67,
            0x00071f77,
            0x0007278f,
            0x00072f9f,
            0x00073faf,
            0x000747bf,
            0x000747c7,
            0x00074FDF,
            0x000757DF,
            0x000757DF,
            0x00075FD7,
            0x000F67D7,
            0x000f6fcf,
            0x000f77cf,
            0x000f7fcf,
            0x001787CF,
            0x001787C7,
            0x00178FC7,
            0x001F97C7,
            0x001F9FBF,
            0x001F9FBF,
            0x0027A7BF,
            0x0027A7BF,
            0x002FAFBF,
            0x002FAFB7,
            0x002FB7B7,
            0x0037B7B7,
            0x006FCFCF,
            0x009FDFDF,
            0x00C7EFEF,
            0x00FFFFFF,
        };

        private uint _program;
        private int _vertTransformLocation;
        private int _fragTextureLocation;
        
        private uint _backgroundTexture;
        private int _backgroundWidth;
        private int _backgroundHeight;

        private uint _fireTexture;
        private uint[] _firePixels;

        public static void Main(string[] args)
        {
            using (var sample = new FlamesSample())
                sample.Run();
        }

        public FlamesSample()
        {
            Window.Title = "Flames";

            _firePixels = new uint[Window.Width * Window.Height];
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

        private int GetColorIndex(uint pixel)
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
            return _firePixels[y * Window.Width + x];
        }

        private void SetFirePixel(int x, int y, int colorIndex)
        {
            _firePixels[y * Window.Width + x] = _fireColors[colorIndex];
        }

        private void SpreadFire(int x, int y)
        {
            uint pixel = GetFirePixel(x, y + 1);
            int colorIndex = GetColorIndex(pixel);
            SetFirePixel(x, y, colorIndex - 1);
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

            var image = Image.LoadTga("opengles.tga").To<Rgba32>();
            _backgroundWidth = image.Width;
            _backgroundHeight = image.Height;
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, image.Width, image.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, (void*)data.Pointer);
            }
                        
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glBindTexture(GL_TEXTURE_2D, _fireTexture);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, Window.Width, Window.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, null);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            for (int x = 0; x < Window.Width; x++)
                SetFirePixel(x, Window.Height - 1, _fireColors.Length - 1);
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
            for (int x = 0; x < Window.Width; x++)
                for (int y = Window.Height - 2; y >= 0; y--)
                    SpreadFire(x, y);
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

            float centerX = Window.Width / 2.0f;
            float centerY = Window.Height / 2.0f;
            
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

            glViewport(0, 0, Window.Width, Window.Height);
            glClear(GL_COLOR_BUFFER_BIT);

            glUseProgram(_program);

            fixed (void* vertPositionsPtr = vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositionsPtr);
            }

            glEnableVertexAttribArray(0);

            fixed (void* vertTexCoordsPtr = vertTexCoords)
            {
                glVertexAttribPointer(1, 2, GL_FLOAT, false, 0, vertTexCoordsPtr);
            }

            glEnableVertexAttribArray(1);

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
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, Window.Width, Window.Height, 0, GL_RGBA, GL_UNSIGNED_BYTE, flamePixelsPtr);
            }
            glUniform1i(_fragTextureLocation, 0);

            vertPositions = GenerateVertPositions(0, 0, Window.Width, Window.Height);

            fixed (void* vertPositionsPtr = vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositionsPtr);
            }

            glDrawArrays(GL_TRIANGLES, 0, 6);
        }
    }
}
