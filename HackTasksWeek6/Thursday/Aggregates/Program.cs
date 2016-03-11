using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregates
{
    class Program
    {
        public delegate decimal AggregationDelegate(List<int> item);


        static void Main(string[] args)
        {
            List<int> original = CreateCollection();
            DisplayCollection(original);
            decimal final = AggregateCollection(original, Sum);
            Console.WriteLine(final);

        }


        static List<int> CreateCollection()
        {
            List<int> integerCollection = new List<int>();
            int[] arr = new int[5];
            Random rand = new Random(1);
            for(int i =0;i<arr.Length;i++)
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
            foreach(var el in list)
            {
                Console.WriteLine(el);
            }
        }

        static decimal AggregateCollection(List<int> original , AggregationDelegate aggregate)
        {
        decimal answer = aggregate(original);
        return answer;
        }

      
        static decimal Sum(List<int> input)
        {
            decimal answer = 0;
            foreach(var el in input)
            {
                answer += el;
            }
            return answer;
        }
        static decimal Product(List<int> input)
        {
            decimal answer = 1;
            foreach (var el in input)
            {
                answer *= el;
            }
            return answer;
        }
        static decimal Average(List<int> input)
        {
            decimal answer =(decimal)input.Average();
            return answer;
        }
        static decimal Max(List<int> input)
        {
            decimal answer = input.Max();
            return answer;
        }
        static decimal Min(List<int> input)
        {
            decimal answer = input.Min();
            return answer;
        }
    }
}
