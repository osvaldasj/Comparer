using Comparer.TextRecognition;
using System;
using System.Globalization;
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
            // works for older checks: ((([a-z]){2,}[ ]?)+\n+\w.*\s\d{1,3}[ ]?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))|(\w.*\s\d{1,3}[ ]?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))
            var regex = new Regex(@"((.*\s\d{1,3}[ ]?)([\n]?.*\s\d{1,3}[ ]?)?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))");
            var matches = regex.Matches(text);

            var regex2 = new Regex(@"((.*\s\d{1,3}[ ]?)([\n].*\s\d{1,3}[ ]?)?(\d{1,2})?[ ]?(\d)?[ ]?[,][ ]?(\d{1,2})?[ ]?(\d)?(a|c))");
            var regex3 = new Regex(Regex.Escape("\n"));

            foreach (var match in matches)
            {
                if (regex2.IsMatch(match.ToString()))
                {

                    var temp = regex3.Replace(match.ToString(), " ", 1);

                    result = result + temp + "\n";
                }
                else
                {
                    result = result + match + "\n";
                }

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
                if (DateTime.TryParseExact(m.Value + " 0:00:00 AM", "yyyy-MM-dd h:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    return dateTime.ToString("MM/dd/yy");
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