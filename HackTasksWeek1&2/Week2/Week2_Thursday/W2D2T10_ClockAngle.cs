using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day2_Task11 : HackBgExecutable
    {
        public void Execute()
        {
            /*Write a method which calculates the angle (degree) between clock hour and minute hands.
int GetClockHandsAngle(DateTime time)
1) Calculate the angle if you consider that the hour hand points to exact hour (when the time is 4:34 then the hour hand points exactly to 4 o'clock)
2) Calculate the angle if the hour hand points doesn't point exactly to the number (when the time is 4:30 then the hour hand points to the middle between 4 and 5 o'clock)
Example : the angle is 90 degrees at 3:00, 15:00, 9:00 and 21:00
Hint : Use Math library*/
            Console.WriteLine("the angle right now is {0} degrees" , GetClockHandsAngle(DateTime.Now) );
        }
        public int GetClockHandsAngle(DateTime time)
        {
            double angle = 0;
            double hourAngle = 0.5d * (time.Hour * 60 + time.Minute);
            double minuteAngle =6 * time.Minute;
            angle = Math.Abs(hourAngle - minuteAngle);
            angle = Math.Min(angle, 360 - angle);
            return (int)angle;
        }

    }
}
