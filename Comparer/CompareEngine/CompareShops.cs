using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Comparer.CompareEngine;

namespace Comparer
{
    public class CompareShops : IComparer
    {
        private string infoFile;
        public string infofile
        {
            get { return infoFile; }
            set { infoFile = value; }
        }

        //get path to database directory
        private string currentDirectory;// = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\Comparer\bin\Debug");
        public string CurrentDirectory
        {
            get { return currentDirectory; }
            set { currentDirectory = value; }
        }
        //class which compares current check product list with one of the databases lists
        public string CompareResults()
        {

            CurrentDirectory = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\Comparer\bin\Debug");
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();
            currentCheck = FromFileToStruct.MakeProductList3(currentDirectory + "\\TempResult.txt");

            List<FromFileToStruct.Product> fullDatabase = new List<FromFileToStruct.Product>();
            fullDatabase = FromFileToStruct.MakeProductList2(currentDirectory + "\\FullDatabase.txt");

            var maxima = from x in fullDatabase where x.shop == "maxima" select x;
            var rimi = from x in fullDatabase where x.shop == "rimi" select x;

            WriteToFile write = new WriteToFile();
            float moneyDifference = 0;



            if (currentCheck[0].shop == "maxima")
            {
                moneyDifference = InfoCollector(1, currentCheck, rimi, write);
            }
            else if (currentCheck[0].shop == "rimi")
            {
                moneyDifference = InfoCollector(2, currentCheck, rimi, write);
            }
            else
            {
                infofile = "";
                MessageBox.Show("unrecognized shop");
            }

            write.Write(infofile, moneyDifference);

            return infofile;
        }

        private float InfoCollector(int which, List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList, WriteToFile write)
        {
            infofile = write.Write(currentDirectory, which);
            float moneyDifference = 0;
            moneyDifference = EvaluateTwoChecks(currentCheck, otherShopList, write, infofile);
            return moneyDifference;
        }

        public float EvaluateTwoChecks(List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList, WriteToFile write, string info)
        {
            int neededValue = 80;
            int currentValue;
            float moneyDifference = 0;
            bool wasFound = false;

            for (int i = 0; i <= currentCheck.Count - 1; i++)
            {
                foreach(FromFileToStruct.Product otherShop in otherShopList)
                {
                    currentValue = Compare(currentCheck[i].name, otherShop.name);
                    if (currentValue >= neededValue)
                    {
                        moneyDifference += (currentCheck[i].price - otherShop.price);
                        write.Write(currentCheck[i].name, info, (currentCheck[i].price - otherShop.price));
                        wasFound = true;
                    }
                }
                if (!wasFound)
                {
                    UpdateDatabase.RequestForDatabase(currentCheck[i]);  //to be made in the future
                    //MessageBox.Show("unrecognized product: " + currentCheck[i].name);
                }
                wasFound = false;
            }

            return moneyDifference;
        }

        //compares two strings how close they are the same and returns the value between 0 and 100 meaning %
        public int Compare(object x, object y)
        {
            int counter = 0;
            string A = (string)x;
            string B = (string)y;
            int lenA = A.Length, lenB = B.Length; ;
            int lenMin, lenMax;
            if (lenA > lenB)
            {
                lenMin = lenB;
                lenMax = lenA;
            }
            else
            {
                lenMin = lenA;
                lenMax = lenB;
            }
            for (int i = 0; i < lenMin; i++)
            {
                if (A[i] == B[i])
                    counter++;
            }
            if (lenMax != 0)
                return counter * 100 / lenMax;
            else
                return 0;
        }
    }
}
