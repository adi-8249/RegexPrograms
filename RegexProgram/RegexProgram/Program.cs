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

            foreach (string mail in pattern.GetList())
            {
                Console.Write(mail + " : ");
                pattern.PrintResult(pattern.validate_EmailIdAll(mail));
            }
        }
    }
}
