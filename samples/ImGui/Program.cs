using System;
using static GLESDotNet.GLES2;
using static GLFWDotNet.GLFW;
using System.Text;
using GLESDotNet.Samples;
using ImageDotNet;
using ImGuiNET;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace ImGuiGLESDotNet
{
    public unsafe class ImGuiSample : Sample
    {
        private uint _program;
        private int _vertProjectionLocation;
        private int _fragTextureLocation;
        private uint _texture;

        private const int VertexSizeInBytes = 20;

        private uint _vertexBuffer;
        private uint _indexBuffer;

        private Dictionary<int, bool> _keyStates = new Dictionary<int, bool>()
        {
            [GLFW_KEY_TAB] = false,
            [GLFW_KEY_LEFT] = false,
            [GLFW_KEY_RIGHT] = false,
            [GLFW_KEY_UP] = false,
            [GLFW_KEY_DOWN] = false,
            [GLFW_KEY_PAGE_UP] = false,
            [GLFW_KEY_PAGE_DOWN] = false,
            [GLFW_KEY_HOME] = false,
            [GLFW_KEY_END] = false,
            [GLFW_KEY_DELETE] = false,
            [GLFW_KEY_BACKSPACE] = false,
            [GLFW_KEY_ENTER] = false,
            [GLFW_KEY_ESCAPE] = false,

            [GLFW_KEY_LEFT_ALT] = false,
            [GLFW_KEY_RIGHT_ALT] = false,

            [GLFW_KEY_LEFT_CONTROL] = false,
            [GLFW_KEY_RIGHT_CONTROL] = false,

            [GLFW_KEY_LEFT_SHIFT] = false,
            [GLFW_KEY_RIGHT_SHIFT] = false,

            [GLFW_KEY_LEFT_SUPER] = false,
            [GLFW_KEY_RIGHT_SUPER] = false,
        };
        private Vector2 _mousePosition = Vector2.Zero;
        private bool[] _mouseButtons = new bool[GLFW_MOUSE_BUTTON_LAST];

        private byte[] _name = new byte[128];

        public static void Main(string[] args)
        {
            using (var sample = new ImGuiSample())
                sample.Run();
        }

        public ImGuiSample()
            : base("ImGui", 1280, 720)
        {
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
    gl_Position = vertProjection * vec4(vertPosition.xy, 0, 1);
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

            uint vertexShader = GLUtils.CompileShader(vertShader, GL_VERTEX_SHADER);
            uint fragmentShader = GLUtils.CompileShader(fragShader, GL_FRAGMENT_SHADER);

            _program = glCreateProgram();
            if (_program == 0)
                throw new InvalidOperationException("Failed to create program.");

            glAttachShader(_program, vertexShader);
            glAttachShader(_program, fragmentShader);

            glBindAttribLocation(_program, 0, "vertPosition");
            glBindAttribLocation(_program, 1, "vertTexCoord");
            glBindAttribLocation(_program, 2, "vertColor");
            GLUtils.LinkProgram(_program);

            _vertProjectionLocation = glGetUniformLocation(_program, "vertProjection");
            _fragTextureLocation = glGetUniformLocation(_program, "fragTexture");

            glGenTextures(1, out _texture);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);

            var context = ImGui.CreateContext();
            ImGui.SetCurrentContext(context);
            ImGui.StyleColorsDark();
            var io = ImGui.GetIO();
            io.Fonts.AddFontDefault();

            io.Fonts.GetTexDataAsRGBA32(out byte* pixels, out int width, out int height, out int _);
            glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, pixels);

            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, (int)GL_LINEAR);
            glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, (int)GL_LINEAR);

            io.Fonts.SetTexID((IntPtr)_texture);
            io.Fonts.ClearTexData();

            SetKeyMap();

            glClearColor(1.0f, 0.0f, 1.0f, 1.0f);

            glEnableVertexAttribArray(0);
            glEnableVertexAttribArray(1);
            glEnableVertexAttribArray(2);

            glGenBuffers(1, out _vertexBuffer);
            glGenBuffers(1, out _indexBuffer);

            glEnable(GL_BLEND);
            glBlendEquation(GL_FUNC_ADD);
            glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
            glDisable(GL_CULL_FACE);
            glDisable(GL_DEPTH_TEST);
        }

        private void SetKeyMap()
        {
            var io = ImGui.GetIO();

            io.KeyMap[(int)ImGuiKey.Tab] = GLFW_KEY_TAB;
            io.KeyMap[(int)ImGuiKey.LeftArrow] = GLFW_KEY_LEFT;
            io.KeyMap[(int)ImGuiKey.RightArrow] = GLFW_KEY_RIGHT;
            io.KeyMap[(int)ImGuiKey.UpArrow] = GLFW_KEY_UP;
            io.KeyMap[(int)ImGuiKey.DownArrow] = GLFW_KEY_DOWN;
            io.KeyMap[(int)ImGuiKey.PageUp] = GLFW_KEY_PAGE_UP;
            io.KeyMap[(int)ImGuiKey.PageDown] = GLFW_KEY_PAGE_DOWN;
            io.KeyMap[(int)ImGuiKey.Home] = GLFW_KEY_HOME;
            io.KeyMap[(int)ImGuiKey.End] = GLFW_KEY_END;
            io.KeyMap[(int)ImGuiKey.Delete] = GLFW_KEY_DELETE;
            io.KeyMap[(int)ImGuiKey.Backspace] = GLFW_KEY_BACKSPACE;
            io.KeyMap[(int)ImGuiKey.Enter] = GLFW_KEY_ENTER;
            io.KeyMap[(int)ImGuiKey.Escape] = GLFW_KEY_ESCAPE;
        }

        private float _elapsed;

        protected override void Update(float elapsed)
        {
            _elapsed = elapsed;
        }

        protected override void OnKeyboard(int key, int scancode, int action, int mods)
        {
            base.OnKeyboard(key, scancode, action, mods);

            if (_keyStates.ContainsKey(key))
                _keyStates[key] = action != GLFW_RELEASE;
        }

        protected override void OnText(uint codepoint)
        {
            base.OnText(codepoint);

            var io = ImGui.GetIO();
            io.AddInputCharacter(codepoint);
        }

        protected override void OnMouseMove(double xpos, double ypos)
        {
            base.OnMouseMove(xpos, ypos);
            _mousePosition.X = (float)xpos;
            _mousePosition.Y = (float)ypos;
        }

        protected override void OnMouseButton(int button, int action, int mods)
        {
            base.OnMouseButton(button, action, mods);
            _mouseButtons[button] = action != GLFW_RELEASE;
        }

        protected override void Draw()
        {
            var io = ImGui.GetIO();
            io.DeltaTime = _elapsed / 1000.0f;
            io.DisplaySize = new Vector2(WindowWidth, WindowHeight);
            io.DisplayFramebufferScale = Vector2.One;

            UpdateInput(io);

            ImGui.NewFrame();

            ImGui.ShowDemoWindow();

            // ImGui.SetNextWindowPos(new Vector2(10, 10));
            ImGui.SetNextWindowSize(new Vector2(600, 600));
            ImGui.Begin("Hello World");
            ImGui.Text("This is some text...");
            ImGui.InputText("Name", _name, (uint)_name.Length);
            ImGui.End();

            ImGui.Render();

            var drawData = ImGui.GetDrawData();

            glViewport(0, 0, WindowWidth, WindowHeight);

            glDisable(GL_SCISSOR_TEST);
            glClear(GL_COLOR_BUFFER_BIT);
            glEnable(GL_SCISSOR_TEST);

            glUseProgram(_program);

            glBindBuffer(GL_ARRAY_BUFFER, _vertexBuffer);
            glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, _indexBuffer);

            glVertexAttribPointer(0, 2, GL_FLOAT, false, VertexSizeInBytes, (IntPtr)0);
            glVertexAttribPointer(1, 2, GL_FLOAT, false, VertexSizeInBytes, (IntPtr)8);
            glVertexAttribPointer(2, 4, GL_UNSIGNED_BYTE, true, VertexSizeInBytes, (IntPtr)16);

            glActiveTexture(GL_TEXTURE0);
            glBindTexture(GL_TEXTURE_2D, _texture);
            glUniform1i(_fragTextureLocation, 0);

            for (int n = 0; n < drawData.CmdListsCount; n++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[n];

                glBufferData(GL_ARRAY_BUFFER, cmdList.VtxBuffer.Size * VertexSizeInBytes, cmdList.VtxBuffer.Data, GL_STREAM_DRAW);
                glBufferData(GL_ELEMENT_ARRAY_BUFFER, cmdList.IdxBuffer.Size * sizeof(ushort), cmdList.IdxBuffer.Data, GL_STREAM_DRAW);

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

                    glUniformMatrix4fv(_vertProjectionLocation, 1, false, ref projection[0]);

                    glScissor(
                        (int)drawCmd.ClipRect.X,
                        WindowHeight - (int)drawCmd.ClipRect.W,
                        (int)(drawCmd.ClipRect.Z - drawCmd.ClipRect.X),
                        (int)(drawCmd.ClipRect.W - drawCmd.ClipRect.Y));

                    glDrawElements(
                        GL_TRIANGLES,
                        (int)drawCmd.ElemCount,
                        GL_UNSIGNED_SHORT,
                        (IntPtr)(drawCmd.IdxOffset * sizeof(ushort)));
                }
            }
        }

        private void UpdateInput(ImGuiIOPtr io)
        {
            foreach (var key in _keyStates.Keys)
                io.KeysDown[key] = _keyStates[key];

            io.KeyAlt = _keyStates[GLFW_KEY_LEFT_ALT] || _keyStates[GLFW_KEY_RIGHT_ALT];
            io.KeyCtrl = _keyStates[GLFW_KEY_LEFT_CONTROL] || _keyStates[GLFW_KEY_RIGHT_CONTROL];
            io.KeyShift = _keyStates[GLFW_KEY_LEFT_SHIFT] || _keyStates[GLFW_KEY_RIGHT_SHIFT];
            io.KeySuper = _keyStates[GLFW_KEY_LEFT_SUPER] || _keyStates[GLFW_KEY_RIGHT_SUPER];

            io.MousePos = new Vector2(_mousePosition.X, _mousePosition.Y);

            for (int i = 0; i < io.MouseDown.Count; i++)
                io.MouseDown[i] = _mouseButtons[i];
        }
    }
}
