using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Bird : Animals
    {
        public void Eat()
        {
            Console.WriteLine("Small birds love to eat crumbs and seeds, big birds like to eat small birds and rats.");
        }
        public void Move()
        {
            Console.WriteLine("All birds fly.");
        }
        public void GiveBirth()
        {
            Console.WriteLine("All birds hatch from eggs.");
        }
        public void Greet()
        { }
    }
}
