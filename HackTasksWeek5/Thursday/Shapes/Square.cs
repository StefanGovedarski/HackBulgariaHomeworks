using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {

        public Square(int side) : base(side,side)
        {
            this.Side = side;
            this.Height = side;
            this.Width = side;
        }

        public int Side { get; set; }

        public override int GetArea()
        {
            int area = this.Side * this.Side;
            return area;
        }

        public override int GetPerimeter()
        {
            int perimeter = 4 * (this.Side);
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format("A square with the side {0} , a perimeter  {1} and an area  {2}",this.Side,this.GetPerimeter(),this.GetArea());
        }


    }
}
