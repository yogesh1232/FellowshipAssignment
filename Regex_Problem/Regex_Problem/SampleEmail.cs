using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace User_Registration_In_Regex
{
    internal class SampleEmail
    {
        public static string REGEX_SampleEmails = "^[0-9A-Za-z]+([._+-@][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$"; //abc@gmail.com.com
        public bool ValidateEmail1(string email)
        {
            return Regex.IsMatch(email, REGEX_SampleEmails);
        }
    }
}
