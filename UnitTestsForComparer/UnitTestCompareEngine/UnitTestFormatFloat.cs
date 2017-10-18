using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Comparer;

namespace UnitTestsForComparer.UnitTestCompareEngine
{
    [TestClass]
    public class UnitTestFormatFloat
    {
        [TestMethod]
        public void UnitTestFormatFloatMethod()
        {
            float expected = 10.6f;
            float actual = FromFileToStruct.formatFloat(10.598f);
            Assert.AreEqual(expected, actual);
        }
    }
}
