using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Pair
{
    class Program
    {
        static void Main(string[] args)
        {
            Pair obj = new Pair(3,4);
            Pair obj2 = new Pair(4,4);
            obj.ToString();


            Console.WriteLine(obj.Equals(obj2));
                
        }
    }
}
