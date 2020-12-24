using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codekata.core
{
    public class FileUtility
    {
        string rootPath;
        string dataPath;
        public FileUtility(string rootPath, string dataPath = "data")
        {
            this.rootPath = rootPath;
            this.dataPath = dataPath;
        }

        public List<string> GetAllLines(string fileName, bool skipFirstLine = false)
        {
            var fullPath = Path.Combine(this.rootPath, this.dataPath, fileName);
            var lineData = File.ReadAllLines(fullPath).ToList();
            if(skipFirstLine)
            {
                lineData.RemoveAt(0);
            }
            return lineData;
        }
    }
}
