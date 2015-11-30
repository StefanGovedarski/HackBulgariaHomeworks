using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task3 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week 1 Day 2 Task 3\nTask about checking if an input sequence is increasing or decreasing\n\n");




            Console.WriteLine("input the elements into your list:");
            Console.WriteLine("To terminate input enter a non integer value");

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
            foreach (int el in list)
                Console.WriteLine(el);

            Console.WriteLine("lets see if its an increasing sequence");
            Console.WriteLine(isIncreasing(list));
            Console.WriteLine("now lets see if its a decreasing sequence");
            Console.WriteLine(isDecreasing(list));

        }
        public bool isIncreasing(List<int> seq)
        {
            int a = seq.Count;
            if (a == 1)
            {
                Console.WriteLine("The list has only one elements.Surprise surprise");
                return true;
            }
            bool check = true;
            for (int i = 0; i < a - 1; i++)
            {
                if (seq[i] > seq[i + 1])
                {
                    check = false;
                }
            }
            return check;
        }
        public bool isDecreasing(List<int> seq)
        {
            int a = seq.Count;
            if (a == 1)
            {
                Console.WriteLine("The list has only one elements.Surprise surprise");
                return true;
            }
            bool check = true;
            for (int i = 0; i < a - 1; i++)
            {
                if (seq[i] < seq[i + 1])
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
