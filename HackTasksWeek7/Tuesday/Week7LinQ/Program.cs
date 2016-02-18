using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("green apple", 1, 102);
            Product product2 = new Product("melon", 3, 102);
            Product product3 = new Product("pear", 4, 102);
            Product product4 = new Product("red apple", 2, 102);
            Product product5 = new Product("strawberry", 5, 102);
            Product product6 = new Product("TV", 6, 105);
            Product product7 = new Product("laptop", 7, 105);
            Product product8 = new Product("fridge", 10, 105);
            Product product9 = new Product("microwave", 11, 105);
            Product product10 = new Product("hat", 21, 112);
            Product product11 = new Product("jacket", 23, 112);
            Product product12 = new Product("shoes", 24, 112);
            Category category1 = new Category(102, "Fruits");
            Category category2 = new Category(105, "Devices");
            Category category3 = new Category(112, "Clothes");
            Order order1 = new Order(211, new List<int>() { 1, 3, 4, 2, 5 }, new DateTime(2016, 1, 1), "Fruit Order");
            Order order2 = new Order(222, new List<int>() { 6, 7, 10, 11 }, new DateTime(2016, 1, 4), "Device Order");
            Order order3 = new Order(233, new List<int>() { 21, 23, 24 }, new DateTime(2016, 1, 10), "Clothes Order");
            Order order4 = new Order(244, new List<int>() { 1, 3, 4 }, new DateTime(2015, 12, 11), "Fruit Order 2");
            //linq2();linq3();linq1();
            Console.WriteLine();
            linq6();


        }
        public static void linq1()
        {
            //Create linq query which returns all products with ids between 15 and 30
            List<Product> products = Product.GetProducts;

            var productWithIdBetween15and30 =
                from prod in products
                where prod.ProductID > 15 && prod.ProductID < 30
                select prod;

            foreach (var prod in productWithIdBetween15and30)
            {
                Console.WriteLine("{0} is the product ID of {1}", prod.ProductID, prod.Name);
            }
        }
        public static void linq2()
        {
            //Create linq query which returns all categories with ids between 105 and 125
            List<Category> categ = Category.GetCategories;
            var categoriesWithIDbetween105and125 =
            from cate in categ
            where cate.CategoryID > 105 && cate.CategoryID < 125
            select cate;

            foreach (var category in categoriesWithIDbetween105and125)
            {
                Console.WriteLine("{0} is the category ID of {1}", category.CategoryID, category.CategoryName);
            }


        }
        public static void linq3()
        {
            //Create linq query which returns first 15 orders sorted by order name
            List<Order> listOfOrders = Order.GetOrder;
            var OrderlistSortedByName =
                from order in listOfOrders
                orderby order.Name
                select order;
            foreach (var order in OrderlistSortedByName)
            {
                Console.WriteLine(order.Name);
            }
        }
        public static void linq4()
        {
            //Create linq query which returns first 3 orders which contains a specific productId (e.g. 10). Orders must be sorted based on OrderDate The print order names.
            List<Order> listOfOrders = Order.GetOrder;
            var SpecialOrdersList =
                from order in listOfOrders
                where order.Products.Contains(1)
                orderby order.OrderDate
                select order;
            var PrintList = SpecialOrdersList.Take<Order>(3);
            foreach (var order in PrintList)

                Console.WriteLine(order.Name);
        }

        public static void linq5()
        {
            //Create linq query which returns all product with the name of the category which they belong to. Order the result based on CategoryName The result must be printed to the console.
            List<Product> listOfProducts = Product.GetProducts;
            List<Category> listOfCategory = Category.GetCategories;

            var listOfAllProductsSortedByCategory =
                from cat in listOfCategory
                join prod in listOfProducts on cat.CategoryID equals prod.CategoryID
                orderby cat.CategoryName
                select new { prod.Name, cat.CategoryName };
            foreach(var prod in listOfAllProductsSortedByCategory)
            {
                Console.WriteLine(prod.Name + " " +  prod.CategoryName);
            }
            

        }
        public static void linq6()
        {
            //Create linq query which returns all categories together with their products
            //Create class CategoryWithProduct which should keep the result the class CategoryWithProduct must conrtain the following
            //properties : CategoryName : string, ProductNames : List<string>, CategoryId : int
            List<Product> listOfProducts = Product.GetProducts;
            List<Category> listOfCategories = Category.GetCategories;

            var listOfAllProdsAndCates =
                from cate in listOfCategories
                join prod in listOfProducts on cate.CategoryID equals prod.CategoryID
                orderby cate.CategoryID
                select new { cate.CategoryID, prod.ProductID,prod.Name,cate.CategoryName };



            foreach (var item in listOfAllProdsAndCates)
                
            {
                CategoryWithProduct catewprod = new CategoryWithProduct(item.CategoryName, item.ProductID, listOfProducts);
                Console.WriteLine(item.CategoryID + "product ID is " + item.ProductID + ", " + item.Name);
            }
       }
        public static void linq7()
        {
            /*
    Create linq query which selects all orders together with their products and then print it to the screen
For every product print its category name as well. Sort the result by orderDate.*/

            List<Product> listOfProducts = Product.GetProducts;
            List<Category> listOfCategories = Category.GetCategories;
            List<Order> listOfOrders = Order.GetOrder;

            foreach (var order in listOfOrders)
            {
                var FinalPrintList =
                from productId in order.Products
                join product in listOfProducts on productId equals product.ProductID
                join categories in listOfCategories on product.CategoryID equals categories.CategoryID
                select new { order.Name, product.ProductID, categories.CategoryName };
            }

        }
    } 

}
