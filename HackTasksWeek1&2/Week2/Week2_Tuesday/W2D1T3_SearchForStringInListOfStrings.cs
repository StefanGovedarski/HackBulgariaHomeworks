using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week2_Day1_Task3 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Write a method which takes a list of strings as an argument and a string to search for. If any of the strings in the list contains the searched string (as a substring),
the method should return true. Otherwise it should return false. The first index of a string which contains the searched one should be stored in the out parameter.

bool TryFindSubstring(List<string> list, string searched, out foundIndex)");
            List<string> list = new List<string>();
            string s = "";
            int found = 0;
            Console.WriteLine("Input string into the list  , input EXIT when you are done:");
            while (true)
            {
                s = Console.ReadLine();
                if (s == "EXIT")
                {
                    Console.WriteLine("You typed EXIT , Input will be terminated");
                    break;
                }
                else
                {
                    list.Add(s);
                }
                s = "";
            }
            Console.WriteLine("Now input the string you want to search for : ");
            string search = Console.ReadLine();
            Console.WriteLine(TryFindSubstring(list, search, out found));
            Console.WriteLine(found);
        }
        bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            bool check = false;
            foundIndex = 1234;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Contains(searched))
                {
                    check = true;
                    for (int j = 0; j < list[i].Length; j++)
                    {
                        if (list[i][j] == searched[0])
                        {
                            foundIndex = j;
                        }
                    }
                }
            }
            return check ;
        }



    }
}    

