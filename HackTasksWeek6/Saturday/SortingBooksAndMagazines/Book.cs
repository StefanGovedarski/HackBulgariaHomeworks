using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    class Book
    {
        public Book(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public int ID { get; set; }
        public string Name { get; set; }
    }
}
