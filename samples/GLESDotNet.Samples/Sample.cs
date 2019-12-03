using System;
using System.Diagnostics;
using static GLFWDotNet.GLFW;
using static GLESDotNet.EGL;
using static GLESDotNet.GLES2;
using GLFWDotNet.Utilities;
using System.IO;
using System.Reflection;

namespace GLESDotNet.Samples
{
    public abstract class Sample : IDisposable
    {
        private const float TimeBetweenFrames = 1000.0f / 60.0f;

        private IntPtr _display;
        private IntPtr _surface;

        private Stopwatch _stopwatch = new Stopwatch();
        private float _lastElapsed;
        private float _elapsedSinceLastFrame;

        private float _fpsElapsed;

        public Window Window { get; }

        public Keyboard Keyboard { get; }

        public int FramesPerSecond { get; private set; }

        public Sample()
        {
            var basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Directory.SetCurrentDirectory(basePath);

            if (!Application.Init())
                throw new InvalidOperationException("Failed to initialize GLFW.");

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            Window = new Window();
            CreateContext();

            Keyboard = new Keyboard(Window);
        }

        ~Sample()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private unsafe void CreateContext()
        {
            _display = eglGetDisplay((IntPtr)EGL_DEFAULT_DISPLAY);

            int majorVersion, minorVersion;
            if (!eglInitialize(_display, &majorVersion, &minorVersion))
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
                if (!eglChooseConfig(_display, configAttributesPtr, &config, 1, &configCount) || (configCount != 1))
                {
                    throw new InvalidOperationException();
                }
            }

            int[] surfaceAttributes = new int[]
            {
                EGL_NONE, EGL_NONE,
            };

            fixed (int* surfaceAttribtuesPtr = surfaceAttributes)
            {
                _surface = eglCreateWindowSurface(_display, config, Window.GetNativeHandle(), surfaceAttribtuesPtr);
            }

            if (_surface == IntPtr.Zero)
            {
                eglGetError(); // Clear error and try again
                _surface = eglCreateWindowSurface(_display, config, IntPtr.Zero, null);
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
                context = eglCreateContext(_display, config, IntPtr.Zero, contextAttributesPtr);
                if (eglGetError() != EGL_SUCCESS)
                {
                    throw new InvalidOperationException();
                }
            }

            eglMakeCurrent(_display, _surface, _surface, context);
            if (eglGetError() != EGL_SUCCESS)
            {
                throw new InvalidOperationException();
            }

            // Turn off vsync
            eglSwapInterval(_display, 0);

            glInit(eglGetProcAddress);

            //string title = "RENDERER: " + Marshal.PtrToStringAnsi(glGetString(GL_RENDERER)) + " ";
            //title += "VENDOR: " + Marshal.PtrToStringAnsi(glGetString(GL_VENDOR)) + " ";
            //title += "VERSION: " + Marshal.PtrToStringAnsi(glGetString(GL_VERSION));
            //text += "EXTENSIONS: " + Environment.NewLine + glGetString(GL_EXTENSIONS);
        }

        protected virtual void Dispose(bool disposing)
        {
            Application.Terminate();
        }

        public void Run()
        {
            _stopwatch.Restart();

            Initialize();

            Application.Run(Window, () =>
            {
                if (Keyboard[Keys.Escape])
                {
                    Window.Close();
                    return;
                }

                Tick();
            });
        }

        private void Tick()
        {
            float currentElapsed = (float)_stopwatch.Elapsed.TotalMilliseconds;
            float deltaElapsed = currentElapsed - _lastElapsed;
            _elapsedSinceLastFrame += deltaElapsed;
            _lastElapsed = currentElapsed;

            bool shouldDraw = _elapsedSinceLastFrame >= TimeBetweenFrames;

            while (_elapsedSinceLastFrame >= TimeBetweenFrames)
            {
                Update(_elapsedSinceLastFrame);
                _elapsedSinceLastFrame -= TimeBetweenFrames;
            }

            if (shouldDraw)
            {
                Draw();
                eglSwapBuffers(_display, _surface);
                FramesPerSecond++;
            }

            _fpsElapsed += deltaElapsed;

            if (_fpsElapsed >= 1000.0f)
            {
                _fpsElapsed -= 1000.0f;
                FramesPerSecond = 0;
            }
        }

        protected virtual void Initialize()
        {
        }

        protected virtual void Update(float elapsed)
        {
        }

        protected virtual void Draw()
        {
        }

        protected virtual void Shutdown()
        {
        }
    }
}
