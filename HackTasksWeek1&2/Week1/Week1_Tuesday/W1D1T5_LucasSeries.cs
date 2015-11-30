using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task5 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("This program makes Lucas sequence\n\n");
            int el1 = 2;
            int el2 = 1;
            Console.WriteLine("Which element in the Lucas series do you want to see? ");
            int nth = Int32.Parse(Console.ReadLine());
            NthLucas(nth, el1, el2);

            Console.WriteLine("How many lucas do you want to print:");
            int print = Int32.Parse(Console.ReadLine());
            FirstNLucas(print, el1, el2);
        }
        static int NthLucas(int number, int e1, int e2)
        {
            int NthElement = 1;
            for (int i = 0; i < number; i++)
            {
                NthElement = e1 + e2;
                e1 = e2;
                e2 = NthElement;
                if (i == number - 1)
                    Console.WriteLine(NthElement);

            }

            return NthElement;
        }
        static void FirstNLucas(int a, int el1, int el2)
        {
            Console.WriteLine(el1);
            Console.WriteLine(el2);
            int luca = 0;
            for (int i = 0; i < a; i++)
            {
                luca = el1 + el2;
                el1 = el2;
                el2 = luca;
                Console.WriteLine(luca);
            }
        }
    }
}
