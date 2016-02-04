using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
 
namespace HackWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            string TextFilePathName = "H://samplefile/text.tet";

            if (!(File.Exists(TextFilePathName)))
            {
                try {
                    File.Create(TextFilePathName);
                }
                catch
                {
                    throw new DirectoryNotFoundException("file ladada");
                }
            }
        }
    }
}
