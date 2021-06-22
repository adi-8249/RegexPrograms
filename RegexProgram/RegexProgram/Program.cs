using System;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Regex programs");
            Pattern pattern = new Pattern();
            //for firstName
            Console.WriteLine(pattern.Validate_firstName("Anjaneya"));
            //for lastName
            Console.WriteLine(pattern.Validate_LastName("Tosh"));
            //for given EmialId
            Console.WriteLine(pattern.Validate_Email("abc.xyz@bl.co.in"));
            //for mobile number
            Console.WriteLine(pattern.Validate_MobileFormat("91 8249775974"));
            //for passwod with first letter small
            Console.WriteLine(pattern.Validate_password1("anjaneya@8249"));
            //password for first letter capital
            Console.WriteLine(pattern.Validate_Password2("Anjaneya@8249"));
            //password using number
            Console.WriteLine(pattern.Validate_Password3("Anjaneya555"));
            //password using Special character
            Console.WriteLine(pattern.validate_password4("Anjaneya@"));
            //pattern for all emailId
            Console.WriteLine(pattern.validate_EmailIdAll("Anjaneyaprasad9437@gmail.com"));
        }
    }
}
