using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplicationUserRegistration
{
    public class UserValidator
    {
       private readonly static String NAME_PATTERN ="^[A-Z]{1}[a-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            try
            {
                if (firstName == null)
                    throw new NullReferenceException("Name Should Not Be Null");
                if (Regex.Match(firstName, NAME_PATTERN).Success)
                    return true;
            }
            catch (Exception e)
            {

            }

            return false;
        }
    }
}
