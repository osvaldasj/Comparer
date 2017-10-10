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
        //class which compares current check product list with one of the databases lists
        public static string CompareResults()
        {
            //create rimi, maxima and currentCheck databases product lists from files
            List<FromFileToStruct.Product> maxima = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> rimi = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();
            maxima = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\MaximaDatabase.txt");
            rimi = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\RimiDatabase.txt");
            currentCheck = FromFileToStruct.MakeProductList(Directory.GetCurrentDirectory() + "\\TempResult.txt");

            int neededValue = 85;
            int currentValue;
            float moneyDifference = 0;
            int counter = 0;
            string infoFile;

            if (currentCheck[0].shop == "maxima")
            {
                infoFile = createInfoFile(1);
                for (int i = 0; i <= currentCheck.Count - 1; i++)
                {
                    for (int j = 0; j <= rimi.Count - 1; j++)
                    {
                        currentValue = Compare(currentCheck[i].name, rimi[j].name);
                        if (currentValue >= neededValue)
                        {
                            moneyDifference += (currentCheck[i].price - rimi[j].price);
                            AddForInfo(currentCheck[i].name, (currentCheck[i].price - rimi[j].price), infoFile);
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    if (counter == currentCheck.Count)
                    {
                        //RequestForDatabase(currentCheck[i]);  //to be made in the future
                        MessageBox.Show("unrecognized product");
                    }
                    counter = 0;
                }
            }
            else if (currentCheck[0].shop == "rimi")
            {
                infoFile = createInfoFile(2);
                for (int i = 0; i <= currentCheck.Count - 1; i++)
                {
                    for (int j = 0; j <= maxima.Count - 1; j++)
                    {
                        currentValue = Compare(currentCheck[i].name, maxima[j].name);
                        if (currentValue >= neededValue)
                        {
                            moneyDifference += (currentCheck[i].price - maxima[j].price);
                        }
                        else
                        {
                            counter++;
                        }
                    }
                    if (counter == currentCheck.Count)
                    {
                        //RequestForDatabase(currentCheck[i]);
                        MessageBox.Show("unrecognized product");
                    }
                    counter = 0;
                }
            }
            else
            {
                infoFile = "";
                MessageBox.Show("unrecognized shop");
            }

            AddPriceComparisonForInfo(moneyDifference,  infoFile);

            return infoFile;
        }


        //compares two strings how close they are the same and returns the value between 0 and 100 meaning %
        private static int Compare(string A, string B)
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
            if (lenMax != 0)
                return counter * 100 / lenMax;
            else
                return 0;
        }
        
        private static string createInfoFile(int shop)// 1 for maxima, 2 for rimi
        {
            string infoFile = Directory.GetCurrentDirectory() + "\\InfoToBeShown.txt";
            if(shop == 1)
                System.IO.File.WriteAllText(infoFile, "Pirkdamas maximoje jus sutaupete: \n");
            else
                System.IO.File.WriteAllText(infoFile, "Pirkdamas rimi jus sutaupete: \n");
            return infoFile;
        }

        private static void AddForInfo(string name, float price, string infoFile)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price>=0)
                System.IO.File.AppendAllText(infoFile, "Pirkdami \"" + name + "\" jus PERMOKEJOTE: " + price + " Eur\n");
            else
                System.IO.File.AppendAllText(infoFile, "Pirkdami \"" + name + "\" jus SUTAUPETE: " + -price + " Eur\n");
        }

        private static void AddPriceComparisonForInfo(float price, string infoFile)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                System.IO.File.AppendAllText(infoFile, "Is viso PERMOKEJOTE: " + price + " Eur");
            else
                System.IO.File.AppendAllText(infoFile, "Is viso SUTAUPETE: " + -price + " Eur");
        }
    }
}
