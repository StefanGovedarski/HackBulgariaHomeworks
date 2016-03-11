using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Simple_File_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuOptions = new string[] { "1", "2", "3", "4","5" };
            bool flag = true;
            string current = "";
            string pathname = "";
            while(flag)
            {
                Console.WriteLine("Please insert file location:");
                pathname = System.Console.ReadLine();
                if (!(File.Exists(pathname)))
                {
                    File.Create(pathname);
                    flag = false;
                }
                else
                {
                    flag = false;
                }
            }
            string pathsave = pathname;
            flag = true;
            while(flag)
            {
                Commands();
                current = System.Console.ReadLine();
                if(current == "1")
                {
                    Console.WriteLine("Listing files contents");
                    List(pathsave);
                }
                else if(current == "2")
                {
                    Console.WriteLine("Clearing file contents");
                    Clear(pathsave);
                }
                else if(current == "3")
                {
                    AppendLine(pathsave);
                }
                else if(current == "4")
                {
                    AppendText(pathsave);
                }
                else if(current == "5")
                {
                    LineCount(pathsave);
                }
                else if(current == "Exit")
                {
                    Console.WriteLine("Exiting...");
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Invalid input(type 1,2,3,4,5 or Exit)");
                }
                Console.WriteLine(); Console.WriteLine();
            }

        }
        public static void List(string pathname)
        {
            string content = File.ReadAllText(pathname);
            Console.WriteLine(content);
        }
        public static void Clear(string pathname)
        {
            FileInfo file = new FileInfo(pathname);
            string s = file.FullName;
            file.Delete();
            File.Create(s);
        }
        public static void AppendLine(string pathname)
        {
            Console.WriteLine();
            Console.WriteLine("Input the line you want to append:");
            string line = System.Console.ReadLine();
            File.AppendAllText(pathname, line);
        }
        public static void  AppendText(string pathname)
        {
            Console.WriteLine(); Console.WriteLine("Input the text you want to append");
            string line = System.Console.ReadLine();
            File.AppendAllText(pathname, line);
        }
        public static void LineCount(string pathname)
        {
            string[] s = File.ReadAllLines(pathname);
            int n = s.Length;
            Console.WriteLine("The number of lines is : {0}",n);
        }
        public static void Commands()
        {
            Console.WriteLine("Commands of the editor:");
            Console.WriteLine("1) List all contents of the file");
            Console.WriteLine("2) Clear all the contents of the file");
            Console.WriteLine("3) Append a single line to the file");
            Console.WriteLine("4) Append text to the file");
            Console.WriteLine("5) Show the count of the lines in the file");
            Console.WriteLine("Input 1 2 3 4 or 5 to access those");
            Console.WriteLine("Type exit to stop the program");
        }
    }
}
