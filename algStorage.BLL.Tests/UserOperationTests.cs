using Microsoft.VisualStudio.TestTools.UnitTesting;
using algStorage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using algStorage.DAL.Repositories;

namespace algStorage.BLL.Tests
{
    [TestClass()]
    public class UserOperationTests
    { 

        [TestMethod()]
        public void UserAuthenticationTest()
        {
            //arrange
            UserOperation uo = new UserOperation();
            string name = "TestName";
            string pass = "TestPass";
            bool role = false;

            bool expected = true;

            //act
            bool actualAdd = uo.UserAdd(name, pass, role);

            bool actualAuth = uo.UserAuthentication(name, pass);

            bool actualDelete = uo.UserDelete(uo.GetUserId(name));

            //assert
            Assert.AreEqual(expected, actualAdd);
            Assert.AreEqual(expected, actualAuth);
            Assert.AreEqual(expected, actualDelete);
        }
    }
}