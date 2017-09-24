﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Comparer
{
    public static class Program
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
        public static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        /*public static void MainProgram()
        {
            string inputFile = Navigator.SelectInputFile();
           string outputFile = Navigator.SelectOutputFile();
           string text = ImageRecognition.ExtractText(inputFile);
           var textManager = new TextManager();

           text = textManager.PrepareText(text);
           ResultWriter(text, outputFile);
        }*/


        public static void ResultWriter(string text, string filePath)
        {
            TextWriter textWriter = new StreamWriter(filePath);
            textWriter.Write(text);
            textWriter.Close();
        }
    }
}
