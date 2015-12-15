using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class Product
    {
        private double prizeBeforeTaxes;
        private double prizeAfterTaxes;
        private string productIsAvailableInThisCountry;
        private string productName;
        private int productQuantity;
        private int productID;

        public Product(double prize ,string nameOfTheProduct, int amountOfTheProduct , int IDofTheProduct, string CountryInWhichItIsAvailable)
        {
            this.prizeBeforeTaxes = prize;
            this.productName = nameOfTheProduct;
            this.productQuantity = amountOfTheProduct;
            this.productID = IDofTheProduct;
            this.productIsAvailableInThisCountry = CountryInWhichItIsAvailable;
            AfterTaxCalc();
        }

        public double PrizeBeforTax{ get { return prizeBeforeTaxes; } }
        public double PrizeAfterTax { get { return prizeAfterTaxes; } }
        public string ProductCountry {get { return productIsAvailableInThisCountry; } }
        public string ProductName { get { return productName; } }
        public int ProductQuantity { get { return productQuantity; } }
        public int ProductID { get { return productID; } }

        private double AfterTaxCalc()
        {
            List<CountryVatTAX> list = new List<CountryVatTAX>
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
            double tax = 0;
            CalculateTax calculate = new CalculateTax(list);
            tax = calculate.CalculateVATTax(prizeBeforeTaxes);
            prizeAfterTaxes = prizeBeforeTaxes - tax;
            return prizeAfterTaxes;
        }
    }
}
