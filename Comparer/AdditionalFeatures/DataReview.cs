using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace Comparer
{
    public partial class DataReview : Form
    {
        public DataReview()
        {
            InitializeComponent();
        }
        private static readonly HttpClient client = new HttpClient();
        private async void Form2_Load(object sender, EventArgs e)
        {
            //DataReviewManager manager = new DataReviewManager();
            //Console.WriteLine(manager.ToString(manager.PickRecentChanges(8)));


            //string url = @"http://192.168.0.200/WEBcmp/api/datareview"; // mezon
            string url = @"http://10.3.5.56//WEBcmp/api/datareview";    //mif
            //string url = @"http://192.168.1.153/WEBcmp/api/datareview"; //barak

            var content = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string, string>("", 8.ToString())
                });
            HttpResponseMessage result = await client.PostAsync(url, content);
            string resultContent = await result.Content.ReadAsStringAsync();

            textBoxRecentPricesChanges.Text = resultContent;
        }

        private void LoadAllProductsData_Click(object sender, EventArgs e)
        {
            dataGridViewAllProducts.DataSource = new ComparerModel();
        }
    }
}