using System;
using System.Diagnostics;
using System.Text;
using System.Threading;
using Arqan;

namespace Example1
{
    public class Window
    {
        private IntPtr handle;
        private int width;
        private int height;
        private string title;

        private GLFW.GLFWerrorfun glfwErrorFunction;
        private GLFW.GLFWwindowsizefun glfwWindowSizeFunction;
        private GLFW.GLFWwindowclosefun glfwWindowCloseFunction;
        private GLFW.GLFWwindowrefreshfun glfwWindowRefreshFunction;
        private GLFW.GLFWcursorposfun glfwCursorPosFunction;
        private GLFW.GLFWmousebuttonfun glfwMouseButtonFunction;
        private GLFW.GLFWkeyfun glfwKeyFunction;
        private GLFW.GLFWcharfun glfwCharFunction;

        private IntPtr Handle
        {
            get { return handle; }
            set { handle = value; }
        }

        public int Width
        {
            get { return width; }
            set
            {
                width = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                height = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowSize(Handle, width, height);
                }
            }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;

                if (Handle != IntPtr.Zero)
                {
                    GLFW.glfwSetWindowTitle(Handle, value);
                }
            }
        }

        public Window(int width, int height, string title)
        {
            // Set the properties
            this.Width = width;
            this.Height = height;
            this.Title = title;
        }

        public void Open(bool fullscreen = false, bool vsync = true, bool pollEvents = true)
        {
            InitGLFW();
            InitWindow(fullscreen);
            InitEvents();
            InitSettings(vsync);

            Sync(pollEvents);
        }

        public void Close()
        {
            GLFW.glfwSetWindowShouldClose(Handle, 1);
        }

        private void InitGLFW()
        {
            if (GLFW.glfwInit() == 0)
            {
                throw new Exception("Unable to initialize glfw");
            }
        }

        private void InitWindow(bool fullscreen)
        {
            if (fullscreen)
            {
                Handle = GLFW.glfwCreateWindow(Width, Height, Encoding.ASCII.GetBytes(Title), GLFW.glfwGetPrimaryMonitor(), IntPtr.Zero);
            }
            else
            {
                Handle = GLFW.glfwCreateWindow(Width, Height, Encoding.ASCII.GetBytes(Title), IntPtr.Zero, IntPtr.Zero);
            }

            if (Handle == IntPtr.Zero)
            {
                GLFW.glfwTerminate();
                throw new Exception("Unable to create glfw window");
            }

            GLFW.glfwMakeContextCurrent(Handle);
        }

        private void InitEvents()
        {
            this.glfwErrorFunction = new GLFW.GLFWerrorfun(OnErrorFunction);
            this.glfwCharFunction = new GLFW.GLFWcharfun(OnCharFunction);
            this.glfwCursorPosFunction = new GLFW.GLFWcursorposfun(OnCursorPositionFunction);
            this.glfwKeyFunction = new GLFW.GLFWkeyfun(OnKeyFunction);
            this.glfwMouseButtonFunction = new GLFW.GLFWmousebuttonfun(OnMouseButtonFunction);
            this.glfwWindowCloseFunction = new GLFW.GLFWwindowclosefun(OnWindowCloseFunction);
            this.glfwWindowRefreshFunction = new GLFW.GLFWwindowrefreshfun(OnWindowRefreshFunction);
            this.glfwWindowSizeFunction = new GLFW.GLFWwindowsizefun(OnWindowSizeFunction);

            GLFW.glfwSetErrorCallback(this.glfwErrorFunction);
            GLFW.glfwSetWindowSizeCallback(Handle, this.glfwWindowSizeFunction);
            GLFW.glfwSetWindowCloseCallback(Handle, this.glfwWindowCloseFunction);
            GLFW.glfwSetWindowRefreshCallback(Handle, this.glfwWindowRefreshFunction);
            GLFW.glfwSetCursorPosCallback(Handle, this.glfwCursorPosFunction);
            GLFW.glfwSetMouseButtonCallback(Handle, this.glfwMouseButtonFunction);
            GLFW.glfwSetKeyCallback(Handle, this.glfwKeyFunction);
            GLFW.glfwSetCharCallback(Handle, this.glfwCharFunction);
        }

        private void InitSettings(bool vsync)
        {
            if (vsync)
            {
                GLFW.glfwSwapInterval(1);
            }
            else
            {
                GLFW.glfwSwapInterval(0);
            }
        }

        private void Sync(bool pollEvents)
        {
            // Main loop
            while (GLFW.glfwWindowShouldClose(Handle) == 0)
            {
                // Update

                // Render a background and enable some stuff for 2d rendering with alpha
                GL.glEnable(GL.GL_BLEND);
                GL.glBlendFunc(GL.GL_SRC_ALPHA, GL.GL_ONE_MINUS_SRC_ALPHA);
                GL.glViewport(0, 0, Width, Height);
                GL.glClearColor(0, 0, 0, 1);
                GL.glClear(GL.GL_COLOR_BUFFER_BIT);

                // Render

                GLFW.glfwSwapBuffers(Handle);
                GLFW.glfwPollEvents();
            }

            GLFW.glfwDestroyWindow(Handle);
        }

        /* GENERAL FUNCTIONS */
        private void OnErrorFunction(int errorCode, string description)
        {
            throw new Exception($"{errorCode}: {description}");
        }

        private void OnWindowSizeFunction(IntPtr windowHandle, int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        private void OnWindowRefreshFunction(IntPtr windowHandle)
        {
        }

        private void OnPositionFunction(IntPtr windowHandle, int x, int y)
        {
        }

        private void OnWindowCloseFunction(IntPtr windowHandle)
        {
        }

        /* INPUT FUNCTIONS */
        private void OnCursorPositionFunction(IntPtr windowHandle, double x, double y)
        {
        }

        private void OnMouseButtonFunction(IntPtr windowHandle, int button, int action, int mods)
        {
        }

        private void OnKeyFunction(IntPtr windowHandle, int key, int scanCode, int action, int mods)
        {
            if (key == GLFW.GLFW_KEY_ESCAPE && action == GLFW.GLFW_PRESS)
            {
                GLFW.glfwSetWindowShouldClose(windowHandle, 1);
            }
        }

        private void OnCharFunction(IntPtr windowHandle, uint codepoint)
        {
        }
    }
}