using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLclassBuild;

namespace XMLConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathname = "D://test.txt";
            XML xmltext = new XML(pathname);
            xmltext.OpenTag("lel");
            xmltext.AddAtribute("woof?", "woofwoof");
            xmltext.CloseTag();
            xmltext.OpenTag("abv");
            xmltext.OpenTag("abvg");
            xmltext.Finish();
        }
    }
}
