using System;
using System.Text.RegularExpressions;

namespace Comparer.TextRecognition
{
    public static class TextManagementTools
    {
        // Add new line symbol at the end of string
        public static string AddNewLine(this String str)
        {
            return str + "\n";
        }

        // Make all letters to lowercase and leave only one whitespace between
        public static string Standartise(this String str)
        {
            str = str.ToLower();

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            str = regex.Replace(str, " ");

            return str;
        }

        // Remove spaces between numbers
        public static string RemoveSpacesBetweenNumbers(this String str)
        {
            str = Regex.Replace(str, @"\d[ ]\d", @"\d\d");
            str = Regex.Replace(str, @"\d[ ][,]\d", @"\d\d");
            str = Regex.Replace(str, @"\d[,][ ]\d", @"\d\d");
            return str;
        }

    }
}
