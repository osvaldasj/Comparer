using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.OCR;
using Emgu.CV.CvEnum;

namespace ShoppingEngine
{
    public partial class ShoppingEngine : Form
    {
        private static Emgu.CV.OCR.Tesseract tess = new Emgu.CV.OCR.Tesseract("C:\\Users\\llluu\\Downloads\\f", "lit", OcrEngineMode.Default);

        public ShoppingEngine()
        {
            InitializeComponent();
        }

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            
            dlg.Title = "Open Image";
            dlg.Filter = "any files (*.*')|*.*";

            if (dlg.ShowDialog()==DialogResult.OK)
            {
                mainPictureBox.Image = new Bitmap(dlg.FileName);
            }

            dlg.Dispose();
        }

        int HowCloseAreSame(string A, string B)
        {
            int counter = 0;
            int lenA = A.Length, lenB = B.Length;
            int lenMin, lenMax;
            if (lenA > lenB)
            {
                lenMin = lenB;
                lenMax = lenA;
            }
            else
            {
                lenMin = lenA;
                lenMax = lenB;
            }
            for(int i = 0; i<lenMin; i++)
            {
                if (A[i] == B[i])
                    counter++;
            }
            return counter*100/lenMax;
        }

       
        private void TestButton_Click(object sender, EventArgs e)
        {
            //Image<Bgr, byte> img = new Image<Bgr, byte>("C:\\Users\\llluu\\Desktop\\test.jpg");
            OpenFileDialog d = new OpenFileDialog();

            if (d.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, byte> img = new Image<Bgr, byte>(d.FileName);
                //Image<Bgr, byte> resizedImage = img.Resize(100, 200, Emgu.CV.CvEnum.Inter.Linear);
                Bitmap imgRes = new Bitmap(d.FileName);
                Bitmap newImg = new Bitmap(imgRes, new Size(1200, 700));
                mainPictureBox.Image = newImg;

                
                tess.SetImage(img);
                tess.Recognize();
            }

            MessageBox.Show(tess.GetUTF8Text());

        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            int x;
            x = HowCloseAreSame("vienas astuoni penki", "vienas astuoni penki");
            MessageBox.Show("Strings are " + x + "% the same");
        }
    }
}
