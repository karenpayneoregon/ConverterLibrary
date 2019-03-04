using System;
using ConverterLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class DecimalTest1
    {
        [TestMethod]
        public void AllElementsAreDecimalSuccess()
        {
            string[] stringArray = { "-2.5", "4.5", "6.666", "8" };
            Assert.IsTrue(stringArray.AllDecimal());
        }
        [TestMethod]
        public void AllElementsAreDecimalFailure()
        {
            string[] stringArray = { "-2.5", "4.5", null, "ABC" };
            Assert.IsFalse(stringArray.AllDecimal());
        }
    }
}
