using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day1_Task4 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Joining strings
Write a method which takes an arbitrary number of strings and joins them using the specified separator.
string JoinStrings(string separator, params string[] strings)");
            Console.WriteLine("\n\n");
            List<string> list = new List<string>();
            string s = "";
            Console.WriteLine("Input strings to join together, the input will terminate if you input EXIT");
            while(true)
            {
                s = Console.ReadLine();
                if(s == "EXIT")
                {
                    Console.WriteLine("terminating Input");
                    break;
                }
                else
                {
                    list.Add(s);
                }

                s = "";
            }

            Console.WriteLine("Input your separator");
            string separator = Console.ReadLine();
            Console.WriteLine(JoinStrings(separator,list ));
        }
        string JoinStrings(string separator, List<string> strings)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strings.Count; i++)
            {
                sb.Append(strings[i]);
                sb.Append(separator);
            }
            return sb.ToString();
        }
    }
}
