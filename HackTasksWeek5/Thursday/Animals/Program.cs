using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Pigeon pigeon = new Pigeon();
            Dog dog1 = new Dog();
            Cat cat1 = new Cat();
            Dog dog2 = new Dog();
            Chameleon cham = new Chameleon();
            Marlin marl = new Marlin();
            List<Animals> animals = new List<Animals>();
            animals.Add((Animals)pigeon); animals.Add((Animals)dog1); animals.Add((Animals)dog2); animals.Add((Animals)cat1);animals.Add((Animals)cham);
            animals.Add((Animals)marl);
            foreach(Animals animal in animals)
            {
                animal.Eat();
                animal.Greet();
            }
        }
    }
}
