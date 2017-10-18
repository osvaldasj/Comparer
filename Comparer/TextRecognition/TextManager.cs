using Comparer.TextRecognition;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Comparer
{
    public class TextManager
    {
        string text = "MA" +
            "HAX IMA LT, UAB" +
            "Savanoriu pr. 247, Vilnius, Kasa Nr. 13" +
            "PUM moketojo kodas LT230335113" +
            "Kvitas 1 / 15 #00000908" +
            "Liesa Varške OPTIMA LINIJA, 0,5 % rieb. 0,45 A" +
            " Grikiu kruopos OPTIMA LINIJA(4 x 100 g) 0,79 A" +
            "Grietine FARM MILK, 30 % rieb 0,73 A" +
            " Pienas OPTIMA LINIJA, 3,5 % 0,59 A" +
            "  Saulegražu aliejus OPTIMA LINIJA 1,27 A" +
            "  Kiaušiniai OPTIMA LINIJA(MI, rudi) 0,99 A" +
            " Pirkiniu maišelis 25mk MAXIMA(30 / 7x50 cm) 0,08 A" +
            "  | A - 21,008" +
            "PUM" +
            "0,85" +
            "Be PUM" +
            "4,05" +
            "Su PUM" +
            "4,90" +
            "Moketi" +
            "Moketa(Banko kortele)" +
            "4,90" +
            "4,90" +
            "MOKEJIMAS KORTELE" +
            "PARDAVIMAS" +
            "DOKUMENTO NR 005656:170323 143457" +
            "I KVITO NR 100596" +
            "TERMINAL ID 03189910" +
            "MERCHANT ID 0032181110" +
            "LAIKAS 2017 - 03 - 23 14:34:57" +
            "Debit MasterCard ********XXXXX4376" +
            "A0000000041010 TVR : 0000008000" +
            "TSI: E800 AIP:3900 TC: 146CD888D4C6DBE5" +
            "  DEBIT MASTERCARD" +
            "  SUMA 4, 90 EUR" +
            "  Autorizacijos Nr 242896 T: 1" +
            "PIN KODAS TEISINGAS" +
            "IŠSAUGOKITE CEKIO KOPIJA SASKAITOS" +
            "IšRAŠ0 PATIKRINIMUI" +
            "RRN: 708266988518" +
            ":" +
            "InvÑr: 1300 - 0130 - 0150 - 0014" +
            "ACIU, KAD PIRKOTE!" +
            "* Daugiau informacijos sužinokite" +
            "WWW.Maxima.lt ir telefonu 8 800 20050" +
            "Kasininkas(-é) 10457 13" +
            "LF JB 0000004A91D6 2017 - 03 - 23 14:35:09";
        private string _date;
        private string _products;

        [Flags]
        private enum Shop : short
        {
            unrecunrecognized,
            maxima,
            rimi,
        }

        // Scan string and fetch name of the shop
        private Enum DetectShopName(string text)
        {
            if (text.Contains("maxima"))
            {
                return Shop.maxima;
            }
            else if (text.Contains("rimi"))
            {
                return Shop.maxima;
            }
            else
            {
                return Shop.unrecunrecognized;
            }
        }

        // Extract products using regex
        private string GetProducts(string text)
        {
            string result = "";
            var regex = new Regex(@"((([a-z]){2,}[ ]?)+\n+\w.*\s\d{1,3}[ ]?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))|(\w.*\s\d{1,3}[ ]?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))");
            var matches = regex.Matches(text);

            foreach (var match in matches)
            {

                result = result + match + "\n";
            }

            result = result.Replace(" a\n", "\n");
            result = result.Replace(" c\n", "\n");
            if (result.EndsWith("\n"))
            {
                result = RemoveAt(result, result.Length - 1);
            }
            result = result.RemoveSpacesBetweenNumbers();

            if (result != "")
            {
                return result;
            }
            else
            {
                return "unable to detect products";
            }
        }

        // Extract date from string
        private string GetDate(string text)
        {
            var regex = new Regex(@"\b\d{4}\-\d{2}-\d{2}\b");
            foreach (Match m in regex.Matches(text))
            {
                DateTime dateTime;
                if (DateTime.TryParseExact(m.Value, "yyyy-MM-dd", null, DateTimeStyles.None, out dateTime))
                    return dateTime.ToString().Remove(dateTime.ToString().Length - 12);
            }
            return "unable to detect date";
        }

        // Remove one element from string
        private string RemoveAt(string text, int index, int amount = 1)
        {
            return text.Remove(index, amount);
        }

        public string PrepareText(string text)
        {
            // Make all letters lowercase
            text = text.Standartise();

            // Extract shop name from string
            var shopName = DetectShopName(text);

            // Extract date from string
            _date = GetDate(text);

            // Extract list of products acording to shop name
            _products = GetProducts(text: text);

            // Construct and return final result
            return shopName.ToString() + "\n" + _date + "\n" + _products;
        }
    }
}