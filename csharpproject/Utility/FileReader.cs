using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpproject.Utility
{
    
    class FileReader
    {
        readonly static string ROOT_PATH = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        const string DATA_PATH = "data";

        public static List<string> GetAllLines(string fileName)
        {
            var fullPath = Path.Combine(ROOT_PATH, DATA_PATH, fileName);
            return File.ReadAllLines(fullPath).ToList();
        }
    }
}
