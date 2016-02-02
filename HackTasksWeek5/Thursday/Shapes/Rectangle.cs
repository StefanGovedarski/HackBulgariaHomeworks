using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(int a, int b , Point center)
        {
            this.Height = a;
            this.Width = b;
            this.Center = center;
        }
        public Rectangle(int a, int b)
        {
            this.Height = a;
            this.Width = b;
            this.Center = new Point(0,0);
        }

        public int Height { get; set; }
        public int Width { get; set; }
        public new Point Center { get; set; }

        public override int GetPerimeter()
        {
            int perimeter = 2 * (this.Height + this.Width);
            return perimeter;
        }

        public override int GetArea()
        {
            int area = this.Height * this.Width;
            return area;
        }

        public override string ToString()
        {
            return string.Format("A rectangle with height: {0} , width: {1} , perimeter: {2} , area: {3} , and a center in {4}",this.Height,this.Width,this.GetPerimeter(),this.GetType(),this.Center);
        }
    }
}
