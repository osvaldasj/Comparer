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
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=.\SQLEXPRESS;
                          AttachDbFilename=C:\Users\llluu\OneDrive\Documents\GitHub\ComparisonEngine\WebService\App_Data\ComparerDatabase.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;
                          User Instance=True";
            con.Open();
            MessageBox.Show("Connection opened");
            con.Close();
            MessageBox.Show("Connection closed");
        }

        [WebMethod]
        public string ProductList()
        {
            string list = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                     AttachDbFilename=C:\Users\llluu\OneDrive\Documents\GitHub\ComparisonEngine\WebService\App_Data\ComparerDatabase.mdf;
                                     Integrated Security=True";
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Shop, Date, Name, Price FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                list = list + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetDouble(3).ToString() + "$";
            }
            reader.Close();
            con.Close();
            return list;
        }
    }
}
