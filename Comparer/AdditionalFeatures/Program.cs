using System;
using System.IO;
using System.Windows.Forms;

namespace Comparer
{
    public static class Program
    {

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void ResultWriter(string text, string filePath)
        {
            TextWriter textWriter = new StreamWriter(filePath);
            textWriter.Write(text);
            textWriter.Close();
        }
    }
}
