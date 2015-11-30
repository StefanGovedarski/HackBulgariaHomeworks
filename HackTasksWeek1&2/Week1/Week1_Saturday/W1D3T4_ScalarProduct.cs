using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task4 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Maximal Scalar Product

Implement the following function:
int MaxScalarProduct(List<int> v1, List<int> v2).
You are given two vectors - v1 and v2. A scalar product of two vectors is the following:
v1 = {a1, a2, ..., an}
v2 = {b1, b2, ..., bn}
The scalar product is written as:
v1 . v2 = a1 * b1 + a2 * b2 + ... + an * bn
");
            List<int> list1 = new List<int>() { 11,1,5,7};
            List<int> list2 = new List<int>() { 3, 11, 9, 5 };
            list1.Sort();
            list2.Sort();
            int sum = 0;
            for(int i=0; i<list1.Count; i++)
            {
                sum = list1[i] * list2[i];
            }
            Console.WriteLine(sum);
            







        }
    }

}
