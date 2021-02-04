using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationValidation
{
   public class RegexValidation
    {

        public static string FIRST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LAST_NAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EMAIL = "^[1-9A-Za-z]+[.][a-zA-Z]*@(bl)[.](co)([.](in))?$";
        public static string MOBILE_NUMBER = "^(91)[ ][789][0-9]{9}$";
        public static string PASSWORD01 = "^[A-Za-z0-9]{8,}$";
        public static string PASSWORD02 = "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        public static string PASSWORD03 = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";
        public static string PASSWORD04 = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!_%*#?&]{1})[a-zA-Z0-9@$!_%*#?&]{8,}$";
        public static bool FirstNameMatch(string first_name)
        {
            bool result = Regex.IsMatch(first_name, FIRST_NAME);
            return result;
        }
        public static bool LastNameMatch(string last_name)
        {
            bool result = Regex.IsMatch(last_name, LAST_NAME);
            return result;
        }
        public static bool EmailMatch(string email)
        {
            bool result = Regex.IsMatch(email, EMAIL);
            return result;
        }
        public static bool MobileNumberMatch(string mobile_number)
        {
            bool result = Regex.IsMatch(mobile_number, MOBILE_NUMBER);
            return result;
        }
        public static bool PasswordMatch(string password01)
        {
            bool result = Regex.IsMatch(password01, PASSWORD01);
            return result;
        }
        public static bool PasswordMatch02(string password02)
        {
            bool result = Regex.IsMatch(password02, PASSWORD02);
            return result;
        }
        public static bool PasswordMatch03(string password03)
        {
            bool result = Regex.IsMatch(password03, PASSWORD03);
            return result;
        }
        public static bool PasswordMatch04(string password04)
        {
            bool result = Regex.IsMatch(password04, PASSWORD04);
            return result;
        }
    }
}
