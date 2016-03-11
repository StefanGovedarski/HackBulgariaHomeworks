using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LinQ
{
    class Order
    {
        private static List<Order> allOrders= new List<Order>();

        public Order(int orderID , List<int> productList , DateTime orderDate , string name)
        {
            this.OrderID = orderID;
            this.Products = productList;
            this.OrderDate = orderDate;
            this.Name = name;
            if(IdChecker(this))
            allOrders.Add(this);
        }

        public int OrderID { get; set; }
        public List<int> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public static List<Order> GetOrder
            {
            get{return allOrders;}
            }

        private bool IdChecker(Order order)
        {
            if (order.OrderID < 201 || order.OrderID > 300)
                return false;
            else
                return true;
        }
    }
}
