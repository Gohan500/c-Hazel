using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hazel.Input;

namespace Hazel { 
    


    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            foreach(Start s in EventHandle.starts)
            {
                s();
            }
        }
    }
    
}
