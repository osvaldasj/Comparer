using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer.CompareEngine
{
    public class WriteToFile : IWritable
    {
        enum shopNames
        {
            Unrecognized, Maxima, Rimi
        };
        public string Write(string currDirecPath, int shop)
        {
            string infoFile = currDirecPath + "\\InfoToBeShown.txt";
            System.IO.File.WriteAllText(infoFile, "Pirkdami parduotuveje " + Enum.GetName(typeof(shopNames), shop) + " jus: \n");
            return infoFile;
        }

        public void Write(string name, string infoFile, float price)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                System.IO.File.AppendAllText(infoFile, "Pirkdami \"" + name + "\" jus PERMOKEJOTE: " + price + " Eur\n");
            else
                System.IO.File.AppendAllText(infoFile, "Pirkdami \"" + name + "\" jus SUTAUPETE: " + -price + " Eur\n");
        }

        public void Write<T>(T infoFile, float price)
        {
            price = float.Parse(String.Format("{0:0.00}", price));
            if (price >= 0)
                System.IO.File.AppendAllText(infoFile.ToString(), "Is viso PERMOKEJOTE: " + price + " Eur");
            else
                System.IO.File.AppendAllText(infoFile.ToString(), "Is viso SUTAUPETE: " + -price + " Eur");
        }
    }
}
