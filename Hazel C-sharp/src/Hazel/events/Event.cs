using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hazel.Input { 
    
    public enum EventType
    {
        None = 0,
        WindowClose, WindowResize, WindowFocus, WindowLostFocus, WindowMoved,
        AppTick, AppUpdate, AppRender,
        KeyPressed, KeyReleased,
        MouseButtonPressed, MouseButtonReleased, MouseMoved, MouseScrolled
    }

    public enum EventCategory
    {
        None = 0,
        EventCategoryApplication    = (1<<0),
        EventCategoryInput          = (1<<1),
        EventCategoryKeyBoard       = (1<<2),
        EventCategoryMouse          = (1<<3),
        EventCategoryMouseButton    = (1<<4)
    }

    public class Event
    {
        public bool m_Handled = false;

        public Event(EventCategory category, EventType type)
        {
            this.eventCategory = category;
            this.eventType = type;


        }

        public virtual EventType GetStaticType()
        {
            return EventType.None;
        }

        public EventCategory eventCategory { get; private set; } = EventCategory.EventCategoryApplication;
        public EventType eventType { get; private set; }
        public string name { get { return eventType.ToString(); } }
        
        
    }
    
    class EventDispatcher
    {
        public delegate bool test<T>(T e) where T : Event;
        
        Event e;
        public EventDispatcher(Event e)
        {
            this.e = e;
        }

        public bool Dispatch<T>(test<T> d) where T : Event
        {
            if(e is T)
            {
                e.m_Handled = d(e as T);
                return true;
            }
            return false;
        }

    }
}
