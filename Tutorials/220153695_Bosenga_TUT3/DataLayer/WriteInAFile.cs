using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLayer
{
    //in the class to write all my data
    internal class WriteInAFile
    {
        string filePath = "./Staff.txt";
        public void WriteTheFile(string data)
        {
            string stuRecord = data;
            File.AppendAllText(filePath, stuRecord);

            //using (var written = new StreamWriter(filePath,true))
            //{
            //    written.WriteLine(stuRecord);
            //}
        }
    }
}
