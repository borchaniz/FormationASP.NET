using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var controller = new ValuesController();
            //Act
            int r=controller.add(2, 5);
            //Assert 
            Assert.AreEqual(r, 7);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var controller = new ValuesController();
            //Act
            int r = controller.add(2, 5);
            //Assert 
            Assert.AreEqual(r, 3);
        }

    }
}
