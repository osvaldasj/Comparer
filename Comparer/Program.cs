using System;
using System.IO;

namespace Comparer
{
    static class Program
    {
        // Solve dll problem
        static Program()
        {
            var httpasm = typeof(System.Net.Http.HttpClient).Assembly;

            AppDomain.CurrentDomain.AssemblyResolve += (s, a) =>
            {
                var requestedAssembly = new System.Reflection.AssemblyName(a.Name);
                if (requestedAssembly.Name != "System.Net.Http")
                    return null;

                return httpasm;
            };
        }

        [STAThread]
        static void Main()
        {
            string inputFile = Navigator.SelectInputFile();
            string outputFile = Navigator.SelectOutputFile();
            string text = ImageRecognition.ExtractText(inputFile);
            var textManager = new TextManager();

            text = textManager.PrepareText(text);
            ResultWriter(text, outputFile);
        }

        public static void ResultWriter(string text, string filePath)
        {
            TextWriter textWriter = new StreamWriter(filePath);
            textWriter.Write(text);
            //MessageBox.Show(text);
            textWriter.Close();
        }
    }
}
