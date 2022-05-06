using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LoadCSV
{
    public static class EMail
    {
        // Regular expression used to validate an Email.  
        public const string emailRegex = @"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public static bool IsEmail(string email)
        {
            if (email != null) return Regex.IsMatch(email, emailRegex);
            else
                return false;
        }
    }
}
