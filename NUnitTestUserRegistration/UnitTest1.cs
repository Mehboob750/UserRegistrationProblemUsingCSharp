using System.Runtime.InteropServices;
using ConsoleApplicationUserRegistration;
using NUnit.Framework;

namespace NUnitTestUserRegistration
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenFirstName_WhenProper_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Mehboob");
            Assert.True(result);
        }

        [Test]
        public void GivenFirstName_WhenNotProper_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("mehboob");
            Assert.False(result);
        }

        [Test]
        public void GivenFirstName_WhenSizeGreaterThanThree_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Mehb");
            Assert.True(result);
        }

        [Test]
        public void GivenFirstName_WhenSizeLessThanThree_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Me");
            Assert.False(result);
        }

        [Test]
        public void GivenFirstName_WhenEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("");
            Assert.False(result);
        }

        [Test]
        public void GivenFirstName_WhenNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateName(null);
        }

        [Test]
        public void GivenLastName_WhenProper_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Shaikh");
            Assert.True(result);
        }

        [Test]
        public void GivenLastName_WhenNotProper_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("shaikh");
            Assert.False(result);
        }

        [Test]
        public void GivenEmailId_WhenValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId("mehboob@gmail.com");
            Assert.True(result);
        }

        [Test]
        public void GivenEmailId_WhenNotValid_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId("@gmail.com");
            Assert.False(result);
        }

        [Test]
        public void GivenEmailId_WhenEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId(" ");
            Assert.False(result);
        }

        [Test]
        public void GivenEmailId_WhenNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateEmailId(null);
        }

        [Test]
        public void GivenMobileNumber_WhenValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("9854783212");
            Assert.True(result);
        }

        [Test]
        public void GivenMobileNumber_WhenLessThan10_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("854783212");
            Assert.False(result);
        }

        [Test]
        public void GivenMobileNumberWithCountryCode_WhenValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("91 9854783212");
            Assert.True(result);
        }

        [Test]
        public void GivenMobileNumberWithCountryCode_WhenSpaceNotGiven_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("919854783212");
            Assert.False(result);
        }

        [Test]
        public void GivenMobileNumber_WhenEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber(" ");
            Assert.False(result);
        }

        [Test]
        public void GivenMobileNumber_WhenNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateMobileNumber(null);
        }

        [Test]
        public void GivenPassword_WhenGreaterThan7_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("Mehboob1234A");
            Assert.True(result);
        }

        [Test]
        public void GivenPassword_WhenLessThan8_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("NH14");
            Assert.False(result);
        }

        [Test]
        public void GivenPassword_WhenEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword(" ");
            Assert.False(result);
        }

        [Test]
        public void GivenPassword_WhenNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword(null);
            Assert.False(result);
        }

        [Test]
        public void GivenPassword_WhenContainsAtLeastOneUpperCaseCharacter_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("Mehboob1234A");
            Assert.True(result);
        }

        [Test]
        public void GivenPassword_WhenNotContainsUpperCaseCharacter_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("mehboob1234");
            Assert.False(result);
        }

        [Test]
        public void GivenPassword_WhenContainsAtLeastOneNumericNumber_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("Mehboob1234A");
            Assert.True(result);
        }

        [Test]
        public void GivenPassword_WhenNotContainsNumericNumber_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("MehboobavcsA");
            Assert.False(result);
        }

        [Test]
        public void GivenPassword_WhenContainsOnlyOneSpecialCharacter_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("Mehboob@1234A");
            Assert.True(result);
        }

    }
}