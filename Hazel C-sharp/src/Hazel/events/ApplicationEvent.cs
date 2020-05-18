using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazel.Input
{
    class WindowResizeEvent : Event
    {
        public override EventType GetStaticType()
        {
            return EventType.WindowResize;
        }
        public WindowResizeEvent(uint width, uint height) : base(EventCategory.EventCategoryApplication, EventType.WindowResize)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
        {
            return "WindowResizeEvent: " + Width + ", " + Height;
        }

        public uint Width { get; private set; }
        public uint Height { get; private set; }
    }

    class WindowCloseEvent : Event
    {
        public override EventType GetStaticType()
        {
            return EventType.WindowClose;
        }
        public WindowCloseEvent() : base(EventCategory.EventCategoryApplication, EventType.WindowClose) { }
        public override string ToString()
        {
            return "WindowCloseEvent";
        }

    }

    class AppTickEvent : Event
    {

        public AppTickEvent() : base(EventCategory.EventCategoryApplication, EventType.AppTick) { }

    }

    class AppUpdateEvent : Event
    {

        public AppUpdateEvent() : base(EventCategory.EventCategoryApplication, EventType.AppUpdate) { }

    }

    class AppRenderEvent : Event
    {

        public AppRenderEvent() : base(EventCategory.EventCategoryApplication, EventType.AppRender) { }

    }
}
