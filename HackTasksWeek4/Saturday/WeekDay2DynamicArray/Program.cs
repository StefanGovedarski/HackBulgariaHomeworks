using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekDay2DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> dyn = new DynamicArray<int>();
            dyn.Add(5);
            dyn.Add(7);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Add(5);
            dyn.Print();
            dyn.RemoveAt(4);
            Console.WriteLine(dyn.Contains(7));
        }
    }
}
