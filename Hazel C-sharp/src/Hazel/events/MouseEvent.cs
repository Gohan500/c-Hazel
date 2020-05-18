using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazel.Input
{
    class MouseMovedEvent : Event
    {
        public override EventType GetStaticType()
        {
            return EventType.MouseMoved;
        }
        public MouseMovedEvent(float x, float y) : base(EventCategory.EventCategoryMouse, EventType.MouseMoved)
        {
            MouseX = x;
            MouseY = y;
        }

        public float MouseX { get; private set; } 
        public float MouseY { get; private set; }

        public override string ToString()
        {
            return "MouseMovedEvent: " + MouseX + ", " + MouseY;
        }

    }

    class MouseScrolledEvent : Event
    {
        public override EventType GetStaticType()
        {
            return EventType.MouseScrolled;
        }
        public MouseScrolledEvent(float yOffset, float xOffset) : base(EventCategory.EventCategoryMouse, EventType.MouseScrolled)
        {
            YOffset = yOffset;
            XOffset = xOffset;
        }

        public float YOffset { get; private set; }
        public float XOffset { get; private set; }

        public override string ToString()
        {
            return "MouseScrolledEvent" + XOffset + ", " + YOffset;
        }
    }

    class MouseButtonEvent : Event
    {
        protected MouseButtonEvent(int button, EventType eventType) : base(EventCategory.EventCategoryMouseButton, eventType)
        {
            Button = button;
        }

        public int Button { get; private set; }

    }

    class MouseButtenPressedEvent : MouseButtonEvent
    {
        public override EventType GetStaticType()
        {
            return EventType.MouseButtonPressed;
        }
        public MouseButtenPressedEvent(int button) : base(button, EventType.MouseButtonPressed) { }

        public override string ToString()
        {
            return "MouseButtonPressedEvent: " + Button;
        }

        

    }

    class MouseButtonReleasedEvent : MouseButtonEvent
    {
        public override EventType GetStaticType()
        {
            return EventType.MouseButtonReleased;
        }
        public MouseButtonReleasedEvent(int button) : base(button, EventType.MouseButtonReleased) { }

        public override string ToString()
        {
            return "MouseButtonReleasedEvent: " + Button;
        }

    }
}
