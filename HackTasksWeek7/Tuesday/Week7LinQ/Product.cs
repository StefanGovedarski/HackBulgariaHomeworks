using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LinQ
{
    class Product
    {
        private static List<Product> allProducts = new List<Product>();

        public Product(string name , int productID , int categoryID)
        {
            this.Name = name;
            this.ProductID = productID;
            this.CategoryID = categoryID;
            if(IdChecker(this))
            allProducts.Add(this);
        }

        public string Name { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public static List<Product> GetProducts
        {
            get { return allProducts; }
        }

        private bool IdChecker(Product prod)
        {
            if (prod.ProductID < 1 || prod.ProductID > 100)
                return false;
            else
                return true;
        }
    }
}
