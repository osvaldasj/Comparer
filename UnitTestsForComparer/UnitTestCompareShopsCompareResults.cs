using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace UnitTestsForComparer
{
    [TestClass]
    public class UnitTestCompareShopsCompareResults
    {
        [TestMethod]
        public void UnitTestCompareShopsCompareResultsMethod()
        {
            string infoFilePath;
            infoFilePath = Comparer.CompareShops.CompareResults();
            var regex = new Regex("^[a-zA-Z0-9]:(\\[a-zA-Z0-9]+)+.txt$");
            Assert.IsFalse(regex.IsMatch(infoFilePath));
        }
    }
}
