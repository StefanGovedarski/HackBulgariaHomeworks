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

            List<CountryVatTAX> listOfTaxCountr = new List<CountryVatTAX>()
            {
                new CountryVatTAX("Bulgaria", 0.2d, true),
                new CountryVatTAX("Belgium", 0.19d,false),
                new CountryVatTAX("Albania", 0.2d,false),
                new CountryVatTAX("Greece", 0.11d,false),
                new CountryVatTAX("Serbia", 0.27d,false),
                new CountryVatTAX("Romania", 0.09d,false),
                new CountryVatTAX("Turkey", 0.24d,false),
                new CountryVatTAX("Macedonia", 0.22d,false),
                new CountryVatTAX("Georgia", 0.19d,false),
                new CountryVatTAX("Russia", 0.25d,false),
                new CountryVatTAX("USA", 0.2d,false)
            };

            CalculateTax taxCalc = new CalculateTax(listOfTaxCountr);
            double result1 = 0;
            double result2 = 0;
            result1 = taxCalc.CalculateVATTax(100d , "Bulgaria");
            Console.WriteLine(result1);
            result2 = taxCalc.CalculateVATTax(100d);
            Console.WriteLine(result2);



            List<Product> list = new List<Product>()
            {
                new Product(15.50 , "rakia" , 1000 , 0001 , "Bulgaria"),
                new Product(3.50 , "vafla" , 500 , 0002 , "Greece"),
                new Product(1.50 , "banichka", 100 , 0003 , "Serbia")
            };
            ShopInventory shopInv = new ShopInventory(list);

            List<int> id = new List<int>() { 0001, 0003 };
            List<int> quantities = new List<int>() { 3, 7 };
            Order order = new Order(id, quantities);
            double result = shopInv.Ordering(order);
            Console.WriteLine(result);

        }
    }
}
