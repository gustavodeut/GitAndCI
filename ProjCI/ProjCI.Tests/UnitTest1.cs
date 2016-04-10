using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjCI.Controllers;
using System.Web.Mvc;

namespace ProjCI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void soma()
        {
            HomeController controller = new HomeController();

            int resultado = controller.soma(1, 1);

            Assert.AreEqual(2, resultado);
        }
    }
}
