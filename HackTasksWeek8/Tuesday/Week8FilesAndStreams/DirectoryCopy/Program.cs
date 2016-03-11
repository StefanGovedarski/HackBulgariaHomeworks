using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathname = @"C:\Users\MixD\Desktop\GitRepos\HackBulgariaHomeworks\HackTasksWeek8\Tuesday\Week8FilesAndStreams";
            string location = @"D:\test";
            DirCopy(pathname, location);
        }
        static void DirCopy(string pathnameTarget , string pathnameLocation)
        {
            DirectoryInfo dirTarget = new DirectoryInfo(pathnameTarget);
            DirectoryInfo dirLocation = new DirectoryInfo(pathnameTarget);
            Directory.CreateDirectory(pathnameLocation);
            DirectoryInfo[] subDirs = dirTarget.GetDirectories();
            foreach(var dire in subDirs)
            {
                dirLocation.CreateSubdirectory(pathnameLocation);
                FileInfo[] files = dire.GetFiles();
                foreach(var file in files)
                {
                    file.CopyTo(pathnameLocation);
                }
            }
        }
    }
}
