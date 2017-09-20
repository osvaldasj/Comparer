using System.IO;
using System.Windows.Forms;

namespace Comparer
{
    public static class Navigator
    {
        public static string SelectInputFile()
        {
            OpenFileDialog fileopener = new OpenFileDialog();

            if (fileopener.ShowDialog() == DialogResult.OK)
            {
                return Path.GetDirectoryName(fileopener.FileName) + @"\" + Path.GetFileName(fileopener.FileName);
            }

            return "-1";
        }

        public static string SelectOutputFile()
        {
            SaveFileDialog filesaver = new SaveFileDialog();

            if (filesaver.ShowDialog() == DialogResult.OK)
            {
                return Path.GetDirectoryName(filesaver.FileName) + @"\" + Path.GetFileName(filesaver.FileName);
            }

            return "-1";
        }


    }
}
