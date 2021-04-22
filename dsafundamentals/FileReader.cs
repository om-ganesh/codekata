using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace dsafundamentals
{
    public class FileReader
    {
        public static List<string> GetAllLines(string fileName)
        {
            var fullPath = Path.Combine(Environment.CurrentDirectory, fileName);
            return File.ReadAllLines(fullPath).ToList();
        }
    }
}
