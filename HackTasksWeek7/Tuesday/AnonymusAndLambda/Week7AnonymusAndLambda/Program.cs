using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7AnonymusAndLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 3, 2, 4, 6, 11, 2, 34, 5, 2, 5, 231, 65, 543, 23, 32, 2, 52, 54, 88 };
            var coll = new AverageAggregator(list);
            coll.AddNumber(11);
            coll.AddNumber(33);
        }
    }
}
