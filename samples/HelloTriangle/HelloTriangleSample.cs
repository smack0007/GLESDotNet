using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;

namespace HelloTriangle
{
    public class HelloTriangleSample : Sample
    {
        private static uint _program;

        public static void Main(string[] args)
        {
            using (var sample = new HelloTriangleSample())
                sample.Run();
        }        

        public HelloTriangleSample()
            : base("Hello Triangle")
        {
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
            
            uint vertexShader = GLUtils.CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = GLUtils.CompileShader(fragShader, GL_FRAGMENT_SHADER);
            
            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);
            
            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertColor");
            GLUtils.LinkProgram(_program);

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
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

            glViewport(0, 0, WindowWidth, WindowHeight);
            glClear(GL_COLOR_BUFFER_BIT);
            
            glUseProgram(_program);

            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositions);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, vertColors);            

            glDrawArrays(GL_TRIANGLES, 0, 3);
        }
    }
}
