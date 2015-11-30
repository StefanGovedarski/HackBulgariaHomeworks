using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day1_Task1 : HackBgExecutable 
    {
        public void Execute()
        {
            Console.WriteLine(@"Write a method which takes a List as an argument and reverses it internally.

void ReverseList(List<int> list)

The reversed result should be stored inside the same list instance.");
            List<int> list = new List<int>();
            while(true)
            {
                int integer;
                bool check = Int32.TryParse(Console.ReadLine(),out integer);
                if (check)
                {
                    list.Add(integer);
                }
                else
                {
                    Console.WriteLine("Thank you for the input.Terminating input process");
                    break;
                }
            }
            ReverseList(list);


        }
        void ReverseList(List<int> list)
        {
            for(int i=list.Count - 1; i>=0; i --)
            {
                list.Add(list[i]);
            }
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine("List {0} : {1}" ,i ,list[i]);
            }
        }
    }
}
