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