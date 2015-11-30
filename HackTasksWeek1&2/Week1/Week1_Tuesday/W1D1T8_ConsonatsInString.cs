using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task8 : HackBgExecutable
    {
        private const string consonants = "bcdfghjklmnpqrstvwxz";
        public void Execute()
        {
            Console.WriteLine("This programs counts the consonants in a given string\n\n");
            Console.WriteLine("Enter your string:");
            string input = Console.ReadLine();
            Console.WriteLine("The number of consonants in a string is : " + CountConsonants(input));
        }
        int CountConsonants(string input)
        {
            int ConsonantCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < consonants.Length; j++)
                {
                    if (input[i] == consonants[j])
                    {
                        ConsonantCount++;
                    }
                }
            }
            return ConsonantCount;
        }
    }
}
