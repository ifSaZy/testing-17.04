using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace Test_Rasschetov
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Сумма больше 25, 1 корень = 27", Rasschet.CalculateSum(25, 2));
            Assert.AreEqual("Разность меньше 25, 1 корень = 23", Rasschet.CalculateRaz(25, 2));
        }
    }
}
