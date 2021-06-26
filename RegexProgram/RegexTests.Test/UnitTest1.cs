using NUnit.Framework;
using RegexProgram;

namespace RegexTests.Test
{
    public class Tests
    {
      

        [Test]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string firstName = "Anjaneya";
            //Act
            bool result = pattern.Validate_firstName(firstName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string lastName = "Tosh";
            //Act
            bool result = pattern.Validate_LastName(lastName);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string email = "anjaneyaprasad9437@gmail.com";
            //Act
            bool result = pattern.Validate_Email(email);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string mobileNumber = "91 7064308525";
            //Act
            bool result = pattern.Validate_MobileFormat(mobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string password = "anjaneya@8249";
            //Act
            bool result = pattern.Validate_password1(password);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [Test]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string firstName = "Anjaneya";
            //Act
            bool result = pattern.Validate_firstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string lastName = "Tosh";
            //Act
            bool result = pattern.Validate_LastName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string email = "anjneyaToshgmail.com";
            //Act
            bool result = pattern.Validate_Email(email);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string mobileNumber = "0824977597";
            //Act
            bool result = pattern.Validate_MobileFormat(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [Test]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Pattern pattern = new Pattern();
            string password = "anjaneya@2545";
            //Act
            bool result = pattern.Validate_password1(password);
            //Assert
            Assert.IsTrue(result);
        }
    }
}