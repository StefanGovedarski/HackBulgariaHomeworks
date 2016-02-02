using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public Triangle(Point a, Point b, Point c)
        {
            this.Vertex1 = a;
            this.Vertex2 = b;
            this.Vertex3 = c;
        }

        public Point Vertex1 { get; set; }
        public Point Vertex2 { get; set; }
        public Point Vertex3 { get; set; }

        public override int GetArea()
        {
            return (int)((this.Vertex1.X * (Math.Max(this.Vertex2.Y, this.Vertex3.Y) - Math.Min(this.Vertex2.Y, this.Vertex3.Y)))
                + (this.Vertex2.X * (Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Min(this.Vertex1.Y, this.Vertex3.Y)))
                + (this.Vertex3.X * (Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Min(this.Vertex1.Y, this.Vertex2.Y)))) / 2;
        }

        public override int GetPerimeter()
        {
            double first = Math.Sqrt(Math.Pow(Math.Max(this.Vertex1.X, this.Vertex2.X) - Math.Min(this.Vertex1.X, this.Vertex2.X), 2) + Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex2.Y) - Math.Max(this.Vertex1.Y, this.Vertex2.Y), 2));
            double second = Math.Sqrt(Math.Pow(Math.Max(this.Vertex1.X, this.Vertex3.X) - Math.Min(this.Vertex1.X, this.Vertex3.X), 2) + Math.Pow(Math.Max(this.Vertex1.Y, this.Vertex3.Y) - Math.Max(this.Vertex1.Y, this.Vertex3.Y), 2));
            double tirth = Math.Sqrt(Math.Pow(Math.Max(this.Vertex3.X, this.Vertex2.X) - Math.Min(this.Vertex3.X, this.Vertex2.X), 2) + Math.Pow(Math.Max(this.Vertex3.Y, this.Vertex2.Y) - Math.Max(this.Vertex3.Y, this.Vertex2.Y), 2));
            return (int)(first + second + tirth);
        }

        public override string ToString()
        {
            return string.Format("Triangle with Vortex1:{0}, Vortex2:{1}, Vortex3:{2}, Center:{3}, Perimeter:{4:F2} & Area:{5:F2}.", this.Vertex1, this.Vertex2, this.Vertex3, this.GetPerimeter(), this.GetArea());
        }
    }
}
