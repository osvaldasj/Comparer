using System;

namespace Comparer.TextRecognition
{
    public static class AdvancedTextManagementTools : TextManagementTools
    {
        // Make all letters to uppercase
        public static string Uppercase(this String str)
        {
            return str.ToUpper();
        }

        // Fix the string
        public static string Fix(this String str, char wrong, char right)
        {
            return str.Replace(wrong, right); // example: Fix("pum", 'u', 'v'); will return "pvm"
        }
    }
}
