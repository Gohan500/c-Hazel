using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.OS.Windows;
using Hazel.UI;

namespace SandBox
{
    class SandBox
    {
        public SandBox()
        {
        }

        public static void start()
        {


        }

        public static void Main(string[] args)
        {
            WindowsWindow Ww = new WindowsWindow(new WindowProps(1280, 720));
            Ww.Onupdate();
            Ww.Terminate();
        }

    }
}
