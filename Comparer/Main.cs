using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparer
{
    public partial class Main : Form
    {
        public string inputFile;
        public string outputFile;
        public string databaseFile;
        bool IMG = false;
        bool text = false;
        bool DB = false;
        
        public Main()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            inputFile = Navigator.SelectInputFile();
            Image x;
            try
            {
                x = Image.FromFile(inputFile);
                x = resizeImage(x, new Size(740, 692));
                mainPictureBox.Image = x;
                IMG = true;
                if (IMG && text)
                    recognizeButton.Enabled = true;
                imageCheck.Checked = true;
            }
            catch
            {

            }
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void outButton_Click(object sender, EventArgs e)
        {
                outputFile = Navigator.SelectOutputFile();
            if (outputFile == "-1")
            {
                
            }
            else
            {
                text = true;
                if (IMG && text)
                    recognizeButton.Enabled = true;
                if (DB && text)
                    compareButton.Enabled = true;
                outputCheck.Checked = true;
            }
        }

        private void recognizeButton_Click(object sender, EventArgs e)
        {
            string text = ImageRecognition.ExtractText(inputFile);
            var textManager = new TextManager();
            text = textManager.PrepareText(text);
            mainLabel.Text = text;
            Program.ResultWriter(text, outputFile);
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {   
            mainPictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            mainPictureBox.Refresh();
        }

        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            mainPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            mainPictureBox.Refresh();
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            AddToDatabase.CompareResults(outputFile, databaseFile);
        }

        private void databaseButton_Click(object sender, EventArgs e)
        {
            databaseFile = Navigator.SelectInputFile();
            
            if (outputFile == "-1")
            {

            }
            else
            {
                DB = true;
                if (DB && text)
                    compareButton.Enabled = true;
                databaseCheck.Checked = true;
            }
        }
    }
}
