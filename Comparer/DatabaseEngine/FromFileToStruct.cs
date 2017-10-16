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
                    Product temp;
                    temp.shop = shopName;
                    temp.date = checkDate;
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
                    temp.name = text[index].Substring(0, text[index].Length - x);
                    tPrice = float.Parse(String.Format("{0:0.00}", tPrice));
                    temp.price = tPrice;
                    index++;
                    //adds product to current list
                    list.Add(temp);
                }
            }
            catch { }
            
            return list;
        }
    }
}
