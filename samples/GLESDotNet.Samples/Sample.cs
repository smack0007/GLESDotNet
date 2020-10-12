using System;
using System.Diagnostics;
using static GLFWDotNet.GLFW;
using static GLESDotNet.EGL;
using static GLESDotNet.GLES2;
using System.IO;
using System.Reflection;

namespace GLESDotNet.Samples
{
    public abstract class Sample : IDisposable
    {
        private const float TimeBetweenFrames = 1000.0f / 60.0f;

        private string _title;

        private IntPtr _window;
        private GLFWwindowsizefun _windowSizeCallback;
        private GLFWkeyfun _keyboardCallback;
        private GLFWcursorposfun _mouseMoveCallback;
        private GLFWmousebuttonfun _mouseButtonCallback;

        private IntPtr _display;
        private IntPtr _surface;

        private Stopwatch _stopwatch = new Stopwatch();
        private float _lastElapsed;
        private float _elapsedSinceLastFrame;

        private float _fpsElapsed;

        public string Title
        {
            get => _title;

            set
            {
                if (value != _title)
                {
                    _title = value;
                    glfwSetWindowTitle(_window, _title);
                }
            }
        }

        public int WindowWidth { get; private set; }

        public int WindowHeight { get; private set; }

        public int FramesPerSecond { get; private set; }

        public int FrameBufferWidth { get; private set; }

        public int FrameBufferHeight { get; private set; }

        public Sample(string title, int windowWidth = 800, int windowHeight = 600)
        {
            var basePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            Directory.SetCurrentDirectory(basePath);

            if (glfwInit() == 0)
                throw new InvalidOperationException("Failed to initialize GLFW.");

            glfwWindowHint(GLFW_CLIENT_API, GLFW_NO_API);

            _title = title;
            _window = glfwCreateWindow(windowWidth, windowHeight, _title, IntPtr.Zero, IntPtr.Zero);

            if (_window == IntPtr.Zero)
                throw new InvalidOperationException("Failed to create window.");

            WindowWidth = windowWidth;
            WindowHeight = windowHeight;

            _windowSizeCallback = (_, width, height) => OnWindowSize(width, height);
            glfwSetWindowSizeCallback(_window, _windowSizeCallback);

            _keyboardCallback = (_, key, scancode, action, mode) => OnKeyboard(key, scancode, action, mode);
            glfwSetKeyCallback(_window, _keyboardCallback);

            _mouseMoveCallback = (_, xpos, ypos) => OnMouseMove(xpos, ypos);
            glfwSetCursorPosCallback(_window, _mouseMoveCallback);

            _mouseButtonCallback = (_, button, action, mods) => OnMouseButton(button, action, mods);
            glfwSetMouseButtonCallback(_window, _mouseButtonCallback);

            CreateContext();
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

        protected virtual void OnWindowSize(int width, int height)
        {
            WindowWidth = width;
            WindowHeight = height;
        }

        protected virtual void OnKeyboard(int key, int scancode, int action, int mods)
        {
            if (key == GLFW_KEY_ESCAPE)
                glfwSetWindowShouldClose(_window, 1);
        }

        protected virtual void OnMouseMove(double xpos, double ypos)
        {
        }

        protected virtual void OnMouseButton(int button, int action, int mods)
        {
        }

        private IntPtr GetNativeWindowHandle()
        {
            return glfwGetNativeWindow(_window);
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
                _surface = eglCreateWindowSurface(_display, config, GetNativeWindowHandle(), surfaceAttribtuesPtr);
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
        }

        protected virtual void Dispose(bool disposing)
        {
            glfwTerminate();
        }

        public void Run()
        {
            _stopwatch.Restart();

            Initialize();

            while (glfwWindowShouldClose(_window) == 0)
            {
                glfwPollEvents();

                Tick();
            }
        }

        private void Tick()
        {
            glfwGetFramebufferSize(_window, out var frameBufferWidth, out  var frameBufferHeight);
            FrameBufferWidth = frameBufferWidth;
            FrameBufferHeight = frameBufferHeight;

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
