using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.ComparisonEngine
{
    public class WriteToFile
    {
        enum ShopNames
        {
            Unrecognized, Maxima, Rimi
        };
        public string Write(int shop, string infoToShow)
        {
            infoToShow = "Pirkdami parduotuveje " + Enum.GetName(typeof(ShopNames), shop) + " jus: \n";
            return infoToShow;
        }

        public string Write(string name, string infoFile, float price, string infoToShow)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                infoToShow = infoToShow +  "Pirkdami \"" + name + "\" jus PERMOKEJOTE: " + price + " Eur\n";
            else
                infoToShow = infoToShow + "Pirkdami \"" + name + "\" jus SUTAUPETE: " + -price + " Eur\n";
            return infoToShow;
        }

        public string Write<T>(T infoFile, float price, string infoToShow)
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