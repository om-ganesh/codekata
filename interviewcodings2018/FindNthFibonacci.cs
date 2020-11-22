using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    public class FindNthFibonacci
    {
        static int[] memory;
        static long totalIteration;
        public static void Init()
        {
            int n = 5;
            totalIteration = 0;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int result = GetNFibonacci(n);
            watch.Stop();
            Console.WriteLine($"The {n} fibonacci number is found {result} in {totalIteration} loops" +
                $" and {watch.ElapsedMilliseconds / 1000} secs");

            //Measure using the memory solution
            //Test(n=45): General: 2B loops in 30 seconds, Memory: <100 loops in 0 ms
            totalIteration = 0;
            watch.Restart();
            result = GetNFibonacciWithMemory(n);
            watch.Stop();
            Console.WriteLine($"The {n} fibonacci number is found {result} in {totalIteration} loops" +
                $" and {watch.ElapsedMilliseconds} ms");
        }

        private static int GetNFibonacci(int n)
        {
            totalIteration++;
            if (n == 1 || n == 2)
            {
                return 1;
            }
            int result = GetNFibonacci(n - 1) + GetNFibonacci(n - 2);
            return result;
        }
        private static int GetNFibonacciWithMemory(int n)
        {
            totalIteration++;
            if (memory == null)
            {
                memory = new int[n + 1];
                memory[1] = memory[2] = 1;
            }
            if (memory[n] != 0)
                return memory[n];

            if (n == 1 || n == 2)
            {
                return 1;
            }
            int result = GetNFibonacciWithMemory(n - 1) + GetNFibonacciWithMemory(n - 2);
            memory[n] = result;
            return result;
        }
    }
}
