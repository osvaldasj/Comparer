using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.ComparisonEngine
{
    public class AddToDatabase
    {
        public void AddItem(ComparisonEngine.FromFileToStruct.Product x)
        {
            using (var db = new ComparerModel())
            {
                var product = new Product() {Name = x.name, Price = x.price, Date = DateTime.Now, Shop = x.shop, Accept = false };
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
    }
}