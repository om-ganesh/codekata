using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfundamentals.models
{
    public class Vehicle
    {
        public Vehicle(String color) => this.color = color;
        public String color { get; set; }

        public virtual void print_virtual()
        {
            Console.WriteLine("Inside base print_virtual()");

        }

        public void print()
        {
            Console.WriteLine("Inside base print()");

        }
    }
}
