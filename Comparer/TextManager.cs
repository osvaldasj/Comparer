﻿using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Comparer
{
    public class TextManager
    {
        private string _shopName;
        private string _date;
        private string _products;

        private string Standartise(string text)
        {
            return text.ToLower();
        }

        private string DetectShopName(string text)
        {
            if (text.Contains("maxima"))
            {
                return "maxima";
            }
            else if (text.Contains("rimi"))
            {
                return "rimi";
            }
            else
            {
                return "unrecognized";
            }
        }

        private string ExtractProducts(string text, string shopName)
        {
            string result = "";
            string result2 = "";

            // For now works only with maxima
            if (shopName == "maxima")
            {
                // Delete everytihng up to word "kvitas"
                text = text.Substring(text.IndexOf("kvitas"));

                // Delete everything up to first product
                text = text.Substring(text.IndexOf('\n') + 1);

                // Delete everything after the last prouct
                // For 2017 versions of maxima checks
                try
                {
                    text = text.Remove(text.IndexOf("pvm") - 3);
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
                using (StringReader reader = new StringReader(text))
                {
                    string line = string.Empty;
                    do
                    {
                        line = reader.ReadLine();
                        if (line != null)
                        {
                            result = result + line + " ";
                        }
                    } while (line != null);
                }

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
                            result2 = result2 + line + "\n";
                        }
                    } while (line != null);
                }
                result2 = result2.Remove(result2.LastIndexOf("\n") - 1);
            }
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
        private string RemoveAt(string text, int index)
        {
            return text.Remove(index, 1);
        }

        public string PrepareText(string text)
        {
            // Make all letters lowercase
            text = Standartise(text);

            // Extract shop name from string
            _shopName = DetectShopName(text);

            // Extract date from string
            _date = GetDate(text);

            // Extract list of products acording to shop name
            _products = ExtractProducts(text, _shopName);

            // Construct and return final result
            return _shopName + "\n" + _date + "\n" + _products;
        }
    }
}
