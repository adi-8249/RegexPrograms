using System;

namespace RegexProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome to Regex programs");
            Pattern pattern = new Pattern();
            Console.WriteLine(pattern.Validate_firstName("Anjaneya"));
            Console.WriteLine(pattern.Validate_LastName("Tosh"));
            Console.WriteLine(pattern.Validate_Email("abc.xyz@bl.co.in"));

        }
    }
}
