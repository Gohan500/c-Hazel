using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GLFW;
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
            Run();
        }

        public void Run()
        {
            m_Running = true;
            while (m_Running)
            {
                window.Onupdate();

            }
            
        }

        public void OnEvent(Event e)
        {
            EventDispatcher ed = new EventDispatcher(e);
            ed.Dispatch<WindowCloseEvent>(OnWindowClose);
        }

        bool OnWindowClose(WindowCloseEvent e)
        {
            Console.WriteLine("I did it " + e.ToString());
            return true;
        }

        private WindowsWindow window;
    }
}
