using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek3
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime date  = new DateTime(2015,5,30,3,00,00);
            Time time = new Time(date);
            time.PrintTime();
            time.now();
        }
    }
}
