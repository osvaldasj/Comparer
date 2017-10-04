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
        public static float CompareResults()
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

            if (currentCheck[0].shop == "maxima")
            {
                for (int i = 0; i <= currentCheck.Count - 1; i++)
                {
                    for (int j = 0; j <= rimi.Count - 1; j++)
                    {
                        currentValue = Compare(currentCheck[i].name, rimi[j].name);
                        if (currentValue >= neededValue)
                        {
                            moneyDifference += (currentCheck[i].price - rimi[j].price);
                            MessageBox.Show(i.ToString() + " " + currentCheck[i].price.ToString() + "    "+ j.ToString()+" " + rimi[j].price.ToString());
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
            else if (currentCheck[0].shop == "rimi")
            {
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
                MessageBox.Show("unrecognized shop");
            }

            return moneyDifference;
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
    }
}
