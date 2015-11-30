using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day1_Task5 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Factorial generator
Write a method which generates all the factorials of the integers up to n.)");
            Console.WriteLine("\n\n");
            Console.WriteLine("Input N:");
            int n = Int32.Parse(Console.ReadLine());
            GenerateFacts(n);
        }
        void GenerateFacts(int n)
        {
            long fact = 1;
            for(int i=1; i <=n; i++)
            {
                for(int j= i;j>0;j--)
                {
                    fact = fact * j;
                }
                Console.WriteLine(fact);
                fact = 1;
            }
        }
    }
}
