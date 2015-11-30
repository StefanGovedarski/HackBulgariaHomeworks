using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task5 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Implement the following function: int MaxSpan(List<int> numbers) where numbers is a list of numbers.
Consider the leftmost and rightmost appearances of some value in the list.
We'll say that the span is the number of elements between the two inclusive. A single value has a span of 1.
Returns the largest span found in the given array.
Examples:
MaxSpan({ 1, 2, 1, 1, 3}) = 4
MaxSpan({ 1, 4, 2, 1, 4, 1, 4}) = 6
MaxSpan({ 1, 4, 2, 1, 4, 4, 4}) = 6
");
            List<int> list = new List<int>() { 1, 2, 3,4, 4, 4, 5, 6, 7, 8, 8, 8, 9, 7, 9};
            Console.WriteLine("The list is : 1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 9, 7, 9");
            Console.WriteLine(MaxSpan(list));
            int max = 0;
            int maxspan = max;
            Console.WriteLine("lets find the longest span");
            foreach(int el in list)
            {
                max = MaxSpan(list, el);
                if(max>maxspan)
                {
                    maxspan = max;
                }
            }
            Console.WriteLine(maxspan);

        }
        int MaxSpan(List<int> numbers)
        {
            int span = 1;
            Console.WriteLine("Input a digit to find and get the span of:");
            int digitToSpanBetween = Int32.Parse(Console.ReadLine());
            int leftAppearence = 0;
            int rightAppearence = 0;
            for(int i=0; i< numbers.Count; i ++)
            {
                if(digitToSpanBetween == numbers[i])
                {
                    leftAppearence = i;
                    break;
                }
            }
            for (int i = numbers.Count -1; i >= 0; i--)
            {
                if (digitToSpanBetween == numbers[i])
                {
                    rightAppearence = i;
                    break;
                }
            }
            if(numbers.Contains(digitToSpanBetween) ==  false)
            {
                Console.WriteLine("this digit does not exist in the list");
            }
            span = rightAppearence - leftAppearence + 1;


            return span;
        }
        int MaxSpan(List<int> numbers , int number)
        {
            int span = 1;
            int leftAppearence = 0;
            int rightAppearence = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (number == numbers[i])
                {
                    leftAppearence = i;
                    break;
                }
            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (number == numbers[i])
                {
                    rightAppearence = i;
                    break;
                }
            }
            if (numbers.Contains(number) == false)
            {
                Console.WriteLine("this digit does not exist in the list");
            }
            Console.WriteLine("Now checking the span for {0}", number);
            span = rightAppearence - leftAppearence + 1;
            Console.WriteLine(span);


            return span;
        }
    }
}
