using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day2_Task6 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine("Week1 Day2 Task6 - To Decode a URL \n\n");
            Console.WriteLine("The function must follow these rules of decoding\n%20=>' ' %3A=>':' %3D=>'?' %2F=>'/'");
            Console.WriteLine("Here is an example coded string ");
            string coded = "'kitten%20pic.jpg'";
            Console.WriteLine(coded + "\nAnd here it is when its decoded:\n" + DecodeURL(coded));
            Console.WriteLine("IT WORKS!\nNow you input and try with your own coded message:");
            string coded2 = Console.ReadLine();
            Console.WriteLine("The result is: \n" + DecodeURL(coded2));

        }
        string DecodeURL(string input)
        {
            string a = "%20";
            string aSolution = " ";
            string b = "%3A";
            string bSolution = ":";
            string c = "%2f";
            string cSolution = "/";
            StringBuilder decoded = new StringBuilder();
            decoded.Append(input);
            decoded.Replace(a, aSolution);
            decoded.Replace(b, bSolution);
            decoded.Replace(c, cSolution);
            return decoded.ToString();
        }
    }
}
