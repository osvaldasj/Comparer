using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;
using System.Configuration;

namespace WEB.ComparisonEngine
{
    public class CompareShops
    {
        private string infoToShow;
        private string first;
        private string second;
        private string third;
        private float fullCheckPrice = 0;

        public IWritable write { get; set; }
        public CompareShops(IWritable writeX)
        {
            this.write = writeX;
        }

        //class which compares current check product list with one of the databases lists
        public string CompareResults(List<FromFileToStruct.Product> currentCheck)
        {
            infoToShow = "";

            List<FromFileToStruct.Product> fullDatabase = new List<FromFileToStruct.Product>();

            string list = "";

            List<Product> fullData;
            using (var db = new ComparerModel())
            {
                    fullData = db.Products.ToList();
            }

            var maxima = from x in fullData where x.Shop == "maxima" && x.Accept == true select x;
            var rimi = from x in fullData where x.Shop == "rimi" && x.Accept == true select x;

            float moneyDifference = 0;

                if (currentCheck[0].shop == "maxima")
                {
                    moneyDifference = InfoCollector(1, currentCheck, rimi);
                }
                else if (currentCheck[0].shop == "rimi")
                {
                    moneyDifference = InfoCollector(2, currentCheck, rimi);
            }
                else
                {
                    first = "Shop was not recognized";
                }
                
                third = write.WriteLast(moneyDifference, infoToShow);
                
            return first + second + third;
        }

        

        private float InfoCollector(int which, List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList)
        {
            first = write.WriteFirst(which, infoToShow);
            float moneyDifference = 0;
            moneyDifference = EvaluateTwoChecks(currentCheck, otherShopList);
            return moneyDifference;
        }

        public float EvaluateTwoChecks(List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList)
        {
            int neededValue = 60;
            int currentValue;
            float moneyDifference = 0;
            bool wasFound = false;
            try
            {
                foreach (FromFileToStruct.Product curr in currentCheck)
                {
                    foreach (Product otherShop in otherShopList)
                    {
                        currentValue = Compare(curr.name, otherShop.Name);
                        if (currentValue >= neededValue)
                        {
                            moneyDifference += (curr.price - otherShop.Price);
                            second += write.Write(curr.name, (curr.price - otherShop.Price), infoToShow);
                            wasFound = true;
                            fullCheckPrice += curr.price;
                        }
                    }
                    if (!wasFound)
                    {
                        UpdateDababase.RequestForDatabase(curr);
                        second += Unrecognized(curr.name);
                    }
                    wasFound = false;
                }
            }
            catch
            {
                //throw new Exception("Database was empty");
            }
            UpdateDababase.CustomerSpentUpdate(fullCheckPrice);
            return moneyDifference;
        }
        public string Unrecognized(string name)
        {
            string addition = "Preke pavadinimu: " + name + " nebuvo rasta duomenu bazeje$";
            return addition;
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
 