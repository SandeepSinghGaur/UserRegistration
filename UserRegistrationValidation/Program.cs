using System;

namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("Enter First Name :");
            string first_name = Console.ReadLine();
            RegexValidation.FirstNameMatch(first_name);
        }
    }
}
