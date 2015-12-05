using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class Point
    {
        private int X;
        private int Y;
        public static readonly Point zero = new Point(0,0) ;


        public Point(int a,int b)
        {
            X = a;
            Y = b;
        }
        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;

        }
        public int x
        {
            get { return X;}
        }
        public int y
        {
            get { return Y; }
        }

        public override string ToString()
        {
            string s = "Point(" + X + "," + Y + ")";
            return s;
        }
        public override bool Equals(object obj)
        {
            bool eq = false;
            if (obj is Point && this is Point)
            {
                Point p1 = this;
                Point p2 = (Point)obj;
                if (p1.x == p2.x && p1.y == p2.y)
                {
                    eq = true;
                }
            }
            return eq;
        }

        public static bool operator == (Point a , Point b)
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
            if (a.x == b.x && a.y == b.y)
            {
                result = true;
            }

            return result;
        }
        public static bool operator != (Point a,Point b)
        {
            return !(a == b);
        }


        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + x.GetHashCode();
                hash = hash * 23 + y.GetHashCode();
                return hash;
            }
        }
    }
}
