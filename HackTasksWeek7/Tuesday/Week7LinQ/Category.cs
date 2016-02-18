using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7LinQ
{
    class Category
    {
        private static List<Category> allCategories = new List<Category>();

        public Category(int categoryID , string categoryName)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
            if(IdChecker(this))
            allCategories.Add(this);
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public static List<Category> GetCategories
        {
            get {return allCategories; }
        }
        private bool IdChecker(Category cate)
        {
            if (cate.CategoryID < 101 || cate.CategoryID > 200)
                return false;
            else
                return true;
        }
    }
}
