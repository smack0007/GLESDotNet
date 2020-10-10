using System;
using static GLESDotNet.GLES2;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;
using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiGLESDotNet
{
    public unsafe class ImGuiSample : Sample
    {
        private uint _program;
        private int _vertProjectionLocation;
        private int _fragTextureLocation;
        private uint _texture;

        private const int VertexSizeInBytes = 20;
        private const int VertexSizeInFloats = VertexSizeInBytes / sizeof(float);

        private float[] _vertexData = new float[1024 * 1024];
        private ushort[] _indexData = new ushort[1024 * 1024];


        public static void Main(string[] args)
        {
            using (var sample = new ImGuiSample())
                sample.Run();
        }

        public ImGuiSample()
            : base("ImGui")
        {
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
@"attribute vec2 vertPosition;
attribute vec2 vertTexCoord;
attribute vec4 vertColor;

varying vec2 fragTexCoord;
varying vec4 fragColor;

uniform mat4 vertProjection; 

void main()
{
    gl_Position = vertProjection * vec4(vertPosition, 0, 1);
    fragTexCoord = vertTexCoord;
    fragColor = vertColor;
}";

            string fragShader =
@"precision mediump float;

varying vec2 fragTexCoord;
varying vec4 fragColor;

uniform sampler2D fragTexture;

void main()
{
    gl_FragColor = fragColor * texture2D(fragTexture, fragTexCoord);
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
            glBindAttribLocation(_program, 2, "vertColor");
            LinkProgram(_program);

            _vertProjectionLocation = glGetUniformLocation(_program, "vertProjection");
            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            uint texture;
            glGenTextures(1, &texture);
            _texture = texture;

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            var context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);
            var io = ImGui.GetIO();

            io.Fonts.GetTexDataAsRGBA32(out byte* pixelData, out int width, out int height, out int bytesPerPixel);

            var pixels = new byte[width * height * bytesPerPixel];
            Marshal.Copy(new IntPtr(pixelData), pixels, 0, pixels.Length);

            fixed (byte* pixelsPtr = pixels)
            {
                glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, pixelsPtr);
            }

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            io.Fonts.SetTexID((IntPtr)_texture);
            io.Fonts.ClearTexData();

            glClearColor(0.0f, 0.0f, 0.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            glEnable(GL_BLEND);
            glBlendEquation(GL_FUNC_ADD);
            glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
            glDisable(GL_CULL_FACE);
            glDisable(GL_DEPTH_TEST);
            glEnable(GL_SCISSOR_TEST);
        }

        private float _elapsed;

        protected override void Update(float elapsed)
        {
            _elapsed = elapsed;
        }

        protected override void Draw()
        {
            var io = ImGui.GetIO();
            io.DeltaTime = _elapsed;
            io.DisplaySize = new Vector2(WindowWidth, WindowHeight);
            io.DisplayFramebufferScale = new Vector2(WindowWidth / FrameBufferWidth, WindowHeight / FrameBufferHeight);

            ImGui.NewFrame();

            //ImGui.Begin("Hello World!");
            //ImGui.Text("Text");
            //ImGui.End();
            ImGui.ShowDemoWindow();

            ImGui.Render();

            var drawData = ImGui.GetDrawData();

            int vertexOffset = 0;
            int indexOffset = 0;

            for (int n = 0; n < drawData.CmdListsCount; n++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[n];

                fixed (void* vertexDataPtr = &_vertexData[vertexOffset * VertexSizeInFloats])
                fixed (void* indexDataPtr = &_indexData[indexOffset * sizeof(ushort)])
                {
                    Buffer.MemoryCopy(
                        (void*)cmdList.VtxBuffer.Data,
                        vertexDataPtr,
                        _vertexData.Length * sizeof(float),
                        cmdList.VtxBuffer.Size * VertexSizeInFloats * sizeof(float));

                    Buffer.MemoryCopy(
                        (void*)cmdList.IdxBuffer.Data,
                        indexDataPtr,
                        _indexData.Length * sizeof(ushort),
                        cmdList.IdxBuffer.Size * sizeof(ushort));
                }

                vertexOffset += cmdList.VtxBuffer.Size;
                indexOffset += cmdList.IdxBuffer.Size;
            }

            Title = $"ImGui {FrameBufferWidth}x{FrameBufferHeight}";
            glViewport(0, 0, FrameBufferWidth, FrameBufferHeight);
            glClear(GL_COLOR_BUFFER_BIT);

            glUseProgram(_program);

            fixed (float* vertexDataPtr = _vertexData)
            {
                glVertexAttribPointer(0, 2, GL_FLOAT, false, VertexSizeInBytes, (byte*)vertexDataPtr);
                glVertexAttribPointer(1, 2, GL_FLOAT, false, VertexSizeInBytes, (byte*)vertexDataPtr + 8);
                glVertexAttribPointer(2, 4, GL_UNSIGNED_BYTE, true, VertexSizeInBytes, (byte*)vertexDataPtr + 16);
            }

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1i(_fragTextureLocation, 0);

            for (int n = 0; n < drawData.CmdListsCount; n++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[n];

                for (int cmdi = 0; cmdi < cmdList.CmdBuffer.Size; cmdi++)
                {
                    ImDrawCmdPtr drawCmd = cmdList.CmdBuffer[cmdi];

                    float L = drawData.DisplayPos.X;
                    float R = drawData.DisplayPos.X + drawData.DisplaySize.X;
                    float T = drawData.DisplayPos.Y;
                    float B = drawData.DisplayPos.Y + drawData.DisplaySize.Y;

                    float[] projection = new float[]
                    {
                        2.0f/(R-L),   0.0f,         0.0f,   0.0f,
                        0.0f,         2.0f/(T-B),   0.0f,   0.0f,
                        0.0f,         0.0f,        -1.0f,   0.0f,
                        (R+L)/(L-R),  (T+B)/(B-T),  0.0f,   1.0f,
                    };

                    fixed (float* projectionPtr = projection)
                    {
                        glUniformMatrix4fv(_vertProjectionLocation, 1, false, projectionPtr);
                    }

                    fixed (ushort* indexDataPtr = _indexData)
                    {
                        glDrawElements(
                            GL_TRIANGLES,
                            (int)drawCmd.ElemCount,
                            GL_UNSIGNED_SHORT,
                            indexDataPtr);
                    }
                }
            }
        }
    }
}
