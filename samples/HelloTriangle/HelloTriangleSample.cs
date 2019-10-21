using GLFWDotNet.Utilities;
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

        protected override void Initialize()
        {
            string vShaderStr =
@"attribute vec3 vPosition;
attribute vec3 vColor;

varying vec3 fragColor;

void main()
{
    gl_Position = vec4(vPosition, 1.0);
    fragColor = vColor;
}";

            string fShaderStr =
@"precision mediump float;

varying vec3 fragColor;

void main()
{
    gl_FragColor = vec4(fragColor, 1.0);
}";
            
            uint vertexShader = CompileShader(vShaderStr, GL_VERTEX_SHADER);
            uint fragmentShader = CompileShader(fShaderStr, GL_FRAGMENT_SHADER);
            
            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);
            
            glBindAttribLocation(_program, 0, "vPosition");
            glBindAttribLocation(_program, 1, "vColor");
            glLinkProgram(_program);

            int linked;
            glGetProgramiv(_program, GL_LINK_STATUS, &linked);
            
            if (linked == 0)
            {
                int infoLength;
                glGetProgramiv(_program, GL_INFO_LOG_LENGTH, &infoLength);

                if (infoLength > 1)
                {
                    var infoLog = new StringBuilder(infoLength);
                    glGetProgramInfoLog(_program, infoLength, null, infoLog);
                    glDeleteProgram(_program);
                    throw new InvalidOperationException($"Error linking program:\n{infoLog}");
                }
            }

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
        }

        protected override void Draw()
        {
            float[] vVertices = new float[]
            {
                0.0f, 0.5f, 0.0f,
                -0.5f, -0.5f, 0.0f,
                0.5f, -0.5f, 0.0f
            };

            float[] vColors = new float[]
            {
                1.0f, 0.0f, 0.0f,
                0.0f, 1.0f, 0.0f,
                0.0f, 0.0f, 1.0f
            };

            glViewport(0, 0, Window.Width, Window.Height);
            glClear(GL_COLOR_BUFFER_BIT);
            
            glUseProgram(_program);

            fixed (void* vVerticesPtr = vVertices)
            {
                glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vVerticesPtr);
            }

            glEnableVertexAttribArray(0);

            fixed (void* vColorsPtr = vColors)
            {
                glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, vColorsPtr);
            }
            
            glEnableVertexAttribArray(1);

            glDrawArrays(GL_TRIANGLES, 0, 3);
        }
    }
}
