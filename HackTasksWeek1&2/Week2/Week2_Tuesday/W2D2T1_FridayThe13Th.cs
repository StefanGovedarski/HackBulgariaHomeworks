using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task1 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Friday the 13th

Write a method which given a year range, returns how many Fridays 13ths there are in that range

int UnfortunateFridays(int startYear, int endYear)");
            Console.WriteLine("Input the starting year:");
            int start = Int32.Parse( Console.ReadLine());
            Console.WriteLine("Input the ending year:");
            int end = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("The number of unfortunate fridays in the period {0} - {1} is {2} ...FYI the ending year is not included in the count",start,end,UnfortunateFridays(start,end));

        }
        int UnfortunateFridays(int startYear , int endYear)
        {
            int fridays=0;
            DateTime begin = new DateTime(startYear, 1, 1);
            DateTime end = new DateTime(endYear, 1, 1);
            while(begin<=end)
            {
                if(begin.DayOfWeek == DayOfWeek.Friday && begin.Day == 13 )
                {
                    fridays++;
                }
                begin = begin.AddDays(1);
            }

            return fridays;
        }

    }
}
