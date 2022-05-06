using System;
using System.Text.RegularExpressions;

namespace LoadCSV
{
    public  static class PhoneNumber
    {
        // Regular expression used to validate a phone number.  
        public const string phoneNumberRegex = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

        public static bool IsPhoneNbr(string number)
        {
            if (number != null) return Regex.IsMatch(number, phoneNumberRegex);
            else return false;
        }
    }

   
}
