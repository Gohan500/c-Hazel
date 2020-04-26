using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.UI;
using GLFW;

namespace Hazel.OS.Windows
{

    public class WindowsWindow : IWindow
    {
        

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

            if(!s_GLFWInitialized)
            {
                bool succes = Glfw.Init();

                if(!succes)
                {
                    Debug.LogError("Could not initailize GLFW!");
                    return;
                }
                s_GLFWInitialized = true;
            }

            m_Window = Glfw.CreateWindow((int)props.Width, (int)props.Height, props.Title, Monitor.None, Window.None);
            Glfw.MakeContextCurrent(m_Window);
            SetVSync(true);
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
            while (!Glfw.WindowShouldClose(m_Window))
            {
                Glfw.PollEvents();
                Glfw.SwapBuffers(m_Window);
            }
        }

        public void SetEventCallback(Del d)
        {
            m_Data.d = d;
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

            public Del d { get; internal set; }
        }

        private Window m_Window;
        private bool s_GLFWInitialized = false;
        WindowData m_Data;
        }
}
