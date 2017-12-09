using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Comparer
{
    public static class FromFileToStruct
    {
        //struct which holds a product with its properties
        public struct Product {
            public string name;
            public float price;
            public string shop;
            public string date;

            public Product(string n, float p, string sn, string d)
            {
                name = n;
                price = p;
                shop = sn;
                date = d;
            }
        }

        //class which created a List from a given file path
        public static List<Product> MakeProductList(string path)
        {
            List<Product> list = new List<Product>();
            string[] text = System.IO.File.ReadAllLines(path);
            int index = 0;
            //takes shop name and date of the check from file and keeps them in a constant string
            string shopName = text[index++];
            string checkDate = text[index];
            index++;
            //starting from 3rd line starts to make a new product struct
            try
            {
                while (text[index] != null)
                {
                    int x = 1;
                    float tPrice = 0;
                    float dec = 0.01f;
                    //starting from the back of the string takes one symbol at a time and makes it into a float until it finds a space symbol
                    while(text[index].ElementAt(text[index].Length - x) != ' ')
                    {
                        if ((text[index].ElementAt(text[index].Length - x) - '0') != -4)
                        {
                            tPrice += (text[index].ElementAt(text[index].Length - x) - '0') * dec;
                            dec = dec * 10;
                        }
                        x++;
                    }
                    //adds name until the space which was found making a float
                    tPrice = formatFloat(tPrice);
                    Product temp = new Product(text[index].Substring(0, text[index].Length - x), tPrice, shopName, checkDate);
                    index++;
                    //adds product to current list
                    list.Add(temp);
                }
            }
            catch { }
            
            return list;
        }

        public static List<Product> MakeProductList2(string path)
        {
            List<Product> list = new List<Product>();
            //string[] text = System.IO.File.ReadAllLines(path);
            CompWebService.WebServiceSoapClient client = new CompWebService.WebServiceSoapClient();
            string[] text = client.ProductList().Split('$');
            int index = 0;
            try
            {
                while (text[index] != null)
                {
                    int space1 = text[index].IndexOf(' ');
                    int space2 = text[index].IndexOf(' ', space1 + 1);
                    int idx = text[index].LastIndexOf(' ') + 1;


                    string strPrice = text[index].Substring(idx, text[index].Length - idx);
                    //string[] StrRemake = strPrice.Split(',');
                    //strPrice = StrRemake[0] + '.' + StrRemake[1];

                    float price = float.Parse(strPrice);

                    string name = text[index].Substring(space2 + 1, idx - space2 - 2);
                    string shop = text[index].Substring(0, space1);
                    string date = text[index].Substring(space1 + 1, space2-space1-1);

                    //MessageBox.Show("shop: " + text[index].Substring(0, space1) + " date: "+ text[index].Substring(space1+1, 10)+ " Product: " + text[index].Substring(space2+1, idx - space2-2) + " wtih a price of " + price);
                    Product temp = new Product(name, price, shop, date);
                    list.Add(temp);
                    index++;
                }
            }
            catch { }

            return list;
        }

        public static List<Product> MakeProductList3(string path)
        {
            List<Product> list = new List<Product>();
            Lazy<Product> prod = new Lazy<Product>();
            string[] text = System.IO.File.ReadAllLines(path);
            int index = 0;
            //takes shop name and date of the check from file and keeps them in a constant string
            string shopName = text[index++];
            string checkDate = text[index];
            index++;
            //starting from 3rd line starts to make a new product struct
                for (int i = index; i<text.Length; i++)//(text[index] != null)
                {
                    string name = text[i];
                    i++;
                    string strFloat = text[i];
                    strFloat = strFloat.Replace(',', '.');
                    float price = float.Parse(strFloat);
                    //adds name until the space which was found making a float
                    price = formatFloat(price);
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

        public static float formatFloat(float x)
        {
            x = float.Parse(String.Format("{0:0.00}", x));
            return x;
        }
    }
}
