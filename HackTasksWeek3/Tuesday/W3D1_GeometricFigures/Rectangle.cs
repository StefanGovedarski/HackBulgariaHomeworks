using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class Rectangle
    {
        private Point corner1;
        private Point corner2;
        private Point corner3;
        private Point corner4;
        private LineSegment lineone;
        private LineSegment linetwo;
        private LineSegment linethree;
        private LineSegment linefour;

        public Rectangle(Point a , Point b)
        {
            if(a.x == b.x || a.y == b.y)
            {
                throw new ArgumentException ("The points cannot be on the same axis , they must be oposite corners in the rectangle");
            }
            else
            {
                corner1 = a;
                corner2 = b;
                int ax = a.x;
                int bx = b.x;
                int ay = a.y;
                int by = b.y;
                Point br = new Point(ax, by);
                corner3 = br;
                Point br2 = new Point(ay, bx);
                corner4 = br2;
                LineSegment l1 = new LineSegment(corner1,corner4);
                LineSegment l2 = new LineSegment(corner1, corner3);
                LineSegment l3 = new LineSegment(corner2, corner3);
                LineSegment l4 = new LineSegment(corner2, corner4);
                lineone = l1;
                linetwo = l2;
                linethree = l3;
                linefour = l4;
            }
        }
        public Rectangle(Rectangle a)
        {
            corner1 = a.corner1;
            corner2 = a.corner2;
        }
        public Point cornerOne
        {
            get { return corner1 ; }
        }
        public Point cornerTwo
        {
            get { return corner2; }
        }
        public Point cornerThree
        {
            get { return corner3; }
        }
        public Point cornerFour
        {
            get { return corner4; }
        }
        public LineSegment lineOne
        {
            get {return lineone; }
        }
        public LineSegment lineTwo
        {
            get { return linetwo; }
        }
        public LineSegment lineThree
        {
            get { return linethree; }
        }
        public LineSegment lineFour
        {
            get { return linefour; }
        }
        public LineSegment Height
        {
            get { return linetwo; }
        }
        public LineSegment Width
        {
            get { return lineone; }
        }
        public KeyValuePair<float,float> RectangleCenter
        {
            get { return GetRectangleCenter(lineone, linetwo); }
        }


        private KeyValuePair<float,float> GetRectangleCenter(LineSegment a , LineSegment b)
        {
            float one = (float)(a.GetLenght(a) / 2);
            float two = (float)(b.GetLenght(b)/2);
            KeyValuePair<float, float> kvp = new KeyValuePair<float, float>(one,two);
            return kvp;
        }
        //Override Equals()
        public override bool Equals(object obj)
        {
            bool eq = false;
            if (obj is Rectangle && this is Rectangle)
            {
                Rectangle p1 = this;
                Rectangle p2 = (Rectangle)obj;
                if (p1.corner1 == p2.corner1 && p1.corner2 == p2.corner2 && p1.corner3 == p2.corner3 && p1.corner4 == p2.corner4 )
                {
                    eq = true;
                }
            }
            return eq;
        }
        public static bool operator ==(Rectangle a, Rectangle b)
        {
            bool result = false;
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null && (object)b != null) || ((object)a != null && (object)b == null))
            {
                return false;
            }
            if (a.corner1 == b.corner1 && a.corner2 == b.corner2 && a.corner3 == b.corner3 && a.corner4 == b.corner4 )
            {
                result = true;
            }

            return result;
        }
        public static bool operator !=(Rectangle a, Rectangle b)
        {
            return !(a == b);
        }


        //Override ToString(): Rectangle[(x,y), (height,width)]
        public override string ToString()
        {
            string s = "[(" + corner1.ToString() + "," + corner2.ToString() + "),(" + linetwo + "," + lineone + ")]";
            return s;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + corner1.GetHashCode();
                hash = hash * 23 + corner2.GetHashCode();
                return hash;
            }
        }
    }
}
