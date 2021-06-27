using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class Pattern
    {
        /// <summary>
        /// sample Emails
        /// </summary>
        private List<string> sampleMails =new List<string>()
        {
             "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };

        public string Regex_FirstName = "^[A-Z][a-z]{3,}$";
        public string Regex_LastName = "^[A-Z][a-z]{3,}$";
        public string Regex_EmailId = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public string Regex_MobileFormat = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";
        public string Regex_Password1 = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public string Regex_All_Emailid = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        

        /// <summary>
        /// Using lambda function refactoring the given parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public bool Validate_firstName(string firstName) => (Regex.IsMatch(firstName, Regex_FirstName));
        public bool Validate_LastName(string lastName) => (Regex.IsMatch(lastName, Regex_LastName));
        public bool Validate_Email(string email) => (Regex.IsMatch(email, Regex_EmailId));
        public bool Validate_MobileFormat(string mobNumber) => (Regex.IsMatch(mobNumber, Regex_MobileFormat));
        public bool Validate_password1(string password) => (Regex.IsMatch(password, Regex_Password1));
        public bool validate_EmailIdAll(string email) => (Regex.IsMatch(email, Regex_All_Emailid));
      
      
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        public List<string> GetList()
        {
            return sampleMails;
        }
    }
}
