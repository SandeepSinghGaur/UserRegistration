using System;

namespace UserRegistrationValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            //Console.WriteLine("Enter First Name :");
            //string first_name = Console.ReadLine();
            //RegexValidation.FirstNameMatch(first_name);
            //Console.WriteLine("Enter Last Name :");
            //string last_name = Console.ReadLine();
            //RegexValidation.LastNameMatch(last_name);
            //Console.WriteLine("Enter Email :");
            //string email = Console.ReadLine();
            //RegexValidation.EmailMatch(email);
            //Console.WriteLine("Enter Mobile Number :");
            //string mobile_number = Console.ReadLine();
            //RegexValidation.MobileNumberMatch(mobile_number);
            //Console.WriteLine("Enter Password With First Condition :");
            //string password01 = Console.ReadLine();
            //RegexValidation.PasswordMatch(password01);
            Console.WriteLine("Enter Password With Condition :Password Having atleast One UpperCase");
            string password02 = Console.ReadLine();
            RegexValidation.PasswordMatch02(password02);
        }
    }
}
