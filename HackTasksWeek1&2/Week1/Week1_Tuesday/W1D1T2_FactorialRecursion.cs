using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class W1D1T2_FactorialRecursion : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(Factoriel(5));
        }
        int Factoriel(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
                return a * Factoriel(a - 1);
        }
    }
}
