using System;

namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Array Problems!");

            //Problem1: LowerBoundSTL
            RunLowerBoundSTL();

            Console.ReadLine();
        }


        static void RunLowerBoundSTL()
        {
            //LowerBoundSTL Problem
            int n = 8;
            int[] nArray = { 1,1,2,3,6,9,9,15};
            int q = 4;
            int[] qArray = { 1,4,9,15};

            LowerBoundSTL lBoundSTL = new LowerBoundSTL(n, nArray, q, qArray);
            lBoundSTL.Execute();
            lBoundSTL.ShowResult();
        }
    }
}
