using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HackTask
{
    class Week2_Day1_Task2 :HackBgExecutable

    {
        public void Execute()
        {
            Console.WriteLine(@"Write a method which takes a rectangle as an argument and inflates
            it with the specified size in all directions. This means that if you get a rectangle (x:0,y:0,w:10,h:10)
            and inflate it with a size of (2,2), the resulting rectangle should be (x:-2,y:-2,w:14,h:14).
            Use the ref keyword to store the result in the same variable.");
            Rectangle rec = new Rectangle(0,0,14,14);
            Size size = new Size(2, 2);
            Inflate( ref rec, size);

        }
        void Inflate(ref Rectangle rect, Size inflateSize)
        {
            rect.Inflate(inflateSize);
        }
    }
}
