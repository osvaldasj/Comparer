using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace UnitTestsForComparer.UnitTestOtherFeatures
{
    [TestClass]
    public class UnitTestNavigatorClass
    {
        [TestMethod]
        public void UnitTestNavigatorClassMethod()
        {
            int expected = -1;
            string infoFilePath;
            infoFilePath = Comparer.Navigator.SelectInputFile();
            var regex = new Regex(@"^[a-zA-Z0-9]:(\\[a-zA-Z0-9_]+)+.jpg$");
            Assert.IsTrue(regex.IsMatch(infoFilePath));
            //Assert.IsTrue(infoFilePath == expected.ToString());
        }
    }
}
