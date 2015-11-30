using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task6 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Implement a function List<int> BirthdayRanges
(List<int> birthdays, List<KeyValuePair<int, int>> ranges)We have a list birthdays and list of ranges.
birthdays - range from 0 to 365, ranges - one range is a pair of two numbers - start and end.");
            //BirthdayRanges( { 1, 2, 3, 4, 5}, { (1, 2), (1, 3), (1, 4), (1, 5), (4, 6)} );
            //{2, 3, 4, 5, 2}
            List<int> BirthD = new List<int>() { 1, 2, 3, 4, 5 };
            List<KeyValuePair<int, int>> ranges = new List<KeyValuePair<int, int>>();
            ranges.Add(new KeyValuePair<int, int>(1, 2));
            ranges.Add(new KeyValuePair<int, int>(1, 3));
            ranges.Add(new KeyValuePair<int, int>(1, 4));
            ranges.Add(new KeyValuePair<int, int>(1, 5));
            ranges.Add(new KeyValuePair<int, int>(4,6));
            List<int> result =  BirthdayRanges(BirthD, ranges);
            for(int i=0; i < result.Count; i++)
            {
                Console.Write(result[i]);
            }
            Console.WriteLine();

        }
        List<int> BirthdayRanges(List<int> birthdays, List<KeyValuePair<int, int>> ranges)
        {
            List<int> results = new List<int>();
            int leftBorded = 0;
            int rightBorded = 0;
            int counter = 0;
            for(int i=0; i<ranges.Count; i ++ )
            {
                leftBorded = ranges[i].Key;
                rightBorded = ranges[i].Value;
                counter = 0;
                for(int j=0; j<birthdays.Count; j ++)
                {
                    if(birthdays[j]>=leftBorded && birthdays[j]<=rightBorded)
                    {
                        counter++;
                    }


                }
                results.Add(counter);
            }

            return results;
        }
    }
}
