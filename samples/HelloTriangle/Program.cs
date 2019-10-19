using GLFWDotNet.Utilities;
using System;
using static GLFWDotNet.GLFW;
using static GLESDotNet.EGL;
using static GLESDotNet.GLES2;
using System.Runtime.InteropServices;
using System.IO;
using System.Text;

namespace HelloTriangle
{
    unsafe class Program
    {
        private static uint _program;

        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            var window = new Window();
            var (display, surface) = CreateContext(window);
            Init();

            var keyboard = new Keyboard(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                {
                    window.Close();
                    return;
                }

                Draw(window);

                eglSwapBuffers(display, surface);
            });

            Application.Terminate();
        }

        private static (IntPtr Display, IntPtr Surface) CreateContext(Window window)
        {
            eglInit();

            var display = eglGetDisplay((IntPtr)EGL_DEFAULT_DISPLAY);

            int majorVersion, minorVersion;
            if (!eglInitialize(display, &majorVersion, &minorVersion))
            {
                int error = eglGetError();
                throw new InvalidOperationException();
            }

            eglBindAPI(EGL_OPENGL_ES_API);
            if (eglGetError() != EGL_SUCCESS)
            {
                throw new InvalidOperationException();
            }

            int[] configAttributes = new int[]
            {
                EGL_RED_SIZE, 8,
                EGL_GREEN_SIZE, 8,
                EGL_BLUE_SIZE, 8,
                EGL_ALPHA_SIZE, 8,
                EGL_DEPTH_SIZE, 24,
                EGL_STENCIL_SIZE, 8,
                EGL_SAMPLE_BUFFERS, EGL_DONT_CARE,
                EGL_NONE
            };

            IntPtr config;
            int configCount;
            fixed (int* configAttributesPtr = configAttributes)
            {
                if (!eglChooseConfig(display, configAttributesPtr, &config, 1, &configCount) || (configCount != 1))
                {
                    throw new InvalidOperationException();
                }
            }

            int[] surfaceAttributes = new int[]
            {
                EGL_NONE, EGL_NONE,
            };

            IntPtr surface;
            fixed (int* surfaceAttribtuesPtr = surfaceAttributes)
            {
                surface = eglCreateWindowSurface(display, config, window.GetNativeHandle(), surfaceAttribtuesPtr);
            }

            if (surface == IntPtr.Zero)
            {
                eglGetError(); // Clear error and try again
                surface = eglCreateWindowSurface(display, config, IntPtr.Zero, null);
            }

            if (eglGetError() != EGL_SUCCESS)
            {
                throw new InvalidOperationException();
            }

            int[] contextAttibutes = new int[]
            {
                EGL_CONTEXT_CLIENT_VERSION, 2,
                EGL_NONE
            };

            IntPtr context;
            fixed (int* contextAttributesPtr = contextAttibutes)
            {
                context = eglCreateContext(display, config, IntPtr.Zero, contextAttributesPtr);
                if (eglGetError() != EGL_SUCCESS)
                {
                    throw new InvalidOperationException();
                }
            }

            eglMakeCurrent(display, surface, surface, context);
            if (eglGetError() != EGL_SUCCESS)
            {
                throw new InvalidOperationException();
            }

            // Turn off vsync
            eglSwapInterval(display, 0);

            glInit(eglGetProcAddress);

            string title = "RENDERER: " + Marshal.PtrToStringAnsi(glGetString(GL_RENDERER)) + " ";
            title += "VENDOR: " + Marshal.PtrToStringAnsi(glGetString(GL_VENDOR)) + " ";
            title += "VERSION: " + Marshal.PtrToStringAnsi(glGetString(GL_VERSION));
            //text += "EXTENSIONS: " + Environment.NewLine + glGetString(GL_EXTENSIONS);

            window.Title = title;

            return (display, surface);
        }

        private static uint LoadShader(string shaderSrc, uint type)
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

        private static void Init()
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
            
            uint vertexShader = LoadShader(vShaderStr, GL_VERTEX_SHADER);
            uint fragmentShader = LoadShader(fShaderStr, GL_FRAGMENT_SHADER);
            
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

        private static void Draw(Window window)
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

            glViewport(0, 0, window.Width, window.Height);
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
