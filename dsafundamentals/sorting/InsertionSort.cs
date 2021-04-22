using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class InsertionSort:SortingBase
    {
        public InsertionSort(int[] arr) : base(arr) { }

        public override void Execute()
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0 && arr[j - 1] > arr[j]; j--)
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                }
            }
        }
    }
}
