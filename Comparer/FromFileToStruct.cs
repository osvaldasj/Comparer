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
        public struct Product {
            public string name;
            public float price;
            public string shop;
            public string date;
        }

        public static List<Product> MakeProductList(string path)
        {
            List<Product> list = new List<Product>();
            string[] text = System.IO.File.ReadAllLines(path);
            int index = 0;
            string shopName = text[index++];
            string checkDate = text[index];
            index++;
            try
            {
                while (text[index] != null)
                {
                    Product temp;
                    temp.shop = shopName;
                    temp.date = checkDate;
                    int x = 1;
                    float tPrice = 0;
                    float dec = 0.01f;
                    while(text[index].ElementAt(text[index].Length - x) != ' ')
                    {
                        if ((text[index].ElementAt(text[index].Length - x) - '0') != -4)
                        {
                            tPrice += (text[index].ElementAt(text[index].Length - x) - '0') * dec;
                            dec = dec * 10;
                        }
                        x++;
                    }
                    temp.name = text[index].Substring(0, text[index].Length - x);
                    tPrice = float.Parse(String.Format("{0:0.00}", tPrice));
                    temp.price = tPrice;
                    index++;
                    list.Add(temp);
                }
            }
            catch { }
            
            return list;
        }
    }
}
