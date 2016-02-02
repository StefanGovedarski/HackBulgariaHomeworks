using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Mammals : Animals
    {
        public void Eat()
        {
            Console.WriteLine("Mammals eat fish,birds,reptiles,plants.");
        }
        public void Move()
        {
            Console.WriteLine("Mammals walk/run.");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Mammals give living birth.");
        }
        public void Greet()
        {
        }
    }    

}
