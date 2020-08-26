using csharpproject.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace csharpproject
{
    class StackToReverseText : IProblem
    {
        string[] input;
        string[] output;
        StackLinkedList<string> temp;

        public void ReadInput()
        {
            input = new string[] { "We", "provide", "good", "material", "for", "interview", "training" };
            output = new string[input.Length];
        }

        public void Execute()
        {
            temp = new StackLinkedList<string>();
            foreach(string str in input)
            {
                temp.push(str);
            }

            //Now pop to get in reverse
            int i = 0;
            while(!temp.IsEmpty())
            {
                output[i++] = temp.pop();
            }
        }
        

        public void ShowResult()
        {
            foreach(string str in output)
            {
                Console.Write(str+" ");
            }
            Console.WriteLine(".");
        }
    }
}
