using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

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
            int actual = Comparer.CompareShops.Compare("abc", "def");
            Assert.IsTrue(actual >= expectedBottom && actual <= expectedTop);
        }

    }
}
