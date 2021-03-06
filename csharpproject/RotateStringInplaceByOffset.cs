﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    /// <summary>
    /// Given a string(Given in the way of char array) and an offset, rotate the string by offset in place. (rotate from left to right).
    /// https://www.lintcode.com/problem/rotate-string/description
    /// </summary>
    class RotateStringInplaceByOffset : IProblem
    {
        List<KeyValuePair<char[], int>> data = new List<KeyValuePair<char[], int>>();
        public RotateStringInplaceByOffset()
        {
            data.Add(new KeyValuePair<char[], int>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 0));
            data.Add(new KeyValuePair<char[], int>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 1));
            data.Add(new KeyValuePair<char[], int>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 2));
            data.Add(new KeyValuePair<char[], int>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 3));
            data.Add(new KeyValuePair<char[], int>(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g' }, 10));
        }


        public void Execute()
        {
            data.ForEach(k =>
            {
                char[] orgString = new char[k.Key.Length];
                Array.Copy(k.Key, orgString, k.Key.Length);
                RotateInplace(k.Key, k.Value);
                Console.WriteLine($"{new string(orgString)} after rotated by offset {k.Value} = {new string(k.Key)}");
            });
        }

        private void RotateInplace(char[] charArray, int offset)
        {
            Queue<char> queue = new Queue<char>();
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(charArray[i]);
            }

            while (offset > 0)
            {
                queue.Enqueue(queue.Dequeue());
                offset--;
            }

            int j = 0;
            foreach (char c in queue)
            {
                charArray[charArray.Length - j - 1] = c;
                j++;
            }
        }
    }
}
