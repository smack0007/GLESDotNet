using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;

namespace HelloTextures
{
    public unsafe class HelloTexturesSample : Sample
    {
        private static uint _program;
        private static int _fragTextureLocation;
        private static uint _texture;

        public static void Main(string[] args)
        {
            using (var sample = new HelloTexturesSample())
                sample.Run();
        }

        public HelloTexturesSample()
        {
            Window.Title = "Hello Textures";
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

        protected override void Initialize()
        {
            string vertShader =
@"attribute vec3 vertPosition;
attribute vec3 vertColor;
attribute vec2 vertTexCoord;

varying vec3 fragColor;
varying vec2 fragTexCoord;

void main()
{
    gl_Position = vec4(vertPosition, 1.0);
    fragColor = vertColor;
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
            glBindAttribLocation(_program, 1, "vertColor");
            glBindAttribLocation(_program, 2, "vertTexCoord");
            LinkProgram(_program);

            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            uint texture;
            glGenTextures(1, &texture);
            _texture = texture;

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, (void*)data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        protected override void Draw()
        {
            float[] vertPositions = new float[]
            {
                -0.5f, 0.5f, 0.0f,
                0.5f, 0.5f, 0.0f,
                -0.5f, -0.5f, 0.0f,

                0.5f, 0.5f, 0.0f,
                0.5f, -0.5f, 0.0f,
                -0.5f, -0.5f, 0.0f,
            };

            float[] vertColors = new float[]
            {
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,

                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f
            };

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

            fixed (void* vertColorsPtr = vertColors)
            {
                glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, vertColorsPtr);
            }

            glEnableVertexAttribArray(1);

            fixed (void* vertTexCoordsPtr = vertTexCoords)
            {
                glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, vertTexCoordsPtr);
            }

            glEnableVertexAttribArray(2);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1i(_fragTextureLocation, 0);

            glDrawArrays(GL_TRIANGLES, 0, 6);
        }
    }
}
