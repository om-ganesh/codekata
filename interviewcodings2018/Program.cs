using interviewcodings2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("@Affinity!!!");
            ArrayDuplicateChecker.Init();
            GenerateRandomPointInsideCircle.Init();

            Console.WriteLine("@IBM!!!");
            ArrayElementSumToN.Init();  //What if input in 1 million and doesn't fit in memory
            MaximumDifferentWordInString.Init();

            Console.WriteLine("@Others!!!");
            IsStringsAnagram.Init();
            FindNthFibonacci.Init();
            SecondLargestElement.Init();
            LongestSequenceBetweenStrings.Init();

            Console.Read();
        }
    }
}
