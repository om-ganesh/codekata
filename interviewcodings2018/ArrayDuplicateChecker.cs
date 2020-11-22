using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewcodings2018
{
    class ArrayDuplicateChecker
    {
        public static void Init()
        {
            String[] input = { "Bob", "Ryan", "John", "Davis", "boB" };
            Console.WriteLine($"O(N*N) result:{HasDuplicate(input)}");
            Console.WriteLine($"O(N*logN) result:{HasDuplicate(input)}");
            Console.WriteLine($"O(N) result:{HasDuplicate(input)}");
        }

        //Solution 1: O(N*N)
        private static bool HasDuplicate(String[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].Equals(arr[j], StringComparison.InvariantCultureIgnoreCase))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Solution 2: O(N*log N)
        private static bool HasDuplicate1(String[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].Equals(arr[i + 1], StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }


        //Solution 3: O(N)
        private static bool HasDuplicate2(String[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                Hashtable hashtable = new Hashtable();
                if (hashtable.Contains(arr[i]))
                {
                    return true;
                }
                hashtable.Add(arr[i], arr[i]);
            }
            return false;
        }
    }
}
