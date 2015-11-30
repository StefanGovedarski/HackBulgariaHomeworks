using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task5 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week 1 , Day 2 , Task 5\n This point of this task is to Copy every character K times \n\n");
            Console.WriteLine("Input the string you want to copy the characters of:");
            string input = Console.ReadLine();
            Console.WriteLine("Now input how many time you want to copy those characters");
            int k = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The output looks like this: ");
            Console.WriteLine(CopyEveryChar(input,k));
        }
        public string CopyEveryChar(string input, int k)
        {
            StringBuilder copied = new StringBuilder();
            for(int i=0;i< input.Length;i++)
            {
                for(int j=0;j< k;j++)
                {
                    copied.Append(input[i]);
                }
            }

            
            return copied.ToString();
        }
    }
}
