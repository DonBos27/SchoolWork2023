using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _220153695_Bosenga_SemTest1
{
    internal class DataManager
    {
        public string[] Data { get; set; }
        private Data[] data;
        public int currentIndex ;
        string filePath = "./MOCK_DATA.csv";
        //function to read
        public Data [] readFromFile()
        {
            List<Data> list = new List<Data>();
            string[] pathArray = File.ReadAllLines(filePath);
            foreach (var line in pathArray)
            {
                string[] splitPathArray = line.Split(',');
                    Data members = new Data();
                    members.Number = Convert.ToInt32(splitPathArray[0]);
                    members.Name = splitPathArray[1];
                    members.Surname = splitPathArray[2];
                    members.Email = splitPathArray[3];
                    members.Gender = splitPathArray[4];
                    members.IPAddress = splitPathArray[5];
                    list.Add(members);
            }
            return list.ToArray();
        }
        //function to display domain
        public Data[] determineDomain(string domain)
        {
            List<Data> list = new List<Data>();
            string[] pathArray = File.ReadAllLines(filePath);
            Data[] records = readFromFile();
            foreach (Data record in records)
            {
                if (record.Email.EndsWith(domain))
                {
                    list.Add(record);
                }

            }
            return list.ToArray();
        }

        public int Counter(int i)
        {
            i = 0;
            return i;

        }
        public Data getRecord(int index )
        {
            return data[index];
        }

    }
}
