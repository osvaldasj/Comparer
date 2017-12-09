using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.ComparisonEngine
{
    public class WriteToFile : IWritable
    {
        enum ShopNames
        {
            Unrecognized, Maxima, Rimi
        };
        public string WriteFirst(int shop, string infoToShow)
        {
            infoToShow = "Pirkdami parduotuveje " + Enum.GetName(typeof(ShopNames), shop) + " jus:$";
            return infoToShow;
        }

        public string Write(string name, float price, string infoToShow)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                infoToShow = infoToShow +  "Pirkdami " + name + " jus PERMOKEJOTE: " + price + " Eur$";
            else
                infoToShow = infoToShow + "Pirkdami " + name + " jus SUTAUPETE: " + -price + " Eur$";
            return infoToShow;
        }

        public string WriteLast(float price, string infoToShow)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                infoToShow = infoToShow + "Is viso PERMOKEJOTE: " + price + " Eur";
            else
                infoToShow = infoToShow +  "Is viso SUTAUPETE: " + -price + " Eur";
            return infoToShow;
        }
    }
}