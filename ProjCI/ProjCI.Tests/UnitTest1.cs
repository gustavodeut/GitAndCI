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
        public void Soma()
        {
            HomeController controller = new HomeController();

            int resultado = controller.Soma(1, 1);

            Assert.AreEqual(2, resultado);
        }

        [TestMethod]
        public void Subtrai()
        {
            HomeController controller = new HomeController();

            int resultado = controller.Subtrai(1, 1);

            Assert.AreEqual(1, resultado);
        }
    }
}
