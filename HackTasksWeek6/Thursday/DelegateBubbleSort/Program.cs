using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateBubbleSort
{
    class Program
    {
        public delegate bool SortingDelegate(int a,int b);

        static void Main(string[] args)
        {
            List<int> unsorted = CreateCollection();
            DisplayCollection(unsorted);
            List<int> sorted = SortCollection(unsorted, SortedCheck);
            Console.WriteLine("sorted");
            DisplayCollection(sorted);

        }
        static List<int> CreateCollection()
        {
            List<int> integerCollection = new List<int>();
            int[] arr = new int[5];
            Random rand = new Random(1);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                integerCollection.Add(arr[i]);
            }
            return integerCollection;
        }


        static void DisplayCollection(List<int> list)
        {
            foreach (var el in list)
            {
                Console.WriteLine(el);
            }
        }
        static List<int> SortCollection(List<int> original,SortingDelegate sortingDelegate)
        {
            List<int> SortedList = original;
            for(int i=0;i<SortedList.Count - 1;i++)
            {
                if(sortingDelegate(SortedList[i],SortedList[i+1])==false)
                {
                    int swap = SortedList[i + 1];
                    SortedList[i + 1] = SortedList[i];
                    SortedList[i] = swap;
                }

            }
            return SortedList;
        }
            static bool SortedCheck (int num1,int num2)
        {
            bool AreNum1Num2Sorted = false;
            if (num1 <= num2)
            {
                AreNum1Num2Sorted = true;
            }
            return AreNum1Num2Sorted;
        }
    }
}
