using System;
using System.IO;

namespace Comparer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            ResultWriter(ImageRecognition.ExtractText(Navigator.SelectInputFile()), Navigator.SelectOutputFile());
        }

        public static void ResultWriter(string text, string filePath)
        {
            TextWriter textWriter = new StreamWriter(filePath);
            textWriter.Write(text);
            textWriter.Close();
        }
    }
}
