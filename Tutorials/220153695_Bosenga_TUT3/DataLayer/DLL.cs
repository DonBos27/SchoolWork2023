using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DLL
    {
        //class to read all my data in the file
        ReadInAFile read = new ReadInAFile();
        //class to write or add datas in the file 
        WriteInAFile write = new WriteInAFile();
        //function to return all my datas
        public List<string> ReadFile()
        {
            return read.ReadAllLines();
        }
        //function to write datas in the file
        public void WriteFile(string data)
        {
           write.WriteTheFile(data);
        }

    }
}
