using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task1 : HackBgExecutable
    {
        public void Execute()
        {
            int number = 5;
            int fac = 1;
            for (int i = number; i > 0; i--)
            {
                fac = fac * i;
            }
            Console.WriteLine(fac);
        }
    }
}
