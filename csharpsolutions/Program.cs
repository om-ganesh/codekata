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

            string option;
            do
            {
                // Call the problem class here
                IProblem problem = new IntegerMultiplication();
                problem.ReadInput();
                problem.Execute();
                problem.ShowResult();
                
                // Repeat the problem?
                Console.WriteLine("Press y/Y to repeat.");
                option = Console.ReadLine().Trim();

            }while(string.Equals(option, "y", StringComparison.InvariantCultureIgnoreCase));
            
        }

    }
}
