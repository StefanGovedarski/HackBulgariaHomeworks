using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task10 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"We denote the Palindrome score of an integer by the following function:
    P(n) = 1, if n is palindrome
    P(n) = 1 + P(s) where s is the sum of n and the reverse of n
Implement a function, called PScore(n), which finds the palindrome score for n.\n\n");
            Console.WriteLine("Input your integer:");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine(PScore(n));
        }
        int PScore(int n)
        {
            int sum = 0;
            if(Palindrome(n))
            {
                return 1;
            }
            else
            {
                sum = n + Reverse(n);
                Console.WriteLine(sum);
                return PScore(sum);
            }
        }
        int Reverse(int n)
        {
            int left = n;
            int rev = 0;
            while(left>0)
            {
                int r = left % 10;
                rev = rev * 10 + r;
                left = (left / 10);
            }
   
            return rev;
        }
        bool Palindrome(int n)
        {
            string original = n.ToString();
            int br = 0;
            for(int i=0,j=original.Length-1;i<original.Length/2;i++ , j-- )
            {
                if(original[i]==original[j])
                {
                    br++;
                }
            }

            if (br == original.Length / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
