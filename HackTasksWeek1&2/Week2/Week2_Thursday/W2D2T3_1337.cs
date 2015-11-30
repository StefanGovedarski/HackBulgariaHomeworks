using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task3 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"When the clock hits 13:37 on December 21st, this is a special time for hackers.
Write a method which prints how many days, hours, and minutes remain until the next such time comes.

void HackerTime()
The result should be printed on the console in the format dd:hh:mm");
            HackerTime();

        }
        void HackerTime()
        {
            DateTime hackTime = new DateTime(2015, 12, 21, 13, 37,00);
            DateTime now = new DateTime();
            now = DateTime.Now;
            TimeSpan timeLeft= new TimeSpan();
            if (now <= hackTime)
            {
                timeLeft = (hackTime - now);
            }
            else
                hackTime = hackTime.AddYears(1);
            Console.WriteLine(timeLeft.ToString(@"dd\:hh\:mm"));

        }
    }
}
