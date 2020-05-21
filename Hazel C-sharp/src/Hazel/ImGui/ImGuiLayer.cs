using Hazel.Input;
using GLFW;
using ImGui;
using System.Numerics;
using Hazel.OS.Windows;
using System.Runtime.CompilerServices;

namespace Hazel.ImGui
{
    public class ImGuiLayer:Layer
    {

        public ImGuiLayer() 
            : base("ImGuiLayer")
        {
        }
        public override void OnAttach()
        {
            Imgui.CreateContext();
            Imgui.StyleColorsDark();

            ImGuiIOPtr io = Imgui.GetIO();
            io.BackendFlags |= ImGuiBackendFlags.HasMouseCursors;
            io.BackendFlags |= ImGuiBackendFlags.HasSetMousePos;

            // TEMPORARY: should eventually use Hazel key codes
            io.KeyMap[(int)ImGuiKey.Tab] = (int)Keys.Tab;
            io.KeyMap[(int)ImGuiKey.LeftArrow] = (int)Keys.Left;
            io.KeyMap[(int)ImGuiKey.RightArrow] = (int)Keys.Right;
            io.KeyMap[(int)ImGuiKey.UpArrow] = (int)Keys.Up;
            io.KeyMap[(int)ImGuiKey.DownArrow] = (int)Keys.Down;
            io.KeyMap[(int)ImGuiKey.PageUp] = (int)Keys.PageUp;
            io.KeyMap[(int)ImGuiKey.PageDown] = (int)Keys.PageDown;
            io.KeyMap[(int)ImGuiKey.Home] = (int)Keys.Home;
            io.KeyMap[(int)ImGuiKey.End] = (int)Keys.End;
            io.KeyMap[(int)ImGuiKey.Insert] = (int)Keys.Insert;
            io.KeyMap[(int)ImGuiKey.Delete] = (int)Keys.Delete;
            io.KeyMap[(int)ImGuiKey.Backspace] = (int)Keys.Backspace;
            io.KeyMap[(int)ImGuiKey.Space] = (int)Keys.Space;
            io.KeyMap[(int)ImGuiKey.Enter] = (int)Keys.Enter;
            io.KeyMap[(int)ImGuiKey.Escape] = (int)Keys.Escape;
            io.KeyMap[(int)ImGuiKey.A] = (int)Keys.A;
            io.KeyMap[(int)ImGuiKey.C] = (int)Keys.C;
            io.KeyMap[(int)ImGuiKey.V] = (int)Keys.V;
            io.KeyMap[(int)ImGuiKey.X] = (int)Keys.X;
            io.KeyMap[(int)ImGuiKey.Y] = (int)Keys.Y;
            io.KeyMap[(int)ImGuiKey.Z] = (int)Keys.Z;

            ImGuiNative.ImGui_ImplOpenGL3_Init("#version 410");
        }

        public override void OnDetach()
        {
            
        }

        public override void OnUpdate()
        {
            ImGuiNative.ImGui_ImplOpenGL3_NewFrame();
            Imgui.NewFrame();

            ImGuiIOPtr io = Imgui.GetIO();
            io.DisplaySize = new Vector2(WindowsWindow.m_Data.Width, WindowsWindow.m_Data.Height);

            float time = (float)Glfw.Time;
            io.DeltaTime = m_Time > 0.0 ? (time - m_Time) : (1.0f / 60.0f);
            m_Time = time;

            bool show = true;
            Imgui.ShowDemoWindow(ref show);
            
            Imgui.Render();
            ImGuiNative.ImGui_ImplOpenGL3_RenderDrawData(Imgui.GetDrawData());
        }

        public override void OnEvent(Event e)
        {
            
        }

        private float m_Time = 0.0f;

    }
}
