using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    // You are given a number n, and need to generate all the numbers upto n in random order
    class RandomNumberGeneration:IProblem
    {
        public void Execute()
        {
            int n = 100;
            Console.WriteLine(string.Join(",", GenerateRandomSequence(n)));
        }

        private int[] GenerateRandomSequence(int n)
        {
            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i] = i;
            }

            for(int i=n-1;i>=0;i--)
            {
                int random = new Random().Next(i+1);
                Swap(arr, i, random);
            }
            return arr;
        }

        private void Swap(int[] arr,int x, int y)
        {
            int temp = arr[x];
            arr[x] = arr[y];
            arr[y] = temp;
        }
    }
}
