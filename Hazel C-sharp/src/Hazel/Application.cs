using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GLAD;
using Hazel.Input;
using Hazel.OS.Windows;

namespace Hazel
{

    public class Application 
    {
        private bool m_Running = false;
        public static Application Instance = null;

        public Application()
        {
            window = new WindowsWindow(new UI.WindowProps(1280, 720));
            window.SetEventCallback(OnEvent);
            if (Instance == null) return;
            Instance = this;
        }

        public void PushLayer(Layer layer)
        {
            m_LayerStack.PushLayer(layer);
        }

        public void pushOverlay(Layer layer)
        {
            m_LayerStack.PushOverlay(layer);
        }

        public void Run()
        {
            m_Running = true;
            while (m_Running)
            {
                foreach (Layer L in m_LayerStack.m_Layers)
                {
                    L.OnUpdate();
                }
                window.Onupdate();
            }
            
        }

        public void OnEvent(Event e)
        {
            EventDispatcher ed = new EventDispatcher(e);
            ed.Dispatch<WindowCloseEvent>(OnWindowClose);

            Debug.DLog(e);

            foreach(Layer L in m_LayerStack.m_Layers)
            {
                L.OnEvent(e);
                if (e.m_Handled)
                    break;
            }

        }

        bool OnWindowClose(WindowCloseEvent e)
        {
            m_Running = false;
            window.ShutDown();
            return true;
        }

        public WindowsWindow window { get; private set; }
        private LayerStack m_LayerStack = new LayerStack();
    }
}
