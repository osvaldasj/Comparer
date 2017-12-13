using System;
using System.Windows.Forms;

namespace Comparer
{
    public partial class DataReview : Form
    {
        public DataReview()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DataReviewManager manager = new DataReviewManager();
            Console.WriteLine(manager.ToString(manager.PickRecentChanges(8)));
        }

        private void LoadAllProductsData_Click(object sender, EventArgs e)
        {
            dataGridViewAllProducts.DataSource = new ComparerModel();
        }
    }
}