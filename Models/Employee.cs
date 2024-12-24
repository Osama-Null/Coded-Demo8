using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    public class Employee
    {
        //use prop tab tab to create properties
        public string Name, Email, Gender;
        public string Check(string name, string email, string gender)
        {
            string msg;

            if (gender.Trim().ToUpper() == "M")
            {
                Console.Clear();
                msg = $"... Welcome Mr. {name}\n\nEmail: {email}";
                return msg;
            }
            else if (gender.Trim().ToUpper() == "F")
            {
                Console.Clear();
                msg = $"... Welcome Ms. {name}\n\nEmail: {email}";
                return msg;
            }
            else
            {
                Console.Clear();
                msg = "... Invalid Input!";
                return msg;
            }
        }
        public string Check(string name, string family, string email, string gender)
        {
            return name+family+email+gender;
        }
    }
}
