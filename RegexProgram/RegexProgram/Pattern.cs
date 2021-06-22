﻿using System;
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
        public string Regex_Password3 = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public string Regex_Password4 = "^[a-zA-Z0-9-+_!@#$%^&*.,?]{8,}$";
        public string Regex_All_Emailid = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";


        //first name
        public bool Validate_firstName(string firstName)
        {
            return Regex.IsMatch(firstName, Regex_FirstName);
        }
        //lastname
        public bool Validate_LastName(string lastName)
        {
            return Regex.IsMatch(lastName, Regex_LastName);
        } 
        //emailid
        public bool Validate_Email(string EmailId)
        {
            return Regex.IsMatch(EmailId, Regex_EmailId);
        }
        //mobilenumber
        public bool Validate_MobileFormat(string mobile)
        {
            return Regex.IsMatch(mobile, Regex_MobileFormat);
        }
        //password
        public bool Validate_password1(string password)
        {
            return Regex.IsMatch(password,Regex_Password1);
        }
        public bool Validate_Password2(string password)
        {
            return Regex.IsMatch(password, Regex_Password2);
        }
        public bool Validate_Password3(string password)
        {
            return Regex.IsMatch(password, Regex_Password3);
        }
        public bool validate_password4(string password)
        {
            return Regex.IsMatch(password, Regex_Password4);
        }
        //for all emailid
        public bool validate_EmailIdAll(string allEmailId)
        {
            return Regex.IsMatch(allEmailId, Regex_All_Emailid);
        }

    }
}
