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
            bool result = validator.ValidateFirstName("Mehboob");
            Assert.True(result);
        }

        [Test]
        public void When_GivenFirstName_IfNotProper_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateFirstName("mehboob");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfSizeGreaterThanThree_ShouldReturnTrue()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateFirstName("Mehb");
            Assert.True(result);
        }

        [Test]
        public void When_GivenFirstName_IfSizeLessThanThree_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateFirstName("Me");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfEmpty_ShouldReturnFalse()
        {
            UserValidator validator = new UserValidator();
            bool result = validator.ValidateFirstName("");
            Assert.False(result);
        }

        [Test]
        public void When_GivenFirstName_IfNull_ShouldThrowException()
        {
            UserValidator validator = new UserValidator();
            validator.ValidateFirstName(null);
        }

    }
}