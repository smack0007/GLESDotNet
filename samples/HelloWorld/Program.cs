using GLFWDotNet.Utilities;
using System;
using static GLFWDotNet.GLFW;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Application.Init())
                return;

            var window = new Window();
            window.Title = "Hello World!";
            window.MakeContextCurrent();

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
    }
}
