using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace csharpproject
{
    /// <summary>
    /// https://github.com/om-ganesh/codekata/tree/master/csharpproject
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Challenges");

            string option;
            do
            {

                // Replace your running program here

                IProblem problem = new KLargestInArray();
                //problem.ReadInput();
                problem.Execute();
                //problem.ShowResult();
                
                // skeleton for running application
                Console.WriteLine("Press y/Y to repeat.");
                option = Console.ReadLine().Trim();
            }while(string.Equals(option, "y", StringComparison.InvariantCultureIgnoreCase));
        }

    }
}
