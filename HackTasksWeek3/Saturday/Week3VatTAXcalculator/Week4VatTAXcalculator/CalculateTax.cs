using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class CalculateTax
    {
        private List<CountryVatTAX> listOfcountries = new List<CountryVatTAX>();

        public CalculateTax(List<CountryVatTAX> listOfcountries)
        {
            this.listOfcountries = listOfcountries;
        }
        public double CalculateVATTax(double price ,  string id)
        {
            double Tax = 0;
            foreach(var country in listOfcountries)
            {
                if(country.countryID == id )
                {
                    Tax =( price / 100) * country.VatTax*100;
                }
            }
            if (Tax != 0)

            {
                return Tax;
            }
            else
            {
                throw new Exception("Country not supported");
            }
        }
        public double CalculateVATTax(double price)
        {
            double Tax = 0;
            foreach (var country in listOfcountries)
            {
                if (country.defaultt)
                {
                    Tax = (price / 100) * country.VatTax*100;
                }
            }

            if (Tax != 0)

            {
                return Tax;
            }
            else
            {
                throw new Exception("Country not supported");
            }
        }



    }
}
