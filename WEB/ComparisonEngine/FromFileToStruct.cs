using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace WEB.ComparisonEngine
{
    public class FromFileToStruct
    {
        //struct which holds a product with its properties
        public struct Product
        {
            public string name;
            public float price;
            public string shop;
            public DateTime date;

            
            public Product(string n, float p, string sn, DateTime d)
            {
                name = n;
                price = p;
                shop = sn;
                date = d;
            }
        }

        //class which created a List from a given file path
        public static List<Product> MakeProductList(string currentCheck)
        {
            List<Product> list = new List<Product>();
            Lazy<Product> prod = new Lazy<Product>();
            string[] text = currentCheck.Split(new[] { '\r', '\n' });
            int index = 0;
            //takes shop name and date of the check from file and keeps them in a constant string
            string shopName = text[index++];
            DateTime date = DateTime.ParseExact(text[index]+" 0:00:00 AM",
                               "MM/dd/yy h:mm:ss tt",
                               CultureInfo.InvariantCulture);
            DateTime checkDate = date;
            index++;
            //starting from 3rd line starts to make a new product struct
            for (int i = index; i < text.Length; i++)//(text[index] != null)
            {
                string name = text[i];
                i++;
                string strFloat = text[i];
                strFloat = strFloat.Replace(',', '.');
                float price = float.Parse(strFloat);
                //adds name until the space which was found making a float
                price = FormatFloat(price);
                Product temp = prod.Value;
                //Product temp = new Product(name, price, shopName, checkDate);
                temp.name = name;
                temp.price = price;
                temp.shop = shopName;
                temp.date = checkDate;
                //adds product to current list
                list.Add(temp);
            }

            return list;
        }

        public static List<Product> MakeProductList2(string givenDatabase)
        {
            List<Product> list = new List<Product>();
            string[] text = givenDatabase.Split('$');
            int index = 0;
                while (text[index] != null)
                {
                    int space1 = text[index].IndexOf(' ');
                    int space2 = text[index].IndexOf(' ', space1 + 1);
                    int idx = text[index].LastIndexOf(' ') + 1;


                    string strPrice = text[index].Substring(idx, text[index].Length - idx);
                    float price = float.Parse(strPrice);

                    string name = text[index].Substring(space2 + 1, idx - space2 - 2);
                    string shop = text[index].Substring(0, space1);
                    string datex = text[index].Substring(space1 + 1, space2 - space1 - 1);

                var date = DateTime.ParseExact(datex + " 0:00:00 AM",
                               "MM/dd/yy h:mm:ss tt",
                               CultureInfo.InvariantCulture);

                Product temp = new Product(name, price, shop, date);
                    list.Add(temp);
                    index++;
                }

            return list;
        }

        public static List<Product> MakeProductList3(string givenDatabase)
        {
            List<Product> list = new List<Product>();
            string x = "";
            string[] text = givenDatabase.Split('$');
            int index = 0;
            try
            {
                while (text[index] != null)
                {
                    int space1 = text[index].IndexOf(' ');
                    int space2 = text[index].IndexOf(' ', space1 + 1);
                    int idx = text[index].LastIndexOf(' ') + 1;


                    string strPrice = text[index].Substring(idx, text[index].Length - idx);
                    float price = float.Parse(strPrice);

                    string name = text[index].Substring(space2 + 1, idx - space2 - 2);
                    string shop = text[index].Substring(0, space1);
                    string datex = text[index].Substring(space1 + 1, space2 - space1 - 1);

                    var date = DateTime.ParseExact(datex + " 0:00:00 AM",
                               "MM/dd/yy h:mm:ss tt",
                               CultureInfo.InvariantCulture);

                    Product temp = new Product(name, price, shop, date);
                    x += temp.name + temp.price + temp.shop + temp.date.ToShortDateString() + " ";
                    list.Add(temp);
                    index++;
                }
            }
            catch
            {
                //throw new Exception("Index was out of range");
            }

            return list;
        }

        public static float FormatFloat(float x)
        {
            x = float.Parse(String.Format("{0:0.00}", x));
            return x;
        }
    }
}