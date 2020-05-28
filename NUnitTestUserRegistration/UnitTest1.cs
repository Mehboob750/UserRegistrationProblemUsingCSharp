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
        public void When_GivenFirstName_IfProper_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Mehboob");
            Assert.True(result);
        }

        [Test]
        public void When_GivenFirstName_IfNotProper_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("mehboob");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfSizeGreaterThanThree_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Mehb");
            Assert.True(result);
        }

        [Test]
        public void When_GivenFirstName_IfSizeLessThanThree_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Me");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateName(null);
        }

        [Test]
        public void When_GivenLastName_IfProper_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("Shaikh");
            Assert.True(result);
        }

        [Test]
        public void When_GivenLastName_IfNotProper_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateName("shaikh");
            Assert.False(result);
        }

        [Test]
        public void When_GivenEmailId_IfValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId("mehboob@gmail.com");
            Assert.True(result);
        }

        [Test]
        public void When_GivenEmailId_IfNotValid_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId("@gmail.com");
            Assert.False(result);
        }

        [Test]
        public void When_GivenEmailId_IfEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateEmailId(" ");
            Assert.False(result);
        }

        [Test]
        public void When_GivenEmailId_IfNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateEmailId(null);
        }

        [Test]
        public void When_GivenMobileNumber_IfValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("9854783212");
            Assert.True(result);
        }

        [Test]
        public void When_GivenMobileNumber_IfLessThan10_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("854783212");
            Assert.False(result);
        }

        [Test]
        public void When_GivenMobileNumberWithCountryCode_IfValid_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("91 9854783212");
            Assert.True(result);
        }

        [Test]
        public void When_GivenMobileNumberWithCountryCode_IfSpaceNotGiven_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber("919854783212");
            Assert.False(result);
        }

        [Test]
        public void When_GivenMobileNumber_IfEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateMobileNumber(" ");
            Assert.False(result);
        }

        [Test]
        public void When_GivenMobileNumber_IfNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateMobileNumber(null);
        }

        [Test]
        public void When_GivenPassword_IfGreaterThan7_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("Mehboob1234");
            Assert.True(result);
        }

        [Test]
        public void When_GivenPassword_IfLessThan8_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword("NH14");
            Assert.False(result);
        }

        [Test]
        public void When_GivenPassword_IfEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword(" ");
            Assert.False(result);
        }

        [Test]
        public void When_GivenPassword_IfNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidatePassword(null);
            Assert.False(result);
        }
    }
}