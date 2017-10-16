using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using Comparer;

namespace UnitTestsForComparer
{
    [TestClass]
    public class UnitTestCompareShopsCompare
    {
        [TestMethod]
        public void UnitTestCompareShopsCompareMethod()
        {
            int expectedBottom = 0;
            int expectedTop = 100;
            var x = new CompareShops();
            int actual = x.Compare("abc", "def");
            Assert.IsTrue(actual >= expectedBottom && actual <= expectedTop);
        }

    }
}
