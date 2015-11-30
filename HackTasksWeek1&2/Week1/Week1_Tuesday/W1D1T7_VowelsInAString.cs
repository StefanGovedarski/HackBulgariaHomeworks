using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task7 : HackBgExecutable
    {
        private const string vowels = "aeyuio";

        public void Execute()
        {
            Console.WriteLine("This programs counts the vowels in a given string\n\n");
            Console.WriteLine("Enter your string:");
            string input = Console.ReadLine();
            Console.WriteLine("The number of vowels in a string is : " + CountVowels(input));

        }
        int CountVowels(string input)
        {
            int VowelCount = 0;
            for(int i=0;i<input.Length;i++)
            {
                for(int j=0;j<vowels.Length;j++)
                {
                    if(input[i]==vowels[j])
                    {
                        VowelCount++;
                    }
                }
            }
            return VowelCount;
        }
    }
}
