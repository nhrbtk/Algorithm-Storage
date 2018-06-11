using Microsoft.VisualStudio.TestTools.UnitTesting;
using algStorage.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algStorage.BLL.Tests
{
    [TestClass()]
    public class IsMethodsTests
    {
        [TestMethod()]
        public void IsUsernameTest_allowedSymbol_trueReturned()
        {
            //append
            string username = "My_User-Name123";

            //act
            bool actual = IsMethods.IsUsername(username);

            //assert
            Assert.IsTrue(actual);
        }

        [TestMethod()]
        public void IsUsernameTest_shortUsername_falseReturned()
        {
            //append
            string username = "Test";

            //act
            bool actual = IsMethods.IsUsername(username);

            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPasswordTest_shortPassword_falseReturned()
        {
            //append
            string password = "Test";

            //act
            bool actual = IsMethods.IsPassword(password);

            //assert
            Assert.IsFalse(actual);
        }

        [TestMethod()]
        public void IsPasswordTest_goodPassword_trueReturned()
        {
            //append
            string password = "123PASSword!";

            //act
            bool actual = IsMethods.IsPassword(password);

            //assert
            Assert.IsTrue(actual);
        }
    }
}