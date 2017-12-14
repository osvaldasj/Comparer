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
            bool added = false;
            using (var db = new ComparerModel())
            {
                List<Price> fullPrices;
                List<Product> fullProd;
                fullPrices = db.Prices.ToList();
                fullProd = db.Products.ToList();
                foreach (FromFileToStruct.Product x in curr)
                {
                    foreach(Product a in fullProd)
                    {
                        if(a.Name == x.name && a.Shop == x.shop)
                        {
                            foreach(Price q in fullPrices)
                            {
                                if(q.ProductID == a.Id && !added && q.DateT != a.Date)
                                {
                                    try
                                    {
                                        Price newP = new Price() { ProductID = a.Id, PriceD = x.price, DateT = x.date , ShopID = (x.shop == "maxima" ? 0 : (x.shop == "rimi" ? 1 : 3)) };
                                        db.Prices.Add(newP);
                                        db.SaveChanges();
                                        added = true;
                                    }
                                    catch { }
                                }
                            }
                            if(added == false)
                            {
                                Price newP = new Price() { ProductID = a.Id, PriceD = x.price, DateT = x.date, ShopID = (x.shop == "maxima" ? 0: (x.shop == "rimi" ? 1: 3)) };
                                db.Prices.Add(newP);
                                db.SaveChanges();
                                added = true;
                            }
                        }
                    }
                    added = false;
                }
            }
        }

        public static void RequestForDatabase(FromFileToStruct.Product x)
        {
            using (var db = new ComparerModel())
            {
                Product a = new Product() { Name = x.name, Price = x.price, Shop = x.shop, Date = x.date, Accept = false, ShopID = 0 };
                db.Products.Add(a);
                db.SaveChanges();
            }
        }

        internal static void CustomerSpentUpdate(float fullCheckPrice)
        {
            using (var db = new ComparerModel())
            {

            }
        }
    }
}