using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.Input;
using Hazel;

namespace SandBox
{

    class exampleLayer : Layer
    {

        public exampleLayer():base("Example") { }

        public override void OnUpdate()
        {
            Debug.Log("ExampleLayer::Update");
        }

        public override void OnEvent(Event e)
        {
            Debug.Log(e);
        }

    }

    class SandBox
    {
        public SandBox()
        {
        }

        public void Start()
        {
            Debug.Log("yeet");
            
        }

        static Application A;

        public static void Main(string[] args)
        {
            A = new Application();
            A.PushLayer(new exampleLayer());
            A.Run();
        }
    }
}
