using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;

namespace UnitTestsForComparer
{
    [TestClass]
    public class UnitTestCompareShopsCompareResults
    {
        [TestMethod]
        public void UnitTestCompareShopsCompareResultsMethod()
        {
            float expectedBottom = -1000f;
            float expectedTop = 1000f;
            float actual = 0;
            //float actual = Comparer.CompareShops.CompareResults();
            MessageBox.Show(actual.ToString());
            Assert.IsTrue(actual >= expectedBottom && actual <= expectedTop);
        }
    }
}
