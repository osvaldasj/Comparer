using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Comparer
{
    public class CompareShops
    {
        public static void CompareResults(string inputFile, string databaseFile)
        {
            //create rimi, maxima and currentCheck databases product lists from files
            List<FromFileToStruct.Product> maxima = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> rimi = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();
            maxima = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\MaximaDatabase.txt");
            rimi = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\RimiDatabase.txt");
            currentCheck = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\TempResult.txt");

            int neededValue = 90;
            int currentValue;

            if (currentCheck[0].name == "maxima")
            {
                for (int i = 0; i <= currentCheck.Count - 1; i++)
                {
                    for (int j = 0; j <= rimi.Count - 1; j++)
                    {
                        currentValue = Compare(currentCheck[i].name, rimi[j].name);
                        if (currentValue >= neededValue)
                        {

                        }
                        else
                        {

                        }
                    }
                }
            }
            else if (currentCheck[0].name == "rimi")
            {

            }
            else
            {

            }


        }



        public static int Compare(string A, string B)
        {
            int counter = 0;
            int lenA = A.Length, lenB = B.Length;
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
            return counter * 100 / lenMax;
        }

        public static string ShowLists()
        {
            List<FromFileToStruct.Product> maxima = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> rimi = new List<FromFileToStruct.Product>();
            maxima = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\MaximaDatabase.txt");
            rimi = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\RimiDatabase.txt");

            for (int i = 0; i <= maxima.Count - 1; i++)
            {
                //MessageBox.Show(maxima.Count.ToString());
                MessageBox.Show(rimi[i].shop + "  " + rimi[i].date + " -> " + rimi[i].name + " for " + rimi[i].price);
                //MessageBox.Show(maxima[i].shop + "  " + maxima[i].date + " -> " + maxima[i].name + " for " + maxima[i].price);
            }
            return (rimi[0].shop + "  " + rimi[0].date + " -> " + rimi[0].name + " for " + rimi[0].price);
        }
    }
}
