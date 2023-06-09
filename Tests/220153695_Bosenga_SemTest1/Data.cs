using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220153695_Bosenga_SemTest1
{
    internal class Data
    {
        //Attributes of my class
        private int num;
        private string name;
        private string surname;
        private string email;
        private string address;
        private string gender;

        public Data()
        {
            num= 0;
            name = email= address = gender = null;
        }
        // Properties of my class
        public int Number 
        { 
            get { return num; }
            set { num= value; }

        }
        public string Name 
        { 
            get{ return name; }
            set{ name= value; }
        }
        public string Surname 
        {
            get { return surname; }
            set { surname= value; }
        }
        public string Email 
        {
            get { return email; } 
            set { email= value; }
        }
        public string IPAddress 
        { 
            get
            {
                return address;
            }
            set
            {
                address = value;
            } 
        }
        public string Gender 
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

    }
}
