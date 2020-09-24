using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfundamentals
{
    class WhatIsStaticInitializer
    {
        static WhatIsStaticInitializer()
        {
            Console.WriteLine("Inside Static Initializer");
        }
        public WhatIsStaticInitializer()
        {
            Console.WriteLine("Inside default constructor");
        }

        public static void Init()
        {
            Console.WriteLine("Inside Init() method");
        }
    }
}
