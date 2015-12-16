using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDequeueClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDequeue<string> deq = new GenericDequeue<string>();
            deq.AddToFront("ssg13");
            string[] s = new string[] {"purvi","vtori","treti","chetvurtu","petiii" };
            for(int i=0;i<s.Length;i++)
            {
                deq.AddToFront(s[i]);
            }
            Console.WriteLine(deq.PeekFromBack());
            Console.WriteLine(deq.PeekFromFront());
            deq.Contains("purvi");
            deq.RemoveFromBack();
            Console.WriteLine(deq.PeekFromBack());
        }
    }
}
