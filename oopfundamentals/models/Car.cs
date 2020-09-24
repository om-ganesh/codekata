using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfundamentals.models
{
    public class Car : Vehicle
    {
        public Car(String color, float mph):base(color)
        {
            this.mph = mph;
        }
        public float mph { get; set; }

        public override void print_virtual()
        {
            Console.WriteLine("Inside derived print_virtual()");

        }

        public void print()
        {
            Console.WriteLine("Inside derived print()");

        }
    }
}
