using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week8FilesAndStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> DirectoryNames = new Dictionary<string, int>();
            string pathName = @"C:\Users\MixD\Desktop\GitRepos\HackBulgariaHomeworks\HackTasksWeek8\Tuesday\Week8FilesAndStreams";
            if(Directory.Exists(pathName)== false)
            {
                Console.WriteLine("No such directory");
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(pathName);
                SubdirectoryRecursion(pathName,DirectoryNames);

            }
            foreach(var item in DirectoryNames)
            {
                Console.WriteLine("{0} has {1} occurences" , item.Key, item.Value);
            }

        }
        static Dictionary<string,int> SubdirectoryRecursion(string pathname , Dictionary<string, int> dic)
        {
            DirectoryInfo dir = new DirectoryInfo(pathname);
            DirectoryInfo[] SubdirsinDir = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            foreach(var item in SubdirsinDir)
            {
                foreach (var file in files)
                {
                    if (dic.ContainsKey(file.Name))
                    {
                        dic[file.Name]++;
                    }
                    else
                    {
                        dic.Add(file.Name, 1);
                    }
                }
                SubdirectoryRecursion(item.FullName, dic);
            }
            return dic;
        }
    }
}
