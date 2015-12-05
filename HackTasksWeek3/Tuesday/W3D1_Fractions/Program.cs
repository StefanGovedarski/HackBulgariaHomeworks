using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Fractions
{
    class Program
    {
        static void Main(string[] args)
        {

            Fractions obj = new Fractions(5, 7);
            Fractions obj2 = new Fractions(10, 14);
            Console.WriteLine(obj.Equals(obj2));
            bool eq = (obj == obj2);
            Console.WriteLine(eq);
            Fractions result = obj + obj2;
            Console.WriteLine(result);
            result = obj * obj2;
            Console.WriteLine(result);
            result = obj / obj2;
            Console.WriteLine(result);

        }

    }
}
