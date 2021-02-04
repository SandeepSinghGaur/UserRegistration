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
            Func< string, bool> status = ( FIRST_NAME) =>
            {
                bool result = Regex.IsMatch(first_name, FIRST_NAME);
                return result;
            };
            bool result = status.Invoke("^[A-Z]{1}[A-Za-z]{2,}$");
            return result;
        }



        public static bool LastNameMatch(string last_name)
        {
            Func< string, bool> status = ( FIRST_NAME) =>
            {
                bool result = Regex.IsMatch(last_name, FIRST_NAME);
                return result;
            };
            bool result = status.Invoke("^[A-Z]{1}[A-Za-z]{2,}$");
            return result;
        }
        public static bool EmailMatch(string email)
        {
            Func< string, bool> status = ( Email) =>
            {
                bool result = Regex.IsMatch(email, Email);
                return result;
            };
            bool result = status.Invoke("^[1-9A-Za-z]+[.][a-zA-Z]*@(bl)[.](co)([.](in))?$");
            return result;
        }
        public static bool MobileNumberMatch(string phone_number)
        {
            Func<string, bool> status = ( MOBILE_NUMBER) =>
            {
                bool result = Regex.IsMatch(phone_number, MOBILE_NUMBER);
                return result;
            };
            bool result = status.Invoke("^(91)[ ][789][0-9]{9}$");
            return result;
        }
        public static bool PasswordMatch(string password)
        {
            Func< string, bool> status = ( PASSWORD01) =>
            {
                bool result = Regex.IsMatch(password, PASSWORD01);
                return result;
            };
            bool result = status.Invoke("^[A-Za-z0-9]{8,}$");
            return result;
        }
        public static bool PasswordMatch02(string password)
        {
            Func< string, bool> status = ( PASSWORD02) =>
            {
                bool result = Regex.IsMatch(password, PASSWORD02);
                return result;
            };
            bool result = status.Invoke( "^(?=.*[A-Z])[a-zA-Z0-9]{8,}$");
            return result;

        }
        public static bool PasswordMatch03(string password)
        {
            Func< string, bool> status = ( PASSWORD03) =>
            {
                bool result = Regex.IsMatch(password, PASSWORD03);
                return result;
            };
            bool result = status.Invoke( "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$");
            return result;

        }
        public static bool PasswordMatch04(string password)
        {
            Func< string, bool> status = ( PASSWORD04) =>
            {
                bool result = Regex.IsMatch(password, PASSWORD04);
                return result;
            };
            bool result = status.Invoke("^(?=.*[A-Z])(?=.*[0-9])(?=.*[@$!_%*#?&]{1})[a-zA-Z0-9@$!_%*#?&]{8,}$");
            return result;

        }
    }
}
