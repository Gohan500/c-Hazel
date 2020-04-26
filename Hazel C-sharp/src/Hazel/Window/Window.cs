using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.Input;

namespace Hazel.UI
{
    public struct WindowProps
    {
        public string Title;
        public uint Width;
        public uint Height;

        public WindowProps(uint width, uint height,string title = "Hazel Engine")
        {
            Title = title;
            Width = width;
            Height = height;
        }
    }

    public delegate void Del(Event e);

    interface IWindow
    {

        void Onupdate();
        void SetEventCallback(Del d);
        void SetVSync(bool enabled);

    }
}
