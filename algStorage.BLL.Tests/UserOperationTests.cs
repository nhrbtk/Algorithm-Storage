using Microsoft.VisualStudio.TestTools.UnitTesting;
using algStorage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

using algStorage.DAL_ADO.Domain;
using algStorage.DAL_ADO.Repositories;



namespace algStorage.BLL.Tests
{
    [TestClass()]
    public class UserOperationTests
    { 

        [TestMethod()]
        public void UserAuthenticationTest_falseReturned()
        {
            //arrange
            var mock = new Mock<UserRepository>();
            mock.Setup(a => a.GetAll()).
                Returns(new List<User>
                {
                    new User() { Username = "TESTINGUSERNAME", Password = "TESTINGPASSWORD"}
                });
            UserOperation userOp = new UserOperation(mock.Object);

            //act
            bool actual = userOp.UserAuthentication("TESTINGUSERNAME", "TESTINGPASSWORD");

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void UserAdd_trueReturned()
        {
            //arrange
            var mock = new Mock<UserRepository>();
            mock.Setup(a => a.GetAll())
                .Returns(new List<User>()
                {
                    new User{ Username="u", Password="pw", Role=false}
                });
            UserOperation userOp = new UserOperation(mock.Object);

            //act
            bool actual = userOp.UserAdd("helloworld","password", true);

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void UserAdd_falseReturned()
        {
            //arrange
            var mock = new Mock<UserRepository>();
            string un = "username";
            string pw = "password";
            bool role = false;
            mock.Setup(a => a.GetAll())
                .Returns(new List<User>()
                {
                    new User{ Username=un, Password=pw, Role=role}
                });
            
            UserOperation userOp = new UserOperation(mock.Object);

            //act
            bool actual = userOp.UserAdd(un, pw, role);

            //assert
            Assert.IsFalse(actual);
        }
    }
}