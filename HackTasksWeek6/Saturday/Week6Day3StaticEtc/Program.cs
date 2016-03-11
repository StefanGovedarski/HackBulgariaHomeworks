using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6Day3StaticEtc
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> uno = new List<int>(){1,4,2,3,4};
            List<int> dos = new List<int> { 1, 2, 4, 3, 5,7,7,7,7,7 };
            List<int> finale =  ArrayExtension<int>.Union(uno, dos);
            DisplayList<int>(finale);
            List<string> str = new List<string>() {"srt","rwq"," ewq d","ewqewqd","opi" };
        }
        static void DisplayList<T>(List<T> list)
        {
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
        }
    }
}
