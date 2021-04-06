using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsaexposed.models
{
    class PriorityQueue<T> where T:IComparable<T>
    {
        List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public int Count()  
        {
            return data.Count;
        }

        public T Peek()
        {
            return data[0];
        }
    }
}
