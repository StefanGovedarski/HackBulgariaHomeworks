using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> stack = new GenericStack<int>();
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            int[] array = new int[] { 1, 3, 5, 6, 7, 8, 9, 11, 13 };
            for(int i=0;i<array.Length;i++)
            {
                stack.Push(array[i]);
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Contains(8));
            stack.Clear();
            Console.WriteLine(stack.Pop());
        }
    }
}
