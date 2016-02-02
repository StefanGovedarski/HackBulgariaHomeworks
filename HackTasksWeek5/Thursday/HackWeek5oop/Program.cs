using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5oop
{
    class Program
    { 
        static void Main(string[] args)
        {
            BMW bmw = new BMW(10000);
            Volkswagen volks = new Volkswagen(150);
            Audi audi = new Audi(300);
            bool test = false;
            Console.WriteLine(bmw.IsEcoFriendly(test));
            Console.WriteLine(volks.IsEcoFriendly(test));
            Console.WriteLine(audi.IsEcoFriendly(test));

        }
    }
}
