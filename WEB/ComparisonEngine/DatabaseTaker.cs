using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WEB.ComparisonEngine
{
    public class DatabaseTaker
    {
        public string list { set; get; }
        public DatabaseTaker()
        {
            string list = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Shop, Date, Name, Price FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list = list + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetDouble(3).ToString() + "$";
            }
            reader.Close();
            con.Close();
        }
    }
}