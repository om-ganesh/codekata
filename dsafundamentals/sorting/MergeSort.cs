using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class MergeSort : SortingBase
    {
        public MergeSort(int[] arr) : base(arr) { }
        public override void Execute()
        {
            Sort(arr, 0, arr.Length - 1);
        }

        public void Sort(int[] n, int min, int max)
        {
            if (min < max)
            {
                int mid = (min + max) / 2;

                Sort(n, min, mid);
                Sort(n, mid + 1, max);
                Merge(n, min, max);
            }
        }

        private void Merge(int[] n, int min, int max)
        {
            int mid = min + (max-min) / 2;
            int[] aux = new int[n.Length];

            for (int ii = 0; ii <= max; ii++)
            {
                if (ii <= mid)
                    aux[ii] = n[ii];
                else
                    aux[ii] = n[max - ii + mid + 1];
            }

            int i = min, j = max;
            for (int k = min; k <= max; k++)
            {
                if (aux[j] < aux[i])
                    n[k] = aux[j--];
                else
                    n[k] = aux[i++];
            }
        }
    }
}
