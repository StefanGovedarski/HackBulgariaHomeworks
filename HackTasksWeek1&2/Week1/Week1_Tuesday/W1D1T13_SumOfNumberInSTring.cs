using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task13 : HackBgExecutable
    {
        public const string digits = "1234567890";
        public void Execute()
        {
            Console.WriteLine(@"You are given a string, where there can be numbers. Return the sum of all numbers in that string (not digits, numbers)");
            Console.WriteLine("input your string");
            string input = Console.ReadLine();
            Console.WriteLine(SumOfNumbersInString(input));

        }
        int SumOfNumbersInString(string input)
        {
            int sum = 0;
            string curr = "";
            for (int i=0;i<input.Length;i++)
            {
                if (IsNumber(input[i]))
                {
                    curr = curr + input[i].ToString();
                }
                else if (!(curr == ""))
                    {
                        sum = sum + Int32.Parse(curr);
                        curr = "";
                    }
                
            }
            if (!(curr == ""))
            {
                sum = sum + Int32.Parse(curr);
                curr = "";
            }
            return sum;
        }
        bool IsNumber(char s)
        {
            if (s == '0' || s == '1' || s == '2' || s == '3' || s == '4' || s == '5' || s == '6' || s == '7' || s == '8' || s == '9')
            {
                return true;
            }
            return false;

        }
    }
}
