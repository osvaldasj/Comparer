using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using Comparer.AdditionalFeatures;
using System.Configuration;
using System.Data.SqlClient;

namespace Comparer
{
    public partial class Main : Form
    {
        public string inputFile;
        //public string name { get; set; }
        bool IMG = false;
        string custID;
        public float currentSpent = 0;

        public Main(string name, string value, string ID)
        {
            InitializeComponent();
            welcomeLabel.Text = "Welcome, " + name + "!";
            spentLabel.Text = value;
            custID = ID;
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
                if (IMG)
                {
                    recognizeButton.Enabled = true;
                    compareButton.Enabled = true;
                }
                imageCheck.Checked = true;
            }
            catch
            {

            }
            //something to execute from web service
            //ComparerWebService.WebServiceSoapClient client = new ComparerWebService.WebServiceSoapClient();
            //MessageBox.Show(client.HelloWorld());
        }

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private async void recognizeButton_Click(object sender, EventArgs e)
        {
            string text = ImageRecognition.ExtractText(inputFile);
            var textManager = new TextManager();
            text = textManager.PrepareText(text);
            mainLabel.Text = text;
            Program.ResultWriter(text, Directory.GetCurrentDirectory() + "\\TempResult.txt");
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

        private async void compareButton_Click(object sender, EventArgs e)
        {
            string url = @"http://192.168.0.200/WEBcmp/api/compareshops";  //mezon
            //string url = @"http://10.3.5.56//WEBcmp/api/compareshops";    //mif
            //string url = @"http://192.168.1.153/WEBcmp/api/compareshops"; //barak

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("", mainLabel.Text)
                });
                HttpResponseMessage result = await client.PostAsync(url, content);
                string resultContent = await result.Content.ReadAsStringAsync();

                string[] details = resultContent.Split('#');
                currentSpent = float.Parse(details[0].Substring(1,details[0].Length-1));
                currSpentLabel.Text = currentSpent.ToString();
                string[] q = details[1].Split('$');
                resultContent = "";
                for (int i = 0; i < q.Length; i++)
                    resultContent += q[i] + System.Environment.NewLine;
                    
                moneySaved.Text = resultContent;
            }


        }

        private async void btnTest_Click(object sender, EventArgs e)
        {
            //string url = @"http://192.168.0.200/WEBcmp/api/testmethod";  //mezon
            //string url = @"http://10.3.5.56/WEBcmp/api/testmethod";    //mif
            /*moneySaved.Text = "started server connection";
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(url);
                string resultContent = await result.Content.ReadAsStringAsync();
                moneySaved.Text = resultContent;
            }*/
            string url = @"http://192.168.0.200/WEBcmp/database/generateDatabase";
            moneySaved.Text = "connection started";
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.GetAsync(url);
                string resultText = await result.Content.ReadAsStringAsync();
                moneySaved.Text = resultText;
            }
        }

        private void nonWebBtn_Click(object sender, EventArgs e)
        {
            using (var db = new ComparerModel())
            {
                var productA = new Product() { Id = 1, Name = "pienas", Price = 1.02f , Date = DateTime.Now, Accept = false};
                var productB = new Product() { Id = 2, Name = "suris", Price = 2.54f, Date = DateTime.Now, Accept = false };
                db.Products.Add(productA);
                db.Products.Add(productB);
                db.SaveChanges();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void spendingsButton_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["OnlineModel"].ConnectionString;

            con.Open();
            string name = "";
            string password = "";
            string id = "";
            float spendings = 0;
            SqlCommand cmd = new SqlCommand("SELECT CardID, Name, Spent, Password FROM Customers WHERE CardID = @cin", con);
            cmd.Parameters.AddWithValue("@cin", custID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                id = reader.GetString(0);
                name = reader.GetString(1);
                spendings = reader.GetFloat(2);
                password = reader.GetString(3);
            }
            reader.Close();
            cmd = new SqlCommand("UPDATE Customers SET Spent = @spn WHERE CardId = @cid", con);
            cmd.Parameters.AddWithValue("@cid", id);
            cmd.Parameters.AddWithValue("@spn", spendings + currentSpent);
            moneySaved.Text = cmd.ExecuteNonQuery().ToString();
            con.Close();
            spentLabel.Text = (spendings + currentSpent).ToString();
            currentSpent = 0;
            currSpentLabel.Text = currentSpent.ToString();
        }
    }
}


        /*private async Task btnTest_ClickAsync(object sender, EventArgs e)
        {

            moneySaved.Text = "started Task?";

            Lazy<LazyInicialization> lazyTest = new Lazy<LazyInicialization>();
            LazyInicialization x = lazyTest.Value;
            MessageBox.Show(x.ToString());

            string url = @"http://192.168.0.200/TestComparer/api/mytest/computemulti";

            using (var client = new HttpClient())
            {

                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("", "String to Pass")
            });
                var result = await client.PostAsync(url, content);
                string resultContent = await result.Content.ReadAsStringAsync();
                moneySaved.Text = resultContent;
            }
            


            //moneySaved.Text = responseString;

        }*/