using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Windows.Forms;

namespace WebService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public void test()
        {
            MessageBox.Show("test method");
        }

        [WebMethod]
        public string ProductList()
        {
            string list = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                     AttachDbFilename=C:\USERS\USER\DOCUMENTS\GITHUB\COMPARISONENGINE\WEBSERVICE\APP_DATA\COMPARERDATABASE.MDF;
                                     Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Shop, Date, Name, Price FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list = list + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetDouble(3).ToString() + "$";
            }
            reader.Close();
            con.Close();
            return list;
        }



        [WebMethod]
        public void AddNewProductToDatabase(string name, float price, string date, string shop)
        {
            //MessageBox.Show("refreshed?");
            string connetionString = null;
            string sql = null;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                     AttachDbFilename=C:\Users\llluu\OneDrive\Documents\GitHub\ComparisonEngine\WebService\App_Data\ComparerDatabase.mdf;
                                     Integrated Security=True";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "INSERT INTO Products" +
                                            " VALUES (@val1, @val2, @val3, @val4, @val5)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@val1", name);
                    cmd.Parameters.AddWithValue("@val2", price);
                    cmd.Parameters.AddWithValue("@val3", date);
                    cmd.Parameters.AddWithValue("@val4", shop);
                    cmd.Parameters.AddWithValue("@val5", 1);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
