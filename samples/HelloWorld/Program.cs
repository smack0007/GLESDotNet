using GLFWDotNet.Utilities;
using System;
using static GLFWDotNet.GLFW;
using static ANGLEDotNet.EGL;

namespace HelloWorld
{
    unsafe class Program
    {
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            CreateContext();

            var window = new Window();
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

        private static void CreateContext()
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

            //int[] configAttributes = new int[]
            //{
            //    EGL.RED_SIZE, 8,
            //    EGL.GREEN_SIZE, 8,
            //    EGL.BLUE_SIZE, 8,
            //    EGL.ALPHA_SIZE, 8,
            //    EGL.DEPTH_SIZE, 24,
            //    EGL.STENCIL_SIZE, 8,
            //    EGL.SAMPLE_BUFFERS, EGL.DONT_CARE,
            //    EGL.NONE
            //};

            //IntPtr config;
            //int configCount;
            //if (!EGL.ChooseConfig(display, configAttributes, out config, 1, out configCount) || (configCount != 1))
            //{
            //    throw new Exception();
            //}

            //int[] surfaceAttributes = new int[]
            //{
            //    EGL.NONE, EGL.NONE,
            //};

            //surface = EGL.CreateWindowSurface(display, config, this.Handle, surfaceAttributes);
            //if (surface == IntPtr.Zero)
            //{
            //    EGL.GetError(); // Clear error and try again
            //    surface = EGL.CreateWindowSurface(display, config, IntPtr.Zero, null);
            //}

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
