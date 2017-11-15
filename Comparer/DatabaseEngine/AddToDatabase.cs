using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Comparer
{
    public static class AddToDatabase
    {
        public static void PushToDatabase(FromFileToStruct.Product newProduct)
        {
            CompWebService.WebServiceSoapClient client = new CompWebService.WebServiceSoapClient();
            MessageBox.Show(newProduct.name + " " + newProduct.price.ToString() + " " + newProduct.date + " " + newProduct.shop);
            client.AddNewProductToDatabase(newProduct.name, newProduct.price, newProduct.date, newProduct.shop);
            //client.test();
        }
    }
}
