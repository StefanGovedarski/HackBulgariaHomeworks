using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week16Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            test1 test = new test1();
            test.MyProperty = 1;
            test.MyProperty2 = 1;
            test.MyProperty3 = "da";
            ExtensionMethod.IncrementExtensionMethod(test);
            Console.WriteLine(test.MyProperty);
            Console.WriteLine(test.MyProperty2);
        }
    }
}
