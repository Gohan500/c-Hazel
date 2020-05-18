using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.UI;
using GLFW.Game;
using GLFW;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Hazel.Input;

namespace Hazel.OS.Windows
{

    public class WindowsWindow : IWindow
    {
        
        static void GLFWErrorCallback(ErrorCode code, IntPtr message)
        {
            Debug.LogError("GLFW Error: "+code +" "+ message);
        }

        public WindowsWindow(WindowProps props)
        {
            Init(props);
        }

        private void Init(WindowProps props)
        {
            m_Data.Title = props.Title;
            m_Data.Width = props.Width;
            m_Data.Height = props.Height;

            Debug.Log($"Creating Window {props.Title} ({props.Width}, {props.Height})");

            if (!s_GLFWInitialized)
            {
                bool succes = Glfw.Init();

                if (!succes)
                {
                    Debug.LogError("Could not initailize GLFW!");
                    return;
                }
                Glfw.SetErrorCallback(GLFWErrorCallback);
                s_GLFWInitialized = true;
            }

            
            m_Window = Glfw.CreateWindow((int)props.Width, (int)props.Height, props.Title, Monitor.None, Window.None);
            Glfw.MakeContextCurrent(m_Window);
            SetVSync(true);

            #region // Set GLFW callbacks
            Glfw.SetWindowSizeCallback(m_Window, delegate(Window window,int width,int height)
            {

                WindowsWindow.m_Data.Width = (uint)width;
                WindowsWindow.m_Data.Height = (uint)height;

                WindowsWindow.m_Data.d(new WindowResizeEvent((uint)width, (uint)height));
                
            });

            Glfw.SetCloseCallback(m_Window, delegate (Window window)
            {
                

                WindowsWindow.m_Data.d(new WindowCloseEvent());
                
            });

            Glfw.SetKeyCallback(m_Window, delegate(Window window, Keys key, int scanCode, InputState state, ModifierKeys mods)
            {
                

                switch (state)
                {
                    case InputState.Release:
                        {
                            WindowsWindow.m_Data.d(new KeyReleasedEvent((int)key));
                        }
                        break;
                    case InputState.Press:
                        {
                            WindowsWindow.m_Data.d(new KeyPressedEvent((int)key, 0));
                        }
                        break;
                    case InputState.Repeat:
                        {
                            WindowsWindow.m_Data.d(new KeyPressedEvent((int)key, 1));
                        }
                        break;
                }

                
                
            });

            Glfw.SetMouseButtonCallback(m_Window, delegate (Window window, MouseButton button, InputState state, ModifierKeys modifiers)
            {
                

                switch (state)
                {
                    case InputState.Release:
                        {
                            WindowsWindow.m_Data.d(new MouseButtonReleasedEvent((int)button));
                        }
                        break;
                    case InputState.Press:
                        {
                            WindowsWindow.m_Data.d(new MouseButtenPressedEvent((int)button));
                        }
                        break;
                    
                }


                
            });

            Glfw.SetScrollCallback(m_Window, delegate (Window window, double x, double y)
            {
                

                WindowsWindow.m_Data.d(new MouseScrolledEvent((float)x, (float)y));

                
            });

            Glfw.SetCursorPositionCallback(m_Window, delegate (Window window, double x, double y)
            {
                

                WindowsWindow.m_Data.d(new MouseMovedEvent((float)x, (float)y));

                
            });

            #endregion

        }

        public void ShutDown()
        {
            Glfw.DestroyWindow(m_Window);
        }

        public void Terminate()
        {
            ShutDown();
            Glfw.Terminate();
        }

        public void Onupdate()
        {
            Glfw.PollEvents();
            Glfw.SwapBuffers(m_Window);
        }

        public void SetEventCallback(Del d)
        {
            WindowsWindow.m_Data.d = d;
            
        }

        public void SetVSync(bool enable)
        {
            if (enable)
                Glfw.SwapInterval(1);
            else
                Glfw.SwapInterval(0);

            m_Data.VSync = enable;
        }

        public struct WindowData
        {
            public string Title { get; internal set; }
            public uint Width { get; internal set; }
            public uint Height { get; internal set; }
            public bool VSync { get; internal set; }

            public Del d { get { return _d; } set { Debug.Log(value); _d = value; } }
            public Del _d;

            public static readonly WindowData None;

        }

        public Window m_Window { get; private set; }
        private bool s_GLFWInitialized = false;
        public static WindowData m_Data;
        private GCHandle handle;
        private GCHandle handle2;
        }
}
