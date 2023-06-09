using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    internal class Email
    {
        //in the class to generate the email address by taking the first letter of the name
        public string GenerateEmail(string name, string surname)
        {
            string email = $"{name.ToLower().Substring(0, 1)}{surname.ToLower()}@uj.ac.za";
            return email;
        }
    }
}
