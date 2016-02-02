using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape : IMovable
    {
        public virtual int GetPerimeter()
        { return -1; }
        public virtual int GetArea()
        { return -1; }

        public Point Center { get; set; }


        public void Move(int x, int y)
        {
            Center.X += x;
            Center.Y += y;
        }
    }
}
