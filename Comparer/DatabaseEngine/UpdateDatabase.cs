using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparer
{
    public static class UpdateDatabase
    {
        public static void RequestForDatabase(FromFileToStruct.Product unknownProduct)
        {
            //MessageBox.Show("Product with a name of: " + unknownProduct.name + " has been found it will be added to database");
            AddToDatabase.PushToDatabase(unknownProduct);
        }
    }
}
