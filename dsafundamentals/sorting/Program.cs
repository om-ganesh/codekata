using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = null;
            SortingBase sortingBase;

            Console.WriteLine("From Selection Sorting");
            arr = new int[]{ 12, 23, 8, -1, 78 };
            sortingBase = new SelectionSort(arr);
            sortingBase.Execute();
            sortingBase.Print();

            Console.WriteLine("From Insertion Sorting");
            arr = new int[] { 23, 8, 12, 78, -1 };
            sortingBase = new InsertionSort(arr);
            sortingBase.Execute();
            sortingBase.Print();

            Console.WriteLine("From Bubble Sorting");
            arr = new int[] { 78, -1, 23, 8, 12 }; 
            sortingBase = new BubbleSort(arr);
            sortingBase.Execute();
            sortingBase.Print();

            Console.WriteLine("From Merge Sorting"); 
            arr = new int[] { 38, 27, 42, 3, 9, 82, 10 };
            sortingBase = new MergeSort(arr);
            sortingBase.Execute();
            sortingBase.Print();

            Console.Read();
        }
    }
}
