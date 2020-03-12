using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharpsolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Challenges");

            IProblem problem = new DynamicArray();
            problem.Execute();
            problem.ShowResult();
        }

    }
}
