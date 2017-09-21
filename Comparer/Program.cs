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
