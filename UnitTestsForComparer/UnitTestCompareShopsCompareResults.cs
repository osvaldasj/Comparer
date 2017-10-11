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
            ResultWriter(infoFilePath, Directory.GetCurrentDirectory() + "\\TempResult.txt");
            var regex = new Regex("^[a-zA-Z0-9]:(\\[a-zA-Z0-9]+)+.txt$");
            Assert.IsFalse(regex.IsMatch(infoFilePath));
        }
        public static void ResultWriter(string text, string filePath)
        {
            TextWriter textWriter = new StreamWriter(filePath);
            textWriter.Write(text);
            textWriter.Close();
        }
    }
}
