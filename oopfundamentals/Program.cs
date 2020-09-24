using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("@GM!!!");
            WhatIsVirtual.Init();
            WhatIsStaticInitializer staticInitializer = new WhatIsStaticInitializer();
            WhatIsStaticInitializer.Init();

            //Others
            BuiltInCollections.Init();

            Console.Read();
        }
    }
}
