using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using Comparer;
using Comparer.CompareEngine;

namespace UnitTestsForComparer.UnitTestCompareEngine
{
    [TestClass]
    public class UnitTestEvaluateTwoChecks
    {
        [TestMethod]
        public void UnitTestEvaluateTwoChecksMethod()
        {
            string currentDirectory = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\Comparer\bin\Debug");
            List<FromFileToStruct.Product> maxima = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> rimi = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();
            
            maxima = FromFileToStruct.MakeProductList(currentDirectory + "\\MaximaDatabase.txt");
            rimi = FromFileToStruct.MakeProductList(currentDirectory + "\\RimiDatabase.txt");
            currentCheck = FromFileToStruct.MakeProductList(currentDirectory + "\\TempResult.txt");

            WriteToFile write = new WriteToFile();
            string infoFile = write.Write(currentDirectory, 1);

            float expectedMin = -1000;
            float expectedMax = 1000;
            Comparer.CompareShops x = new Comparer.CompareShops();
            float actual = x.EvaluateTwoChecks(currentCheck, maxima, write , infoFile);
            Assert.IsTrue(actual >= expectedMin && actual <= expectedMax);
        }
    }
}
