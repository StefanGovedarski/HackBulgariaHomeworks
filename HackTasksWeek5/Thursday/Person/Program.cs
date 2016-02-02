using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program : Person
    {
        static void Main(string[] args)
        {
            Adult adult1 = new Adult("male");
            Adult adult2 = new Adult("female");
            Console.WriteLine(adult1.IsThisAdultBoring(adult1));
            Console.WriteLine(adult2.IsThisAdultBoring(adult2));
            Child child =  adult1.HaveAChild(adult1, adult2);
            child.CreateToy(10, "green");
            child.DoStuff();
            adult1.DoStuff();

        }
    }
}
