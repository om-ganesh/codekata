using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 8, 9, 12, 34 };
            BinarySearch bs = new BinarySearch(arr);
            int element = 38;
            Console.Write($"Searching {element} resulted {bs.Search(element)}");
        }
    }
}
