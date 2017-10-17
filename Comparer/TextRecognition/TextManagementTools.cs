using System;

namespace Comparer.TextRecognition
{
    public static class TextManagementTools
    {
        // Add new line symbol at the end of string
        public static string AddNewLine(this String str)
        {
            return str + "\n";
        }

        // Make all letters to lowercase
        public static string Standartise(this String str)
        {
            return str.ToLower();
        }
    }
}
