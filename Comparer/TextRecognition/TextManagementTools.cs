using System;
using System.Text.RegularExpressions;

delegate string TextChanger(string text);
namespace Comparer.TextRecognition

{
    public static class TextManagementTools
    {
        // Delegates usage
        public static string RemoveSpaceInMiddle(string text)
        {
            return Regex.Replace(text, @"\d[ ][,]\d", @"\d\d");
        }

        public static string RemoveSpaceInEnd(string text)
        {
            return Regex.Replace(text, @"\d[,][ ]\d", @"\d\d");
        }

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
            //Anonymous method
            TextChanger chg = delegate (string text)
            {
                return Regex.Replace(text, @"\d[ ]\d", @"\d\d");
            };

            TextChanger chg2 = new TextChanger(RemoveSpaceInMiddle);
            TextChanger chg3 = new TextChanger(RemoveSpaceInEnd);

            chg += chg2;
            chg += chg3;

            return chg(str);
        }

    }
}
