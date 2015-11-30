using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task2 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Date sums

Find all dates in a given year whose digits of the month number, the digits of the day number
and the digits of the year sum upto a given value. 
Print each of them on the console in the format: dd/mm/yyyy: d+d+m+m+y+y+y+y=sum.

void PrintDatesWithGivenSum(int year, int sum)");
            Console.WriteLine("\n\nInput the year you want to use: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the sum you want to achieve is :");
            int sum = Int32.Parse(Console.ReadLine());
            PrintDatesWithGivenSum(year, sum);

        }
        public static int GetSum(int number)
        {
            int checksum = 0;
            char[] Digits = number.ToString().ToCharArray();
            for (int i = 0; i < Digits.Length; i++)
            {
                checksum += Int32.Parse(Digits[i].ToString());

            }

            return checksum;
        }
        void PrintDatesWithGivenSum(int year, int sum)
        {
            DateTime date = new DateTime(year, 1, 1);
            while (date.Year == year)
            {
                int checksum = GetSum(date.Year) + GetSum(date.Month) + GetSum(date.Day);

                if (sum == checksum)
                {
                    Console.WriteLine(date);
                }

                date = date.AddDays(1);
            }
        }
    }
}
