using System;
using System.Collections.Generic;
using System.Collections;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace WebApp.ComparisonEngine
{
    public class CompareShops
    {
        private string infofile;
        private string infoToShow;

        //class which compares current check product list with one of the databases lists
        public string CompareResults(string currentCheckText)
        {
            infoToShow = "Something added" + System.Environment.NewLine;
            List<FromFileToStruct.Product> currentCheck = new List<FromFileToStruct.Product>();
            List<FromFileToStruct.Product> fullDatabase = new List<FromFileToStruct.Product>();
            currentCheck = FromFileToStruct.MakeProductList(currentCheckText);

            
            string list = "";
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
            //Data Source = mssql#.gear.host;Initial Catalog=DBName;User ID=DBUser;Password=myPassword
               // Persist Security Info = True;
            con.ConnectionString = @"Data Source=mssql4.gear.host;Initial Catalog=comparerdb;User ID=comparerdb;Password=Ka8I9-w?p241";
                /*@"Data Source=(LocalDB)\MSSQLLocalDB;
                                     AttachDbFilename=http://192.168.0.200/ComparerApp/APP_DATA\COMPARERDATABASE.MDF;
                                     Integrated Security=True";*/
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Shop, Date, Name, Price FROM Products", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //infoToShow = infoToShow + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetDouble(3).ToString() + "/n";
                list = list + reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetDouble(3).ToString() + "$";
            }
            reader.Close();
            con.Close();
            fullDatabase = FromFileToStruct.MakeProductList2(list);

            var maxima = from x in fullDatabase where x.shop == "maxima" select x;
            var rimi = from x in fullDatabase where x.shop == "rimi" select x;



            WriteToFile write = new WriteToFile();
            float moneyDifference = 0;



            if (currentCheck[0].shop == "maxima")
            {
                moneyDifference = InfoCollector(1, currentCheck, rimi, write, infoToShow);
            }
            else if (currentCheck[0].shop == "rimi")
            {
                moneyDifference = InfoCollector(2, currentCheck, rimi, write, infoToShow);
            }
            else
            {
                infofile = "";
                //MessageBox.Show("unrecognized shop");
            }

            infoToShow = infoToShow + write.Write(infofile, moneyDifference, infoToShow);

            return infoToShow;
        }

        private float InfoCollector(int which, List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList, WriteToFile write, string infoToShow)
        {
            infoToShow = write.Write(which, infoToShow);
            float moneyDifference = 0;
            moneyDifference = EvaluateTwoChecks(currentCheck, otherShopList, write, infofile, infoToShow);
            return moneyDifference;
        }

        public float EvaluateTwoChecks(List<FromFileToStruct.Product> currentCheck, IEnumerable otherShopList, WriteToFile write, string info, string infoToShow)
        {
            int neededValue = 80;
            int currentValue;
            float moneyDifference = 0;
            bool wasFound = false;

            for (int i = 0; i <= currentCheck.Count - 1; i++)
            {
                foreach (FromFileToStruct.Product otherShop in otherShopList)
                {
                    currentValue = Compare(currentCheck[i].name, otherShop.name);
                    if (currentValue >= neededValue)
                    {
                        moneyDifference += (currentCheck[i].price - otherShop.price);
                        infoToShow = infoToShow + write.Write(currentCheck[i].name, info, (currentCheck[i].price - otherShop.price), infoToShow);
                        wasFound = true;
                    }
                }
                if (!wasFound)
                {
                    //UpdateDatabase.RequestForDatabase(currentCheck[i]);  //to be made in the future
                    //MessageBox.Show("unrecognized product: " + currentCheck[i].name);
                }
                wasFound = false;
            }

            return moneyDifference;
        }

        //compares two strings how close they are the same and returns the value between 0 and 100 meaning %
        public int Compare(object x, object y)
        {
            int counter = 0;
            string A = (string)x;
            string B = (string)y;
            int lenA = A.Length, lenB = B.Length; ;
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
            for (int i = 0; i < lenMin; i++)
            {
                if (A[i] == B[i])
                    counter++;
            }
            if (lenMax != 0)
                return counter * 100 / lenMax;
            else
                return 0;
        }
    }
}
 