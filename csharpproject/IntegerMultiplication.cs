using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    class IntegerMultiplication : IProblem
    {
        int input1;
        int input2;
        int result;
            
        public IntegerMultiplication()
        {
            input1 = 5678;
            input2 = 1234;
        }
        public void Execute()
        {
            result = Multiply(input1, input2);
        }

        private int Multiply(int x, int y)
        {
            //base case for this recursive algorithm
            if(x>10 || y>10)
            {
                return x * y;
            }
            var ab = Split(x);
            var cd = Split(y);
            // Multiply Tens
            int ac = Multiply(ab.Item1, cd.Item1);
            // Multiply Ones
            int bd = Multiply(ab.Item2, cd.Item2);
            // Add the digits and Multiply
            int step3 = Multiply(ab.Item1 + ab.Item2, cd.Item1 + cd.Item2);
            int step4 = step3 - bd - ac;
            int step5 = ac * 10000 + bd + step4 * 100;
            return step5;
        }

        private Tuple<int, int> Split(int number)
        {
            string n = number.ToString();
            return Tuple.Create<int, int>(Int32.Parse(n.Substring(0, n.Length / 2)), Int32.Parse(n.Substring(n.Length/2)));
        }

        public void ReadInput()
        {
            Console.WriteLine("Enter First integer");
            bool success = Int32.TryParse(Console.ReadLine(), out input1);
            Console.WriteLine("Enter Second integer");
            success = Int32.TryParse(Console.ReadLine(), out input2);
            
            if (!success)
            {
                Console.WriteLine("Invalid Inputs. Repeat the process");
            }
        }

        public void ShowResult()
        {
            Console.WriteLine($"Multiplication (Karatsuba) of {input1} and {input2} is {result}");
        }
    }
}
