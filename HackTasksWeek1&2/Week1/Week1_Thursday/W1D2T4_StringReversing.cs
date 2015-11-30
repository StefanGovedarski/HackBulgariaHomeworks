using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task4 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week1 Day2 Task 4\nTask about creating a method that reverses a string and \n a method that reverses every word in a sentence\n\n");
            Console.WriteLine("Input the string you want to reverse. \nIf your sting contains an empty space atleast once its considered a sentence");
            bool cool = true;
            string input = Console.ReadLine();
            for(int i=0;i<input.Length;i++)
            {
                if(input[i]==' ')
                {
                    Console.WriteLine(ReverseSentence(input));
                    cool = false;
                    break;
                }
            }
            if(cool)
            {
                Console.WriteLine(ReverseMe(input));
            }


        }
        public string ReverseMe(string s)
        {
            char[] reverse = s.ToCharArray();
            Array.Reverse(reverse);
            return new string(reverse);
        }
        public string ReverseSentence(string s)
        {
            string[] wordsInSentence = s.Split(' ');
            string final = "";
            for(int i=0;i<wordsInSentence.Length; i++)
            {
                ReverseMe(wordsInSentence[i]);
            }
            for(int i=0;i<wordsInSentence.Length;i++)
            {
                final += wordsInSentence[i] + " ";
            }
           
            return ReverseMe(final);
        }
    }
}
