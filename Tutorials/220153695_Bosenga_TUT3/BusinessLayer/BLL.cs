using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class BLL
    {
        //class of the data layer
        DLL obj = new DLL();
        //class to calculate the age
        Age age= new Age();
        //class to generate the email
        Email email = new Email();

        //Function that return the age from the class age
        public string Age(string id)
        {
            return age.CalculateAge(id).ToString();
        }
        //Function that return the email from the class email
        public string Email(string name, string surname)
        {
            return email.GenerateEmail(name, surname);
        }
        //A void function that will write the age and the email into the file
        public void WriteAll(string name, string surname, string id)
        {
            string display = $"{Email(name,surname)} {Age(id)} \n";
            obj.WriteFile(display);
        }
        //FFunction that helps us to read in the business logic layer
        public List<string> ReadAllFile()
        {
            List<string> list = new List<string>();
            List<string> lstFromData = obj.ReadFile();
            foreach (var items in lstFromData)
            {
                string[] splitLinesUserDetails = items.Split(' ');
                string details = $"{splitLinesUserDetails[1]}";
                list.Add(details);
            }   
            return list;

        }
    }
}
