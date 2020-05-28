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
       private readonly static String PASSWORD_PATTERN = "((?=.+[a-z])(?=.+[A-Z]).{8,})";
        public bool ValidateName(string firstName)
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

        public bool ValidateEmailId(string emailId)
        {
            try
            {
                if (emailId == null)
                    throw new NullReferenceException("EmailId Should Not Be Null");
                if (Regex.Match(emailId, EMAIL_PATTERN).Success)
                    return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }

        public bool ValidateMobileNumber(String mobileNumber)
        {
            try
            {
                if (mobileNumber == null)
                    throw new NullReferenceException("Mobile Number Should Not Be Null");
                if (Regex.Match(mobileNumber, MOBILE_PATTERN).Success)
                    return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }

        public bool ValidatePassword(string password)
        {
            try
            {
                if (password == null)
                    throw new NullReferenceException("Password Should Not Be Null");
                if (Regex.Match(password, PASSWORD_PATTERN).Success)
                    return true;
            }
            catch (Exception e)
            {

            }
            return false;
        }
    }
}
