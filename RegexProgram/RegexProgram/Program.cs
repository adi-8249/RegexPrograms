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
        }
    }
}
