using oopfundamentals.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfundamentals
{
    public class WhatIsVirtual
    {
        public static void Init()
        {

            //Test Overriding
            Vehicle v1, v2;

            Console.WriteLine("Instantiate derived class");
            v1 = new Car("Red", 34f);
            v1.print();
            v1.print_virtual();

            Console.WriteLine("Instantiate base class");
            v2 = new Vehicle("Yellow");
            v2.print();
            v2.print_virtual();
        }

    }
}
