using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace WEB.ComparisonEngine
{
    public static class UpdateDababase
    {
        public static void UpdateDatabase(List<FromFileToStruct.Product> curr)
        {
            foreach(FromFileToStruct.Product x in curr)
            {

            }
        }

        public static void RequestForDatabase(FromFileToStruct.Product x)
        {
            using (var db = new ComparerModel())
            {
                Product a = new Product() { Name = x.name, Price = x.price, Shop = x.shop, Date = x.date, Accept = false };
                db.Products.Add(a);
                db.SaveChanges();
            }
        }
    }
}