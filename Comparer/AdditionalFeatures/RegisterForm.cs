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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            //string url = @"http://192.168.0.200/WEBcmp/login/register"; // mezon
            string url = @"http://10.3.5.56//WEBcmp/login/register";    //mif
            //string url = @"http://192.168.1.153/WEBcmp/login/register"; //barak


            var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("", usernameBox.Text + "$" + passwordBox.Text)
                });
            HttpResponseMessage result = await client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();
            MessageBox.Show(resultContent);
            this.Close();
        }
    }
}
