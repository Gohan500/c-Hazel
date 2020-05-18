using Hazel.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazel
{
    class Layer
    {

        public string m_DebugName{ get; protected set; }

        public Layer(string debugName)
        {

        }

        public virtual void OnAttach() { }
        public virtual void OnDetach() { }
        public virtual void OnUpdate() { }
        public virtual void OnEvent(Event e) { }

    }
}
