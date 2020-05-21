using System;
using System.Collections.Generic;
using System.Linq;
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

        public Application()
        {
            window = new WindowsWindow(new UI.WindowProps(1280, 720));
            window.SetEventCallback(OnEvent);
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

        private WindowsWindow window;
        private LayerStack m_LayerStack = new LayerStack();
    }
}
