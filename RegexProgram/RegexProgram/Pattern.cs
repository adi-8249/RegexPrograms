using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class Pattern
    {
        public string Regex_FirstName = "^[A-Z][a-z]{3,}$";
        public string Regex_LastName = "^[A-Z][a-z]{3,}$";
        public string Regex_EmailId = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
        public string Regex_MobileFormat = "^[1-9]{1,3}[ ][1-9][0-9]{9}$";
        public string Regex_Password1 = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public string Regex_Password2 = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public bool Validate_firstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool Validate_LastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        } 
        public bool Validate_Email(string EmailId)
        {
            return Regex.IsMatch(EmailId, Regex_EmailId);
        }
        public bool Validate_MobileFormat(string mobile)
        {
            return Regex.IsMatch(mobile, Regex_MobileFormat);
        }
        public bool Validate_password1(string password)
        {
            return Regex.IsMatch(password,Regex_Password1);
        }
        public bool Validate_Password2(string password)
        {
            return Regex.IsMatch(password, Regex_Password2);
        }

    }
}
