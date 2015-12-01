using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek3
{
    class Time
    {
        private DateTime time;

        internal Time(DateTime input)
        {
            SaveTime = input;
        }
        internal DateTime SaveTime
            {
            get { return time; }
            set { time = value; }
            }
        public override string ToString()
        {
            string h = time.Hour.ToString();
            string d = time.Day.ToString();
            string y = time.Year.ToString();
            string m = time.Minute.ToString();
            string s = time.Second.ToString();
            string mo = time.Month.ToString();
            string final = h + ":" + m + ":" + s + " " + d + ":" + mo + ":" + y;
            return final;
         }
        internal void PrintTime()
        {
            Time timi = new Time(time);
            Console.WriteLine(timi.ToString());
        }
        public void now()
        {
            DateTime c =  DateTime.Now;    
            Time a = new Time(c);
            Console.WriteLine(a.ToString());   
        }
    }
}
