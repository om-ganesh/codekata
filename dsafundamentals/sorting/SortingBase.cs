using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    public abstract class SortingBase
    {
        protected int[] arr;
        public SortingBase(int[] a)
        {
            this.arr = a;
        }
        public abstract void Execute();
        public void Print()
        {
            foreach (int x in arr)
            {
                Console.WriteLine(x);
            }
        }
    }
}
