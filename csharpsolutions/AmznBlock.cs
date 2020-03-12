using csharpsolutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpsolutions
{
    class AmznBlock : IProblem
    {
        int[] inputArray;
        int quantity = 0;

        public AmznBlock()
        {
            //int[] arr = {0,1,0,2,1,0,1,3,2,1,2,1 };//output=6
            //int[] arr = { 0,0,2,0,1,0,2,0,3,0,1,1};//output=8
            //int[] arr =  {0, 0, 4, 0, 1, 0, 2, 0, 3, 0, 1, 1, 4};//output=28
            //int[] arr = { 1,2,3,4,3,2,1,1,2,3,4};//output=12
            //int[] arr = { 0, 0, 0, 1, 1, 0, 0 };//output=0
            //int[] arr = { 5, 0, 0 };  //output=0
            //int[] arr = { 0, 2 }; //output=0
            //int[] arr = { 1 }; //output=0
            //int[] arr = { 0,0,3,0 };//output=0
            //int[] arr = { 1,2,3,2,1 };//ouput=0
            //int[] arr = { 3,2,1,0,1,2 };//output=4
            this.inputArray = new int[]{ 3, 2, 3, 2, 3, 2 };//output=2
        }

        public void Execute()
        {
            int qty = 0;
            // Trim away the leading and trailing 0s from input array
            int[] arr = inputArray.Trim();
            int start = arr[0];
            int end = GetMyClosing(0, arr);
            for(int i =1; i< arr.Length-1; i++)
            {
                if(arr[i]==end)
                {
                    start = arr[i];
                    end = GetMyClosing(i, arr);
                }
                else
                {
                    qty += (start<end?start:end)- arr[i];
                }
                if (end == 0)
                    break;
            }

            this.quantity = qty;
        }

        public void ShowResult()
        {
            Console.WriteLine($"Showing the total water reserved from input array {string.Join(',', inputArray)}");

            Console.WriteLine($"Result = {quantity}");
        }

        private int GetMyClosing(int index, int[] arr)
        {
            int myClosing = 0;
            for(int i =index+1; i<arr.Length;i++)
            {
                if (arr[i] >= arr[index])
                    return arr[i];
                
                if (arr[i] > myClosing)
                    myClosing = arr[i];
            }
            return myClosing;
        }
    }
}
