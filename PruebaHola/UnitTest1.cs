using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PruebaHola;
using HolaMundo;

namespace PruebaHola
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hola Mundo", Program.CreateMessage());
        }
    }
}
