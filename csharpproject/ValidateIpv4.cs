using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject
{
    class ValidateIpv4 : IProblem
    {
        List<string> data;

        public ValidateIpv4()
        {
            data = new List<string>();
            data.Add(".254.255.0");
            data.Add(".254.255.0");
            data.Add("1.254.255.0");
            data.Add("0.254.255.0");
            data.Add("64.233.161.00");
            data.Add("64.00.161.131");
            data.Add("01.233.161.131");
            data.Add("129380129831213981.255.255.255");
            data.Add("129abc.255.255.255");
        }
        public void Execute()
        {
            data.ForEach(input =>
            {
                var result = IsValidIP(input);
                Console.WriteLine($"{input} is valid ip? {result}");
            });
        }

        private bool IsValidIP(string x)
        {
            var splits = x.Split('.');
            if (splits.Length != 4)
            {
                return false;
            }
            foreach (var str in splits)
            {
                if (!IsInRange(str))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsInRange(string str)
        {
            if (Int32.TryParse(str, out int result))
            {
                if (result >= 0 && result <= 255)
                {
                    return str.Length == result.ToString().Length;
                }
            }
            return false;
        }
    }
}
