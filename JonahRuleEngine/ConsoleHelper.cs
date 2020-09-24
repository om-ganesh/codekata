using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace JonahRuleEngine
{
    public static class ConsoleHelper
    {
        public static void PrintArray(IEnumerable<string> data)
        {
            foreach(string temp in data)
            {
                Console.WriteLine(temp);
            }
        }

        internal static void Println(string value)
        {
            Console.WriteLine(value);
        }

        internal static void Print(string value)
        {
            Console.Write(value);
        }
    }
}
