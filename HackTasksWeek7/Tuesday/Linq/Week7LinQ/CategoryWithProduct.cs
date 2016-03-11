using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LinQ
{
    class CategoryWithProduct
    {
        private static List<CategoryWithProduct> listOfCategoriesWithProducts = new List<CategoryWithProduct>();

        public CategoryWithProduct(string categoryName, int productID , List<Product> productnames)
        {
            this.CategoryName = categoryName;
            this.ProductID = productID;
            this.ProductNames = productnames;
            listOfCategoriesWithProducts.Add(this);
        }

        public string CategoryName { get; set; }
        public int ProductID { get; set; }
        public List<Product>ProductNames { get; set; }
        public static List<CategoryWithProduct> CategoryWithProductList
        {
            get { return listOfCategoriesWithProducts; }
        }

    }
}
