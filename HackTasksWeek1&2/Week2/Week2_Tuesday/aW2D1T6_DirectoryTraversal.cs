using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week2_Day1_Task6 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"Directory traversal
Write a method which iterates through the contents of a directory and the contents of all its subdirectories.Use the yield operator to return the name of each entry and sub-entry.
IEnumerable < string > IterateDirectory(DirectoryInfo dir)"); Console.WriteLine("\n\n\n");
            DirectoryInfo papka = new DirectoryInfo("../../outputs");
            Console.WriteLine("Does the input folder exist? : " + papka.Exists);
            IterateDirectory(papka);
        }
        IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            List<string> list = new List<string>();
            foreach (var fi in dir.EnumerateDirectories())
            {
                Console.WriteLine(fi.Name);
                list.Add(dir.Name);
            }
            return list;
            

          

        }
    }
}
