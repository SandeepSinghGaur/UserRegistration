using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
    class RegexValidation
    {

        public static string FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static void FirstNameMatch(string first_name)
        {
            bool result = Regex.IsMatch(first_name, FIRST_NAME);
            if (result)
                Console.WriteLine("Yes ! First Name is Validate");
            else
                Console.WriteLine("No ! First Name is not Validate");
        }
        public static string LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static void LastNameMatch(string last_name)
        {
            bool result = Regex.IsMatch(last_name, LAST_NAME);
            if (result == true)
                Console.WriteLine("Yes ! Last Name is Validate");
            else
                Console.WriteLine("No ! Last Name is not Validate");
        }
        public static string EMAIL = "^[1-9A-Za-z]+[.][a-zA-Z]*@(bl)[.](co)([.](in))?$";
        public static void EmailMatch(string email)
        {
            bool result = Regex.IsMatch(email, EMAIL);
            if (result == true)
                Console.WriteLine("Yes ! Email is Validate");
            else
                Console.WriteLine("No ! Email is not Validate");

        }
        public static string MOBILE_NUMBER = "^(91)[ ][789][0-9]{9}$";
        public static void MobileNumberMatch(string mobile_number)
        {
            bool result = Regex.IsMatch(mobile_number, MOBILE_NUMBER);
            if (result == true)
                Console.WriteLine("Yes ! Mobile Number is Validate");
            else
                Console.WriteLine("No ! Mobile Number is not Validate");
        }
        public static string PASSWORD01 = "^[A-Za-z0-9]{8,}$";
        public static void PasswordMatch(string password01)
        {
            bool result = Regex.IsMatch(password01, PASSWORD01);
            if (result == true)
                Console.WriteLine("Yes ! Password is Validate");
            else
                Console.WriteLine("No ! Password is not Validate");

        }
    }
}
