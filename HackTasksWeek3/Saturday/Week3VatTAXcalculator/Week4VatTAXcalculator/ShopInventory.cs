using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class ShopInventory
    {
        private List<Product> allProductsInTheShopInventory = new List<Product>();

        public ShopInventory(List<Product> products)
        {
            allProductsInTheShopInventory = products;
        }

        public int Audit()
        {
            int total = 0;
            foreach(Product p in allProductsInTheShopInventory)
            {
                total += (int)(p.PrizeAfterTax*p.ProductQuantity);
            }
            return total;

        }
        public double Ordering(Order order)
        {
            double amount = 0;
            for (int i = 0; i < order.ProductIDs.Count; i++)
            {
                for (int j = 0; j < allProductsInTheShopInventory.Count; j++)
                {
                    if (order.ProductIDs[i] == allProductsInTheShopInventory[j].ProductID)
                    {
                        if (order.ProductQuantities[i] <= allProductsInTheShopInventory[j].ProductQuantity)
                        {
                            amount += allProductsInTheShopInventory[j].PrizeAfterTax * order.ProductQuantities[i];
                        }
                        else
                            Console.WriteLine("not enough of this item in stock.");
                    }
                    else
                        Console.WriteLine("Item does not exist in the shop");
                }
            }
            return amount;
        }
    }
}
