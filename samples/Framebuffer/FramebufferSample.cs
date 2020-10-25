using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;

namespace Framebuffer
{
    public class FramebufferSample : GLApplication
    {
        private uint _program;
        private int _fragTextureLocation;
        private uint _texture;
        private uint _screenProgram;
        private int _screenFragTextureLocation;
        private int _screenFragTimeLocation;
        private uint _framebuffer;
        private uint _framebufferTexture;

        private float _totalElapsedTime;

        public static void Main(string[] args)
        {
            using (var sample = new FramebufferSample())
                sample.Run();
        }

        public FramebufferSample()
            : base("Framebuffer")
        {
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

            string screenFragShader =
@"precision mediump float;

varying vec3 fragColor;
varying vec2 fragTexCoord;

uniform sampler2D fragTexture;
uniform float fragTime;

void main()
{
	gl_FragColor = texture2D(fragTexture, fragTexCoord + 0.005 * vec2(sin(fragTime + 1024.0 * fragTexCoord.x), cos(fragTime + 768.0 * fragTexCoord.y)));
}";

            uint vertexShader = GLUtils.CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = GLUtils.CompileShader(fragShader, GL_FRAGMENT_SHADER);
            uint screenFragmentShader = GLUtils.CompileShader(screenFragShader, GL_FRAGMENT_SHADER);

            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);

            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertColor");
            glBindAttribLocation(_program, 2, "vertTexCoord");
            GLUtils.LinkProgram(_program);

            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            _screenProgram = glCreateProgram();
            if (_screenProgram == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_screenProgram, vertexShader);
            glAttachShader(_screenProgram, screenFragmentShader);

            glBindAttribLocation(_screenProgram, 0, "vertPosition");
            glBindAttribLocation(_screenProgram, 1, "vertColor");
            glBindAttribLocation(_screenProgram, 2, "vertTexCoord");
            GLUtils.LinkProgram(_screenProgram);

            _screenFragTextureLocation = glGetUniformLocation(_screenProgram, "fragTexture");
            _screenFragTimeLocation = glGetUniformLocation(_screenProgram, "fragTime");

            glGenTextures(1, out _texture);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            // Image is an RGBImage.
            var image = Image.LoadTga("Box.tga").To<Rgb24>();
            using (var data = image.GetDataPointer())
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB, image.Width, image.Height, 0, GL_RGB, GL_UNSIGNED_BYTE, data.Pointer);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            glGenFramebuffers(1, out _framebuffer);
            
            glBindFramebuffer(GL_FRAMEBUFFER, _framebuffer);

            glGenTextures(1, out _framebufferTexture);            

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _framebufferTexture);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, 1024, 768, 0, GL_RGBA, GL_UNSIGNED_BYTE, IntPtr.Zero);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_NEAREST);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_NEAREST);
            glFramebufferTexture2D(GL_FRAMEBUFFER, GL_COLOR_ATTACHMENT0, GL_TEXTURE_2D, _framebufferTexture, 0);
                        
            uint framebufferStatus = glCheckFramebufferStatus(GL_FRAMEBUFFER);
            if (framebufferStatus != GL_FRAMEBUFFER_COMPLETE)
                throw new InvalidOperationException($"Framebuffer Incomplete: 0x{framebufferStatus:X}");

            glBindFramebuffer(GL_FRAMEBUFFER, 0);

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);
        }

        protected override void Update(float elapsed)
        {
            _totalElapsedTime += elapsed;
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

            float[] screenVertPositions = new float[]
            {
                -1.0f, -1.0f, 0.0f,
                -1.0f, 1.0f, 0.0f,
                1.0f, 1.0f, 0.0f,

                -1.0f, -1.0f, 0.0f,
                1.0f, 1.0f, 0.0f,
                1.0f, -1.0f, 0.0f,
            };

            float[] screenVertColors = new float[]
            {
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,

                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f,
                1.0f, 1.0f, 1.0f
            };

            float[] screenVertTexCoords = new float[]
            {
                0.0f, 1.0f,
                0.0f, 0.0f,
                1.0f, 0.0f,

                0.0f, 1.0f,
                1.0f, 0.0f,
                1.0f, 1.0f
            };
            
            // Draw to Framebuffer
            
            glUseProgram(_program);

            glBindFramebuffer(GL_FRAMEBUFFER, _framebuffer);
            glViewport(0, 0, 1024, 768);
            glClear(GL_COLOR_BUFFER_BIT);            

            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, vertPositions);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, vertColors);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, vertTexCoords);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1i(_fragTextureLocation, 0);

            glDrawArrays(GL_TRIANGLES, 0, 6);

            // Draw to Screen

            glUseProgram(_screenProgram);

            glBindFramebuffer(GL_FRAMEBUFFER, 0);
            glViewport(0, 0, WindowWidth, WindowHeight);
            glClear(GL_COLOR_BUFFER_BIT);

            glVertexAttribPointer(0, 3, GL_FLOAT, false, 0, screenVertPositions);
            glVertexAttribPointer(1, 3, GL_FLOAT, false, 0, screenVertColors);
            glVertexAttribPointer(2, 2, GL_FLOAT, false, 0, screenVertTexCoords);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _framebufferTexture);
            glUniform1i(_screenFragTextureLocation, 0);
            glUniform1f(_screenFragTimeLocation, _totalElapsedTime);

            glDrawArrays(GL_TRIANGLES, 0, 6);
        }
    }
}
