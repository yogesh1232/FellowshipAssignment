using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_In_Regex
{
    internal class User_Registration
    {
        public static string FIRST_NAME_REGEX = "^[A-Z]{1}[a-z]+$";
        public bool ValidateFirstName(string fName)
        {
            return Regex.IsMatch(fName, FIRST_NAME_REGEX);
        }

        public static string LAST_NAME_REGEX = "^[A-Z]{1}[a-z]+$";
        public bool ValidateLastName(string lName)
        {
            return Regex.IsMatch(lName, LAST_NAME_REGEX);
        }

        public static string REGEX_MobileNo = "^[0-9]{1,2}[ ][0-9]{10}$"; // 91 9919819801
        public bool ValidateMobileNo(string MobileNo)
        {
            return Regex.IsMatch(MobileNo, REGEX_MobileNo);
        }

        public static string REGEX_EMail = "^(abc).?[a-z]{3,}[@](bl).?(co).?[a-z]{2,}$"; //abc.xyz@bl.co.in
        public bool ValidateEMail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMail);
        }

        public static string REGEX_Password1 = "^[A-Z a-z]{8,}$"; //yogeshkusakiya
        public bool ValidatePassword1(string password)
        {
            return Regex.IsMatch(password, REGEX_Password1);
        }

        //First Letter Should Be Capital
        public static string REGEX_Password2 = "^[A-Z]{1}[A-Z a-z]{7,}$"; //Yogeshkusakiya
        public bool ValidatePassword2(string password)
        {
            return Regex.IsMatch(password, REGEX_Password2);
        }

        public static string REGEX_Password3 = "^[A-Z 0-9]{1}[A-Z a-z 0-9]{8,}$";  //Yogeshusakiya1
        public bool ValidatePassword3(string password)
        {
            return Regex.IsMatch(password, REGEX_Password3);
        }

        public static string REGEX_Password4 = "^[A-Z]{1}[A-Z a-z]{7,}[!*@#$%^&+=]?[0-9]{1,}$"; //Yogeshkusakiya@1234
        public bool ValidatePassword4(string password)
        {
            return Regex.IsMatch(password, REGEX_Password4);
        }

        

    }
}
