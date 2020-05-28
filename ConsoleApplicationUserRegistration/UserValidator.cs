using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplicationUserRegistration
{
    public class UserValidator
    {
       private readonly static String NAME_PATTERN ="^[A-Z]{1}[a-z]{2,}$";
       private readonly static String EMAIL_PATTERN = "^[0-9a-zA-Z]+([._+-][0-9a-zA-Z]+)*@[0-9a-zA-Z]+.[a-zA-Z]{2,4}([.][a-zA-Z]{2,3})?$";
       private readonly static String MOBILE_PATTERN = "^([0-9]{2}[ ])?([1-9]{1}[0-9]{9})$";
       private readonly static String PASSWORD_PATTERN = "((?=.*[a-z])*([(@#$*)-])*(?=.*[A-Z])(?=.*[0-9]).{8,})";

        public bool ValidateName(string name)
        {
            return Validate(name, NAME_PATTERN);
        }

        public bool ValidateEmailId(string emailId)
        {
            return Validate(emailId, EMAIL_PATTERN);
        }

        public bool ValidateMobileNumber(String mobileNumber)
        {
            return Validate(mobileNumber, MOBILE_PATTERN);
        }

        public bool ValidatePassword(string password)
        {
            return Validate(password, PASSWORD_PATTERN);
        }

        public bool Validate(string field,String pattern)
        {
            try
            {
                if (field == null)
                    throw new NullReferenceException("Field Should Not Be Null");
                if (Regex.Match(field, pattern).Success)
                    return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }

    }
}
