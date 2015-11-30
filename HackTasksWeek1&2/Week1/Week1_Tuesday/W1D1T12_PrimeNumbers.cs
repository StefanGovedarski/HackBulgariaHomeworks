using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task12 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"The usual deal:

    Check if number is prime -> IsPrime(n)
    List the first n prime numbers -> ListFirstPrimes(n)
    List the first n prime numbers, using the Sieve of Eratosthenes\n\n");
            Console.WriteLine("Check this number if it is prime:");
            int m = Int32.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(m));
            Console.Write("List the first N prime numbers - n:");
            int n = Int32.Parse(Console.ReadLine());
            ListFirstPrimes(n);
            Console.WriteLine("Now with the sieve of eratosthenes");
            Console.WriteLine("This will only show (maybe)prime numbers below 999");
            ListFirstPrimesWithSieve(n);
        }

        bool IsPrime(int n)
        {
            bool isprime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return isprime;

        }
        void ListFirstPrimes(int n)
        {
            List<int> list = new List<int>();
            int i = 1;
            int br = 1;
            while (br <= n)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                    br++;
                }
                i++;
            }

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
       void ListFirstPrimesWithSieve(int n)
        {
            List<int> list = new List<int>();
            int br = 0;
            for (int i = 1; i < 999; i++)
            {
                if (IsPrime(i) == false)
                {
                    list.Add(0);
                }
                else
                {
                    list.Add(i);
                    br++;
                }
                if(br == n)
                {
                    break;
                }
            }
    
                foreach (var el in list)
                {
                Console.WriteLine(el);
                }
        }
    }
}
