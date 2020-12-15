using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    class AmznBlock : IProblem
    {
        List<int[]> dataset = new List<int[]>();

        public AmznBlock()
        {
            dataset.Add(new int[] {0,1,0,2,1,0,1,3,2,1,2,1 });//output=6
            dataset.Add(new int[] { 0,0,2,0,1,0,2,0,3,0,1,1});//output=8
            dataset.Add(new int[]  {0, 0, 4, 0, 1, 0, 2, 0, 3, 0, 1, 1, 4});//output=28
            dataset.Add(new int[] { 1,2,3,4,3,2,1,1,2,3,4});//output=12
            dataset.Add(new int[] { 0, 0, 0, 1, 1, 0, 0 });//output=0
            dataset.Add(new int[] { 5, 0, 0 });  //output=0
            dataset.Add(new int[] { 0, 2 }); //output=0
            dataset.Add(new int[] { 1 }); //output=0
            dataset.Add(new int[] { 0,0,3,0 });//output=0
            dataset.Add(new int[] { 1,2,3,2,1 });//ouput=0
            dataset.Add(new int[] { 3,2,1,0,1,2 });//output=4
            dataset.Add(new int[]{ 3, 2, 3, 2, 3, 2 });//output=2
        }

        public void Execute()
        {
            dataset.ForEach(data =>
            {
                var quantity = Trap(data);
                Console.WriteLine($"The total water reserved for {string.Join(",", data)} is {quantity}");
            });
            
        }

        public int Trap(int[] height)
        {
            if (height.Length < 3)
            {
                return 0;
            }
            int[] q1 = new int[height.Length];
            int level = height[0];
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > level)
                {
                    level = height[i];
                }
                q1[i] = level;
            }

            int[] q2 = new int[height.Length];
            level = height[height.Length - 1];
            for (int i = height.Length - 1; i >= 0; i--)
            {
                if (height[i] > level)
                {
                    level = height[i];
                }
                q2[i] = level;
            }

            var quantity = 0;
            for (int i = 0; i < height.Length; i++)
            {
                quantity += Math.Min(q1[i], q2[i]) - height[i];
            }
            return quantity;
        }

        // OLD IMPLEMENTAION OF N^2
        //public int Trap(int[] height)
        //{
        //    int quantity = 0;
        //    // Trim away the leading and trailing 0s from input array
        //    int[] arr = height.Trim();
        //    int start = arr[0];
        //    int end = GetMyClosing(0, arr);
        //    for (int i = 1; i < arr.Length - 1; i++)
        //    {
        //        if (arr[i] == end)
        //        {
        //            start = arr[i];
        //            end = GetMyClosing(i, arr);
        //        }
        //        else
        //        {
        //            quantity += (start < end ? start : end) - arr[i];
        //        }
        //        if (end == 0)
        //            break;
        //    }
        //    return quantity;
        //}

        //private int GetMyClosing(int index, int[] arr)
        //{
        //    int myClosing = 0;
        //    for(int i =index+1; i<arr.Length;i++)
        //    {
        //        if (arr[i] >= arr[index])
        //            return arr[i];
                
        //        if (arr[i] > myClosing)
        //            myClosing = arr[i];
        //    }
        //    return myClosing;
        //}
    }
}
