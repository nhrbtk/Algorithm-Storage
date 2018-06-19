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
    public class AlgorithmOperationTests
    {
        [TestMethod()]
        public void GetUserAlgoritmsTest_ListReturned()
        {
            //arrange
            List<Algorithm> getList = new List<Algorithm>
            {
                new Algorithm{Id=2, Title="test", Path="path", Input="input", Output="output", UserId=2},
                new Algorithm{Id=4, Title="test", Path="path", Input="input", Output="output", UserId=2},
                new Algorithm{Id=6, Title="test", Path="path", Input="input", Output="output", UserId=2}
            };

            List<int> expectedList = new List<int> { 2, 4, 6 };



            var mock = new Mock<AlgorithmRepository>();
            mock.Setup(a => a.GetAll()).Returns(getList);
            AlgorithmOperation algorithmOperation = new AlgorithmOperation(mock.Object);

            //act
            List<int> actualList = algorithmOperation.GetUserAlgoritms(2);

            //assert


            Assert.AreEqual(expectedList, actualList);
        }
    }
}