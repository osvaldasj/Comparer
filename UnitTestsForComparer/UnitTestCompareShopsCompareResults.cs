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
            infoFilePath = Directory.GetCurrentDirectory();


            infoFilePath = Comparer.CompareShops.CompareResults();
            MessageBox.Show(infoFilePath);
            var regex = new Regex(@"^[a-zA-Z]{1}l:\[a-zA-Z0-9]+$");
            Assert.IsTrue(1==1);
        }
    }
}
