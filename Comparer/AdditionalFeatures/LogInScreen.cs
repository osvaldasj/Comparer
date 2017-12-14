using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparer.AdditionalFeatures
{
    public partial class LogInScreen : Form
    {
        public LogInScreen()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            string url = @"http://192.168.0.200/WEBcmp/login/login"; // mezon
            //string url = @"http://10.3.5.56//WEBcmp/login/login";    //mif
            //string url = @"http://192.168.1.153/WEBcmp/login/login"; //barak


            testLabel.Text = "Attempting to connect...";

            var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("", usernameBox.Text + "$" + passwordBox.Text)
                });
            HttpResponseMessage result = await client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
            if(resultContent.Substring(13,7) == "success")
            {
                this.Hide();
                Main m = new Main(usernameBox.Text, resultContent.Substring(20, resultContent.Length-21), resultContent.Substring(1,12));
                m.ShowDialog();
            }
            else
            {
                testLabel.Text = "Wrong username or password!";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.ShowDialog();
        }
    }
}
