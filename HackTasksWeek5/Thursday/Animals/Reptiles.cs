using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Reptiles : Animals
    { 
        public void Eat()
        {
            Console.WriteLine("Reptiles eat meat.");
        }
        public void Move()
        {
            Console.WriteLine("Reptiles walk/run.");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Reptiles hatch from eggs.");
        }
        public void Greet()
        {

        }
    }
}
