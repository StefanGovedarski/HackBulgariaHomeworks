using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task5 : HackBgExecutable
    {
        public void Execute()
        {
            /*
            https://github.com/HackBulgaria/Programming101-CSharp/tree/master/week02/02%20-%20Methods-Part%20Two
            i naprimer CultureInfo culture = new CultureInfo("bg-BG")
            */
            Console.WriteLine("Input the year:");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the month you want to print out: ");
            int month = Int32.Parse(Console.ReadLine());
            CultureInfo culture = new CultureInfo("en-US");

            PrintCalendar(month, year, culture);
            
        }
        void PrintCalendar(int month , int year , CultureInfo culture)
        {
            DateTime currentMonth = new DateTime(year, month, 1);
            DateTime nextMonth = currentMonth.AddMonths(1);

            Console.WriteLine(currentMonth.ToString("MMMM"));

            for (int i = 0; i < 7; i++)
            {
                Console.Write(currentMonth.ToString("dddd").PadLeft(10));
                currentMonth = currentMonth.AddDays(1);
            }
            Console.WriteLine();

            currentMonth = currentMonth.Subtract(new TimeSpan(7, 0, 0, 0));


            for (; currentMonth < nextMonth; currentMonth = currentMonth.AddDays(1))
            {
                if (currentMonth.Day % 7 == 0)
                {
                    Console.Write(currentMonth.Day.ToString().PadLeft(10));
                    Console.WriteLine();
                }
                else
                    Console.Write(currentMonth.Day.ToString().PadLeft(10));
            }
            Console.WriteLine();

        }
    }
}
