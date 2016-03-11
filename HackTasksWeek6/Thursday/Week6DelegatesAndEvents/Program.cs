using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6DelegatesAndEvents
{
    public delegate bool FilterDelegate<T>(T item);
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 3, 4, 5, 6, 8, 9, 12, 13, 14, 15 };
            List<int> result = Filter(ListCreate(arr), IsOdd);
            foreach(int el in result)
            {
                Console.WriteLine(el);
            }
        }

        static List<T> ListCreate<T>(params T[] a )
        {
            List<T> list = new List<T>();
            for(int i=0;i<a.Length;i++)
            {
                list.Add(a[i]);
            }
            return list;
        }

        static List<T> Filter<T>(List<T> list,FilterDelegate<T> delegat)
        {
            List<T> output = new List<T>();
            foreach(T el in list)
            {
                if(delegat(el))
                {
                    output.Add(el);
                }
            }
            return output;
        }
        static bool IsOdd(int x)
        {
            if (Int32.TryParse("parsing successful",out x))
                return x % 2 == 1;
            else
                return false;
        }
    }
}
