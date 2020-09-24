using System;
using System.Collections.Generic;
using System.Text;

namespace DSAExposed.models
{
    class SortingAlgo
    {
        public static void Init()
        {
            int[] arr = { 12, 23, 8, -1, 78 };
            SelectionSort(arr);
            Console.WriteLine("From Selection Sorting");
            Print(arr);

            arr = new int[]{ 23, 8, 12, 78, -1 };
            InsertionSort(arr);
            Console.WriteLine("From Insertion Sorting");
            Print(arr);

            arr = new int[] { 78, -1, 23, 8, 12};
            BubbleSort(arr);
            Console.WriteLine("From Bubble Sorting");
            Print(arr);

            arr = new int[] { 38, 27, 42, 3, 9, 82, 10 };
            MergeSort(arr,0, arr.Length-1);
            Console.WriteLine("From Merge Sorting");
            Print(arr);
        }

        public static void Print(int[] arr)
        {
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }

        public static void SelectionSort(int[] n)
        {
            for(int i=0;i<n.Length-1;i++)
            {
                for(int j=i+1;j<n.Length;j++)
                {
                    if(n[i]>n[j])
                    {
                        int temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                    }
                }
            }
        }

        public static void InsertionSort(int[] n)
        {
            for (int i = 1; i < n.Length; i++)
            {
                for (int j = i; j > 0 && n[j-1]>n[j]; j--)
                {
                    int temp = n[j];
                    n[j] = n[j-1];
                    n[j-1] = temp;
                }
            }
        }

        public static void BubbleSort(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < n.Length-1; j++)
                {
                    if (n[j] > n[j+1])
                    {
                        int temp = n[j];
                        n[j] = n[j+1];
                        n[j+1] = temp;
                    }
                }
            }
        }

        public static void MergeSort(int[] n, int min, int max)
        {
            if (min < max)
            {
                int mid = (min + max) / 2;

                MergeSort(n, min, mid);
                MergeSort(n, mid + 1, max);
                DoMerge(n, min, max);
            }
        }

        private static void DoMerge(int[] n, int min, int max)
        {
            int mid = (min + max) / 2;
            int[] aux = new int[n.Length];
             
            for(int ii=0;ii<=max;ii++)
            {
                if(ii<=mid)
                    aux[ii] = n[ii];
                else
                    aux[ii] = n[max-ii+mid+1];
            }

            int i = min, j = max;
            for(int k=min;k<=max;k++)
            {
                if (aux[j] < aux[i])
                    n[k] = aux[j--];
                else
                    n[k] = aux[i++];
            }
        }
    }
}
