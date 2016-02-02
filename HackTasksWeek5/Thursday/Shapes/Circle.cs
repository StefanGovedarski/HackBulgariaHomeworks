using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Ellipse
    {
        public Circle(int axis) : base(axis,axis)
        {
            if(this.SemiAxisY>SemiAxisX)
            {
                SemiAxisX = SemiAxisY;
            }
            else
            {
                SemiAxisY = SemiAxisX;
            }
            this.Radius = axis;
        }
        public int Radius { get; set; }

        public override int GetArea()
        {
            return (int)(Math.PI * this.Radius * this.Radius);
        }

        public override int GetPerimeter()
        {
            return (int)(2*Math.PI*this.Radius);
        }

        public override string ToString()
        {
            return string.Format("A circle with  a radius: {0} , an area of {1} , a perimeter of {1}",this.Radius,this.GetArea(),this.GetPerimeter());
        }

    }
}
