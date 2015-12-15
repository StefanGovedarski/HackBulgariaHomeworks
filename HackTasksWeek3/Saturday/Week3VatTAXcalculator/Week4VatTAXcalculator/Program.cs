using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>()
            {
                new Product(15.50 , "rakia" , 1000 , 0001 , "Bulgaria"),
                new Product(3.50 , "vafla" , 500 , 0002 , "Bulgaria"),
                new Product(1.50 , "banichka", 100 , 0003 , "Serbia")
            };
            ShopInventory shopInv = new ShopInventory(list);

            List<int> id = new List<int>() { 0001, 0003 };
            List<int> quantities = new List<int>() { 3, 7 };
            Order order = new Order(id, quantities);
            double result = shopInv.Ordering(order);
            Console.WriteLine(result);




            Console.WriteLine(shopInv.Audit());

        }
    }
}
