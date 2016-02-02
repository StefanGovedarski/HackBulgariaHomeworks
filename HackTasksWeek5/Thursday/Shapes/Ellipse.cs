using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Ellipse : Shape
    {
        public Ellipse(int axisX , int axisY)
        {
            this.SemiAxisX = axisX;
            this.SemiAxisY = axisY;
            this.Center = new Point(axisX, axisY);
            
        }

        public int SemiAxisX { get; set; }
        public int SemiAxisY { get; set; }
        public new Point Center { get; set; }

        public override int GetArea()
        {
            int area =(int)Math.PI * (SemiAxisX * SemiAxisY);
            return area;
        }

        public override int GetPerimeter()
        {
            int perimeter = (int)(Math.PI * ((3 * (this.SemiAxisX + this.SemiAxisY)) - Math.Sqrt(((3 * this.SemiAxisX) + this.SemiAxisY) * (this.SemiAxisX + (3 * this.SemiAxisY)))));
            return perimeter;
        }

        public override string ToString()
        {
            return string.Format("An ellipse with the X axis:{0} , Y axis: {1} , Perimeter:{2} , Area:{3} , and center in {4}",SemiAxisX,SemiAxisY,this.GetPerimeter(),this.GetArea(),Center);
        }
    }
}
