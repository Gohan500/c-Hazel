using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazel.Input
{
    class KeyEvent : Event
    {
        protected KeyEvent(int Keycode, EventType eventType) : base(EventCategory.EventCategoryKeyBoard, eventType)
        {
            keyCode = Keycode;
        }
        
        public int keyCode { get; private set; }
    }
    
    class KeyPressedEvent : KeyEvent
    {

        public KeyPressedEvent(int Keycode, int repeatCount) : base(Keycode, EventType.KeyPressed)
        {
            RepeatCount = repeatCount;
        }

        public int RepeatCount { get; private set; }

        override public string ToString()
        {
            return "KeyPressedEvent: " + keyCode + " (" + RepeatCount + " repeats)";
        }
    }

    class KeyReleasedEvent : KeyEvent
    {

        public KeyReleasedEvent(int Keycode) : base(Keycode, EventType.KeyReleased) { }

        public override string ToString()
        {
            return "KeyReleasedEvent: " + keyCode;
        }

    }
}
