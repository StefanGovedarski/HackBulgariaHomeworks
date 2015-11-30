using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task1 :  HackBgExecutable
    {
        private string taskName = "Task 1 Week 1 Day 2 Task1 : \nList To Number and Number to List: \n\n";
        public void Execute()
        {
            Console.WriteLine(taskName);

            Console.WriteLine("Input your integer you will use to check both functions with:");
            int number = Int32.Parse(Console.ReadLine());
            List<int> list = NumberToList(number);
            Console.WriteLine("purvi metod vru6ta:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }
        public List<int> NumberToList(int n)
        {
            List<int> list = new List<int>();
            string digits = n.ToString();
            for (int i = 0; i < digits.Length; i++)
            {
                int j = Int32.Parse(digits[i].ToString());
                list.Add(j);
            }
            //vtori metod
            Console.WriteLine("vtori metod vru6ta");
            Console.WriteLine(ListToNumber(digits));


            return list;
        }
        public int ListToNumber(string digits)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < digits.Length; i++)
            {
                sb.Append(digits[i]);
            }
            int a = Int32.Parse(sb.ToString());


            return a;
        }




        //drugite metodi ot zada4a 1
    }
}
