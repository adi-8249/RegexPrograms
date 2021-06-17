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
        public bool Validate_firstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        public bool Validate_LastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        } 

    }
}
