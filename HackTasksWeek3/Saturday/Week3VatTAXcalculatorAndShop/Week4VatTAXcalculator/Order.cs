using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3VatTAX
{
    class Order
    {
        private List<int> productIDs = new List<int>();
        private List<int> productQuantities = new List<int>();

        public Order(List<int> ids , List<int> quantities)
        {
            productIDs = ids;
            productQuantities = quantities;
        }
        public List<int> ProductIDs
        {
            get { return productIDs; }
        }
        public List<int> ProductQuantities
        {
            get { return productQuantities; }
        }

    }
}
