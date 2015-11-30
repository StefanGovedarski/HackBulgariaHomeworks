using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task2 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week 1 , Day 2 , Task 2\nExtreme elements in lists with four functions to implement\n\n");
            Console.WriteLine("input the elements into your list:");

            List<int> list = new List<int>();
            while (true)
            {
                string s = Console.ReadLine();
                int a;
                bool check = Int32.TryParse(s, out a);


                if (check)
                {
                    Console.WriteLine("adding element");
                    list.Add(a);
                }
                else
                {
                    Console.WriteLine("thank you for the input,terminating input process");
                    break;
                }
            }
            Console.WriteLine("The minimum element in your list is:");
            Console.WriteLine(Min(list));
            Console.WriteLine("The maximum element in your list is:");
            Console.WriteLine(Max(list));
            Console.WriteLine("input the nth minimum element you want to search for");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NthMin(n, list));
            Console.WriteLine("input the next nth maximum element you want to search for:");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine(NthMax(m, list));


        }


        public int Min(List<int> items)
        {
            items.Sort();
            int a = items[0];

            return a;
        }
        public int Max(List<int> items)
        {
            int a = items.Max();
            return a;
        }
        public int NthMin(int n, List<int> items)
        {
            items.Sort();
            int a = items[n - 1];
            return a;
        }
        public int NthMax(int n, List<int> items)
        {
            items.Sort();
            int a = items.Count;
            int b = items[a - n];
            return b;
        }
    }
}
