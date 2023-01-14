using API_Gateway.Helpers;
using API_Gateway.Models;

namespace UnitTests
{
    [TestClass]
    public class EmployeeTest
    {
        [TestMethod]
        public void CanBePassedInteger_IDisInt_ReturnsAccepted()
        {
            // Arrange
            var employee = new Employee();

            //Act
            var result = employee.EmployeeID = 1;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EncryptPassword()
        {
            var passwd = new PasswordHashing();

            var result = passwd.Encrypt("dddd");

            Assert.IsNotNull(result);

        }
    }
}