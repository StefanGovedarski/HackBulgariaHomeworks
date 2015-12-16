using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgariaWeek4Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair<string> pair1 = new Pair<string>();
            Pair<string> pair2 = new Pair<string>();
            pair1.X = "bla";
            pair2.X = "bla";
            pair1.Y = "be";
            pair2.Y = "be";
            Console.WriteLine(pair1.Equals(pair2));

            Pair<int> pair3 = new Pair<int>(4, 5);
            Pair<int> pair4 = new Pair<int>(3, 6);
            Console.WriteLine(pair3.Equals(pair4));
            Console.WriteLine(pair3);


        }
    }
}
