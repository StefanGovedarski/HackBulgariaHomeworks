using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class CountryVatTAX
    {
        private readonly string CountryID;
        private readonly double VATTax;
        private readonly bool Default;

        public CountryVatTAX(string countryID , double tax, bool isDefault)
        {
            CountryID = countryID;
            VATTax = tax;
            Default = isDefault;
        }
        public string countryID
        {
            get{ return CountryID; }
        }
        public double VatTax
        {
            get { return VATTax; }
        }
        public bool defaultt
        {
            get { return Default; }
        }
    }
}
