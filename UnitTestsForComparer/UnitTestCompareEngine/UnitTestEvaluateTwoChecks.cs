using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using Comparer;
using Comparer.CompareEngine;
using System.Linq;

namespace UnitTestsForComparer.UnitTestCompareEngine
{
    [TestClass]
    public class UnitTestEvaluateTwoChecks
    {
        [TestMethod]
        public void UnitTestEvaluateTwoChecksMethod()
        {
            string currentDirectory = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\Comparer\bin\Debug");
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();

            List<FromFileToStruct.Product> fullDatabase = new List<FromFileToStruct.Product>();
            fullDatabase = FromFileToStruct.MakeProductList2(currentDirectory + "\\FullDatabase.txt");

            var maxima = from a in fullDatabase where a.shop == "maxima" select a;
            var rimi = from a in fullDatabase where a.shop == "rimi" select a;

            currentCheck = FromFileToStruct.MakeProductList(currentDirectory + "\\TempResult.txt");

            WriteToFile write = new WriteToFile();
            string infoFile = write.Write(currentDirectory, 1);

            float expectedMin = -1000;
            float expectedMax = 1000;
            Comparer.CompareShops x = new Comparer.CompareShops();
            float actual = x.EvaluateTwoChecks(currentCheck, maxima, write, infoFile);
            Assert.IsTrue(actual >= expectedMin && actual <= expectedMax);
        }
    }
}
