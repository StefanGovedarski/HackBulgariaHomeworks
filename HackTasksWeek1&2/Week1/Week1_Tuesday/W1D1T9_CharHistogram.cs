using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day1_Task9 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Implement a funcion, called , which takes a string and returns a dictionary,
where each key is a characterfrom string and its value is the number of occurrences of that char in string/n/n");
            Console.WriteLine("input a string:");
            string input = Console.ReadLine();
            CharHistogram(input);
        }
        void CharHistogram(string input)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int i=0;i<input.Length;i++)
            {
                if(dict.ContainsKey(Convert.ToChar(input[i]))==false)
                {
                    dict.Add(input[i], 1);
                }
                else
                {
                    dict[input[i]]++;
                }
            }
            foreach(KeyValuePair<char,int> kvp in dict)
            {
                Console.WriteLine("{0} : {1}",kvp.Key,kvp.Value);
            }

        }
    }
}
