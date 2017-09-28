using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace Comparer
{
    public class ProductComparer
    {
				private double[] costsMaxima; // should be a dictionary created somewhere in TextManager ?
				private double[] costsRimi; // --..--
				
				private double saved_money;
				
				private double getSavedMoney() {
					return saved_money;
				}
				
				private double ComparePrices (string shop, string product, double cost) {
					if (shop == "rimi") {
						// compare with maxima's pricing
						if (cost < costsMaxima[product])
							saved_money += (costsMaxima[product] - cost);
					}
					else if (shop == "maxima") {
						// compare with rimi's pricing
						if (cost < costsMaxima[product])
							saved_money += (costsMaxima[product] - cost);
					}
				}

        private string DetectProductName(string text) // should go to TextManager?
        {
            if (text.Contains("kiausiniai"))
            {
								if (text.Contains("rimi")) {// ? won't clash if product name contains shop name ?
										//ComparePrices (_shopName, "kiausiniai rimi", double(TEXT_SHOWING_PRICE)) // !!!
								}
            }
            else if (text.Contains("pienas"))
            {

            }            
						else if (text.Contains("duona"))
            {
							
            }
            else
            {
                return "unrecognized";
            }
        }
		}
}
