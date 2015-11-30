using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task4 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("This programs makes a fibonachi sequence using a method");
            Console.WriteLine("which element in the fibonachi series do you want to see the value of:");
            int element = Int32.Parse(Console.ReadLine());
            int el1 = 1;
            int el2 = 1;
            Fibonachii(element, el1, el2);
        }
        void Fibonachii(int a, int el1, int el2)
        {
            int fibo = 0;
            Console.Write(el1.ToString());
            Console.Write(el2.ToString());
            for (int i = 0; i < a; i++)
            {
                fibo = el1 + el2;
                el1 = el2;
                el2 = fibo;
                Console.Write(fibo.ToString());

            }
        }
    }
}
