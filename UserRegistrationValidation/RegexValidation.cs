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
    }
}
