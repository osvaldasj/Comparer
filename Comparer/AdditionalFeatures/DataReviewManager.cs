using System.Collections.Generic;
using System.Linq;

namespace Comparer
{
    class DataReviewManager
    {
        const int NUMBER_OF_CHANGES_DISPLAYED = 8;

        public class RecentProduct
        {
            public string name;
            public string shopName;
            public System.DateTime recentDate;
            public System.DateTime beforeDate;
            public float recentPrice;
            public float beforePrice;
        }

        public List<RecentProduct> PickRecentChanges(int amount)
        {
            using (var db = new ComparerModel())
            {
                var wholeList = db.Price.ToList();
                var recentList = wholeList.OrderByDescending(x => x.DateT);
                var productsWithRecentDifference = new List<RecentProduct>();

                int i = 0;
                int pickedProducts = 0;
                var temp = new RecentProduct();
                foreach (var product in recentList)
                {
                    if (pickedProducts == amount)
                    {
                        break;
                    }
                    temp = new RecentProduct()
                    {
                        name = product.ProductID,
                        shopName = product.ShopID,
                        recentDate = product.DateT,
                        recentPrice = product.PriceD
                    };
                    i++;
                    foreach (var product2 in recentList.Skip(i))
                    {
                        if (product.ProductID == product2.ProductID && product.ShopID == product2.ShopID)
                        {
                            temp.beforeDate = product2.DateT;
                            temp.beforePrice = product2.PriceD;
                            productsWithRecentDifference.Add(temp);
                            pickedProducts++;
                            break;
                        }
                    }
                }
                return productsWithRecentDifference;
            }
        }
    }
}