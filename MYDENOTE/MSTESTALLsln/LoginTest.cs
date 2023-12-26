using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using BUS;
using DAT;
using DTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTESTALLsln
{
    [TestClass]
    public class LoginTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void UserDAO_checkLogin_returnBOOL()
        {
            // Arrange
            var objUser = new User("asd", "asd");
            var objUserDAO = new UserDAO();

            // Act
            bool result = objUserDAO.checkLogin(objUser);

            // Assert
            result.Should().BeTrue();
        }

        [TestMethod]
        public void UserDAO_getUserId_returnINT()
        {
            // Arrange
            var objUserDAO = new UserDAO();
            var objUser = new User("asd", "asd");

            // Act
            int result = objUserDAO.getUserId(objUser);

            // Assert using FluentAssertions
            result.Should().BePositive();
        }

        [TestMethod] // 1 test case ~ UNIT TEST
        public void UserDAO_getUsername_returnSTRING()
        {
            // Arrange
            var objUserDAO = new UserDAO();
            var objUser = new User("asd", "asd");

            // Act
            string result = objUserDAO.getUsername(objUser);

            // Assert using FluentAssertions
            result.Should().BeOfType(typeof(string));
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",@".\DataDrivenTest\SignUpallCase.csv", "SignUpallCase#csv", DataAccessMethod.Sequential)]
        public void UserDAO_AddUser_returnVOID()
        {
            // Arrange

            string username = TestContext.DataRow[0].ToString();
            string password = TestContext.DataRow[1].ToString();
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            var objUser = new User(username, hashPassword);
            var objUserBUS = new UserBUS();
            var objUserDAO = new UserDAO();
            // check is User is added 
            // test will be passed if User is added and not throw any exception
            // Act
            Action act = () => objUserBUS.AddUser(objUser);
            act.Should().Throw<InvalidOperationException>();
            act = () => objUserDAO.AddUser(objUser);

            // Assert
            act.Should().NotThrow();
            
        }
    }
}
