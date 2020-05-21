using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazel
{
    class LayerStack
    {

        public LayerStack()
        {
            m_Layers = new List<Layer>();
            index = 0;
        }

        public void PushLayer(Layer layer)
        {
            m_Layers.Insert(index, layer);
            index = m_Layers.IndexOf(layer);
            Debug.DLog(index);
        }

        public void PushOverlay(Layer layer)
        {
            m_Layers.Add(layer);
        }

        public void PopLayer(Layer layer)
        {
            if (m_Layers.IndexOf(layer) != m_Layers.Count - 1)
            {
                m_Layers.Remove(layer);
                index--;
            }
        }

        public void PopOverlay(Layer layer)
        {
            if (m_Layers.IndexOf(layer) != m_Layers.Count - 1)
                m_Layers.Remove(layer);
        }


        public List<Layer> m_Layers { get; private set; }
        int index;
    }
}
