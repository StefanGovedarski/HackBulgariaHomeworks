using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileTarget = @"D:\test.txt";
            string fileLocation = @"D:\test2.txt";
            string content = File.ReadAllText(fileTarget);
            content = content.ToUpper();
            File.WriteAllText(fileLocation, content);
        }
    }
}
