using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using Comparer;

namespace UnitTestsForComparer
{
    [TestClass]
    public class UnitTestCompareShopsCompareResults
    {
        [TestMethod]
        public void UnitTestCompareShopsCompareResultsMethod()
        {
            string infoFilePath;
            var x = new CompareShops();
            infoFilePath = x.CompareResults();
            var regex = new Regex(@"^[a-zA-Z0-9]:(\\[a-zA-Z0-9]+)+.txt$");
            Assert.IsTrue(regex.IsMatch(infoFilePath));
        }
    }
}
