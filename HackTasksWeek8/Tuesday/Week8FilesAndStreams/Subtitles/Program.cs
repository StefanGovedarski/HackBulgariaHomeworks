using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Subtitles
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathname = @"../../lost.s04e11.hdtv.xvid-2hd.srt";
            List<Byte[]> byteArray = new List<byte[]>();

            string line = string.Empty;
            using (StreamReader sr = new StreamReader(@"..\..\lost.s04e11.hdtv.xvid-2hd.srt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    byteArray.Add(Encoding.GetEncoding("windows-1251").GetBytes(line));
                }
            }

            using (StreamWriter sw = new StreamWriter("lost.s04e11.hdtv.xvid-2hd-UTF8.srt"))
            {
                foreach (var byteData in byteArray)
                {
                    sw.WriteLine(Encoding.UTF8.GetString(byteData));
                }
            }

        }
    }
}
