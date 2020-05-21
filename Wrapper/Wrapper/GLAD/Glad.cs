using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GLAD
{
    public static class Glad
    {
        public delegate IntPtr getprocaddress(string procName);

        internal const string LIBRARY = "d:\\visual studio\\Hazel C-sharp\\x64\\Debug\\GLAD\\GLAD.dll";

        [DllImport(LIBRARY, CallingConvention = CallingConvention.Cdecl, EntryPoint = "gladLoadGLLoader")]
        public static extern int LoadGLLoader(getprocaddress getprocaddress);


    }
}
