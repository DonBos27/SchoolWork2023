using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal class ReadInAFile
    {
        //in the class to read all my data
        public List<string> ReadAllLines()
        {
            string filePath = "./Staff.txt";
            string[] pathArray = File.ReadAllLines(filePath);
            List<string> lines = new List<string>(pathArray);
            return lines;
        }
    }
}
