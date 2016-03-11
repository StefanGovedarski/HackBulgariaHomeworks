using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingBooksAndMagazines
{
    class Magazine
    {
        public Magazine(string name, int id)
        {
            this.Title = name;
            this.ID = id;
        }

        public int ID { get; set; }
        public string Title { get; set; }
    }
}
