using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Fish : Animals
    {
        public void Eat()
        {
            Console.WriteLine("small fish eat seaweed or micro-organisms.Big fish eat small fish(or alot of micro-organisms and seaweed).");
        }
        public void Move()
        {
            Console.WriteLine("All fish swim.");
        }
        public void GiveBirth()
        {
            Console.WriteLine("Almost all fish harch from eggs.A few give birth like the mammals.");
        } 
        public void Greet()
        {

        }
    }
}
