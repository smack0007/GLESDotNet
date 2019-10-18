using GLFWDotNet.Utilities;
using System;
using static GLFWDotNet.GLFW;
using static GLESDotNet.EGL;
using static GLESDotNet.GLES2;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    unsafe class Program
    {        
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            var window = new Window();
            var (display, surface) = CreateContext(window);

            var keyboard = new Keyboard(window);

            Application.Run(window, () =>
            {
                if (keyboard[Keys.Escape])
                { 
                    window.Close();
                    return;
                }

                glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

                eglSwapBuffers(display, surface);
            });

            Application.Terminate();
        }

        private static (IntPtr Display, IntPtr Surface) CreateContext(Window window)
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

            glClearColor(1.0f, 0, 0, 1.0f);

            string title = "RENDERER: " + Marshal.PtrToStringAnsi(glGetString(GL_RENDERER)) + " ";
            title += "VENDOR: " + Marshal.PtrToStringAnsi(glGetString(GL_VENDOR)) + " ";
            title += "VERSION: " + Marshal.PtrToStringAnsi(glGetString(GL_VERSION));
            //text += "EXTENSIONS: " + Environment.NewLine + glGetString(GL_EXTENSIONS);

            window.Title = title;

            return (display, surface);
        }
    }
}
