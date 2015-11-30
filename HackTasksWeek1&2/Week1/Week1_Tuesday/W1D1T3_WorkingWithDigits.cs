using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task3 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("This programs counts and sums the digits of an input integer/n/n");
            Console.WriteLine("Input your number");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine(countDigits(number));
            Console.WriteLine(sumDigits(number));
        }
        static int countDigits(int b)
        {
            int count = 0;
            string s = b.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                count++;
            }
            return count;
        }
        static int sumDigits(int b)
        {
            int sum = 0;
            string s = b.ToString();
            for (int i = s.Length - 1; i > 0; i--)
            {
                sum = sum + s[i];
            }
            return sum;
        }
    }
}
