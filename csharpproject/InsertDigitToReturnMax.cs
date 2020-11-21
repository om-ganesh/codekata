using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class InsertDigitToReturnMax : IProblem
    {
        int digit = 5;
        List<int> dataset = new List<int>();

        public InsertDigitToReturnMax()
        {
            dataset.AddRange(new[] { 97642, -97642, 5555, 1234, -1234, 4321, 21, -456, 9, -9, 0, 200, -200, 206, 204, -206, -204 });
        }
        
        public void Execute()
        {
            dataset.ForEach(number =>
            {
                int result = GiveMaxByInsertingDigit(number, digit);
                Console.WriteLine($"The max number after inserting {digit} in between number {number} = {result}");
            }); 
        }

        private int GiveMaxByInsertingDigit(int number, int digit)
        {
            int result = 0;

            if(number>0)
            {
                return GetMaxForPositiveNumber(number, digit);
            }
            else
            {
                return GetMaxForNegativeNumber(number, digit);
            }

        }


        private int GetMaxForPositiveNumber(int number, int digit)
        {
            // Set initially the two halves of number such that left*10^bits-1 + right = N
            int left = 0;
            int right = number;//97642, 4 
            int bits = (int)Math.Ceiling(Math.Log10((double)right));//5,3

            while (bits >1)//T,T,T
            {
                int msb = right / (int)Math.Pow(10, bits - 1);//9,7,6,4
                if (digit >= msb)//F,F,F,T
                {
                    // ( 976*10+5 ) * (10^2) + 42 => 9765 * 100 + 42 => 976542
                    return (left * 10 + digit) * (int)Math.Pow(10, bits) + right;
                }
                left = left * 10 + msb; //9,97,976
                right = right % (int)Math.Pow(10, bits - 1);//7642,642,42
                bits--;//4,3,2
            }
            //insert 7 in 98
            return digit >= right ? (left * 10 + digit) * 10  + right : (left * 10 + right) * 10 + digit;
        }

        private int GetMaxForNegativeNumber(int number, int digit)
        {
            // Set initially the two halves of number such that left*10^bits-1 + right = N //-1234
            int left = 0;
            int right = -1 * number;//1234
            int bits = (int)Math.Ceiling(Math.Log10((double)right));//4

            while (bits > 1)//T
            {
                int msb = right / (int)Math.Pow(10, bits - 1);//1,2,3
                if (digit <= msb)//F,F,F
                {
                    // ( 976*10+5 ) * (10^2) + 42 => 9765 * 100 + 42 => 976542
                    return -1 * ((left * 10 + digit) * (int)Math.Pow(10, bits) + right);
                }
                left = left * 10 + msb; //1,12,123
                right = right % (int)Math.Pow(10, bits - 1);//234,34,4
                bits--;//3,2,1
            }
            return -1 * (digit <= right ? (left * 10 + digit) * 10 + right : (left * 10 + right) * 10 + digit);
        }
    }
}
