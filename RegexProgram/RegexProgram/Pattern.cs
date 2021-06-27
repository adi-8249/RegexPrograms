using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexProgram
{
    public class Pattern
    {
        public List<string> samplelist = new List<string>()
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
        private List<string> sampleMails = new List<string>()
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



        /// <summary>
        /// here we need to compare the given task into corresponding pattern and return true
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>

        //first name
        public bool Validate_firstName(string firstName)
        {
            try
            {
                if (Regex.IsMatch(firstName, Regex_FirstName))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_FIRST_NAME, "Invalid first name.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }
        /// <summary>
        /// validate Last Name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool Validate_LastName(string lastName)
        {
            try
            {
                if (Regex.IsMatch(lastName, Regex_LastName))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_LAST_NAME, "Invalid last name.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;

        }
        /// <summary>
        /// Validate Email Address
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool Validate_Email(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Regex_EmailId))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        /// <summary>
        /// Validate Mobile Number
        /// </summary>
        /// <param name="mobNumber"></param>
        /// <returns></returns>
        public bool Validate_MobileFormat(string mobNumber)
        {
            try
            {
                if (Regex.IsMatch(mobNumber, Regex_MobileFormat))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid mobile number.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public bool Validate_password1(string password)
        {
            try
            {
                if (Regex.IsMatch(password, Regex_Password1))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_PASSWORD, "Invalid password.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public bool validate_EmailIdAll(string email)
        {
            try
            {
                if (Regex.IsMatch(email, Regex_All_Emailid))
                {
                    return true;
                }
                else
                {
                    throw new InvalidUserDetailsException(InvalidUserDetailsException.ExceptionType.INVALID_EMAIL, "Invalid email id.");
                }
            }
            catch (InvalidUserDetailsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
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
