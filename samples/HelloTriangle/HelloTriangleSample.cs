using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;

namespace HelloTriangle
{
    public unsafe class HelloTriangleSample : Sample
    {
        private static uint _program;

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }        

        public HelloTriangleSample()
        {
            Window.Title = "Hello Triangle";
        }

        private static uint CompileShader(string shaderSrc, uint type)
        {
            var shader = glCreateShader(type);
            
            if(shader == 0)
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

varying vec3 fragColor;

void main()
{
    gl_Position = vec4(vertPosition, 1.0);
    fragColor = vertColor;
}";

            string fragShader =
@"precision mediump float;

varying vec3 fragColor;

void main()
{
    gl_FragColor = vec4(fragColor, 1.0);
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
            LinkProgram(_program);

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        protected override void Draw()
        {
            float[] vertPositions = new float[]
            {
                0.0f, 0.5f, 0.0f,
                -0.5f, -0.5f, 0.0f,
                0.5f, -0.5f, 0.0f
            };

            float[] vertColors = new float[]
            {
                1.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 1.0f
            };

            glViewport(0, 0, Window.Width, Window.Height);
            glClear(GL_COLOR_BUFFER_BIT);
            
            glUseProgram(_program);

            fixed (void* vPositionsPtr = vertPositions)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vPositionsPtr);
            }

            glEnableVertexAttribArray(0);

            fixed (void* vertColorsPtr = vertColors)
            {
                glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, vertColorsPtr);
            }
            
            glEnableVertexAttribArray(1);

            glDrawArrays(GL_TRIANGLES, 0, 3);
        }
    }
}
