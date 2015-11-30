using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task7 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week 1 Day 2 Task 7 \n- To check if one string is an anagrams of other\n(if he has all the character of the first one in any order)\n\n");
            Console.WriteLine("Input the two string you want to compare for anagrams");
            Console.WriteLine("String A:");
            string A = Console.ReadLine();
            Console.WriteLine("String B:");
            string B = Console.ReadLine();
            Console.WriteLine("Are the two strings anagrams ? " + Anagram(A,B));
            Console.WriteLine("Can an anagram of String A can be found in String B." + isAnAnagramOf(A,B));

        }
        bool Anagram(string A, string B)
        {
            int br = 0;
            int len = A.Length;
            for(int i=0;i<A.Length;i++)
            {
                for(int j=0;j<B.Length;j++)
                {
                    if (B[j] == A[i] && A.Length == B.Length)
                        br++;
                }

            }
            if (br == len)
                return true;
            else
                return false;
        }
        bool isAnAnagramOf(string A,string B)
        {
            int br = 0;
            int len = A.Length;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (B[j] == A[i])
                        br++;
                }

            }
            if (br == len)
                return true;
            else
                return false;

        }


    }
}
