using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace dsaexposed.utility
{
    class FileReader
    {
        public static List<string> GetAllLines(string fileName)
        {
            var fullPath = Path.Combine(Environment.CurrentDirectory, fileName);
            return File.ReadAllLines(fullPath).ToList();
        }
    }
}
