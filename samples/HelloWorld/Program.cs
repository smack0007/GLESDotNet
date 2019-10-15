using GLFWDotNet.Utilities;
using System;
using static GLFWDotNet.GLFW;
using static ANGLEDotNet.EGL;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    unsafe class Program
    {
        [DllImport("glfw3.dll")]
        private static extern IntPtr glfwGetWin32Window(IntPtr window);
        
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            var window = new Window();
            CreateContext(window);
            window.Title = "Hello World!";

            var keyboard = new Keyboard(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                {
                    window.Close();
                }
            });

            Application.Terminate();
        }

        private static void CreateContext(Window window)
        {
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
                (int)EGL_RED_SIZE, 8,
                (int)EGL_GREEN_SIZE, 8,
                (int)EGL_BLUE_SIZE, 8,
                (int)EGL_ALPHA_SIZE, 8,
                (int)EGL_DEPTH_SIZE, 24,
                (int)EGL_STENCIL_SIZE, 8,
                (int)EGL_SAMPLE_BUFFERS, unchecked((int)EGL_DONT_CARE),
                (int)EGL_NONE
            };

            IntPtr config;
            int configCount;
            if (!eglChooseConfig(display, configAttributes, out config, 1, out configCount) || (configCount != 1))
            {
                throw new InvalidOperationException();
            }

            int[] surfaceAttributes = new int[]
            {
                (int)EGL_NONE, (int)EGL_NONE,
            };

            IntPtr surface;
            surface = eglCreateWindowSurface(display, config, glfwGetWin32Window(window.Handle), surfaceAttributes);

            if (surface == IntPtr.Zero)
            {
                eglGetError(); // Clear error and try again
                surface = eglCreateWindowSurface(display, config, IntPtr.Zero, null);
            }

            //if (EGL.GetError() != EGL.SUCCESS)
            //{
            //    throw new Exception();
            //}

            //int[] contextAttibutes = new int[]
            //{
            //    EGL.CONTEXT_CLIENT_VERSION, 2,
            //    EGL.NONE
            //};

            //IntPtr context = EGL.CreateContext(display, config, IntPtr.Zero, contextAttibutes);
            //if (EGL.GetError() != EGL.SUCCESS)
            //{
            //    throw new Exception();
            //}

            //EGL.MakeCurrent(display, surface, surface, context);
            //if (EGL.GetError() != EGL.SUCCESS)
            //{
            //    throw new Exception();
            //}

            ////// Turn off vsync
            //EGL.SwapInterval(display, 0);

            //GLES.ClearColor(1.0f, 0, 0, 1.0f);

            //string text = "RENDERER: " + GLES.GetString(GLES.RENDERER) + Environment.NewLine;
            //text += "VENDOR: " + GLES.GetString(GLES.VENDOR) + Environment.NewLine;
            //text += "VERSION: " + GLES.GetString(GLES.VERSION) + Environment.NewLine;
            //text += "EXTENSIONS: " + Environment.NewLine + GLES.GetString(GLES.EXTENSIONS);
        }
    }
}
