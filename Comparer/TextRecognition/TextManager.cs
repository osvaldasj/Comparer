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
        private enum _shop : short
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
                return _shop.maxima;
            }
            else if (text.Contains("rimi"))
            {
                return _shop.maxima;
            }
            else
            {
                return _shop.unrecunrecognized;
            }
        }

        // Use correct method depending on shop name
        private string GetProducts(string text, _shop shopName)
        {
            switch (shopName)
            {
                case _shop.maxima:
                    return GetProductsMaxima(text);
                case _shop.rimi:
                    return GetProductsRimi(text);
                case _shop.unrecunrecognized:
                default:
                    return "Unrecunrecognized shop";
            }
        }

        // For future expansion
        private string GetProductsRimi(string text)
        {
            throw new NotImplementedException();
        }

        private string GetProductsMaxima(string text)
        {
            string result = "";
            string result2 = "";

            // Delete everytihng up to word "kvitas"
            text = text.Substring(text.IndexOf("kvitas"));

            // Delete everything up to first product
            text = text.Substring(text.IndexOf('\n') + 1);

            // Delete everything after the last prouct
            try
            {
                text = text.Remove(text.IndexOf("pvm") - 3);
                text = text + "\n";
            }
            catch { }

            try
            {
                text = text.Remove(text.IndexOf("pum") - 3);
                text = text + "\n";
            }
            catch { }

            try
            {
                text = text.Remove(text.IndexOf("| a-21") - 3);
                text = text + "\n";
            }
            catch { }

            // Remove all "\n"
            var lines = text.Split('\n')
            .Where(line => !string.IsNullOrWhiteSpace(line));

            result = string.Join(" ", lines);
            result = result + " ";

            // Delete letters after prices and move every product to new line
            result = result.Replace(" a ", "\n");
            result = result.Replace(" c ", "\n");

            using (StringReader reader = new StringReader(result))
            {
                string line = string.Empty;
                do
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        // Remove whitespaces between numbers of prices   
                        for (int i = 2; i < 5; i++)
                        {
                            if (line[line.Length - i] == ' ')
                            {
                                line = RemoveAt(line, line.Length - i);
                            }
                        }
                        result2 = result2 + line;
                        result2 = result.AddNewLine();
                    }
                } while (line != null);
            }
            result2 = result2.Remove(result2.LastIndexOf("\n") - 1);

            return result2;
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
            _products = GetProducts(shopName: (_shop)shopName, text: text);

            // Construct and return final result
            return shopName.ToString() + "\n" + _date + "\n" + _products;
        }
    }
}