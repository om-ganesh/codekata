using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    //Chapter2. How many 3 elements combination sums to zero in an Array?
    class ArrayTripletsSumToZero : IProblem
    {
        int[] data;
        int resultCount;

        public ArrayTripletsSumToZero()
        {
            data = new[] { -5, 2, 3, -4, -2, 1, 6, -4, 5, 0 };
            resultCount = -1;
        }

        public ArrayTripletsSumToZero(int[] arr)
        {
            this.data = arr;
            resultCount = -1;
        }

        public void Execute()
        {
            resultCount = FindTripletsUsing2Array();
            
        }

        //Assumption: there is no duplicates in array
        private int FindTripletsUsingHash()
        {
            // Avoid edge cases for less than 3 elements
            if(data.Length < 3)
            {
                return -1;
            }    

            // prepare data
            int count = 0;
            int[] data1 = new int[data.Length];
            Array.Copy(data, data1, data.Length);

            for(int i=0; i< data1.Length-2;i++)
            {
                for(int j=i+1; j< data1.Length-1;j++)
                {
                    //the elements are sorted and both of them are already positive
                    if(data1[i] >0 && data1[j]>0 )
                    {
                        break;
                    }
                    HashSet<int> hash = new HashSet<int>(data1);
                    hash.Remove(data1[i]);
                    hash.Remove(data1[j]);

                    if (hash.Contains(-1 * (data1[i] + data1[j])))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private int FindTripletsUsing2Array()
        {
            int[] inputArray = new int[data.Length];
            Array.Copy(data, inputArray, data.Length);
            Array.Sort(inputArray);
            List<Tuple<int, int, int>> triplets = new List<Tuple<int, int, int>>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool found = false;
                int current = inputArray[i];
                int left = 0;
                int right = 0;
                for (int j = i + 1, k = inputArray.Length - 1; j < k;)
                {
                    left = inputArray[j];
                    right = inputArray[k];
                    if (current + left + right == 0)
                    {
                        found = true;
                        break;
                    }
                    else if (current + left + right > 0)
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }

                if (found)
                {
                    triplets.Add(new Tuple<int, int, int>(current, left, right));
                }
            }

            return triplets.Count;
        }

        public void ReadInput()
        {
            throw new NotImplementedException();
        }

        public void ShowResult()
        {
            Console.WriteLine($"Triplets summing to zero count = {resultCount}");
        }
    }
}
