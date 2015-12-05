using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class LineSegment
    {
        private Point point1;
        private Point point2;
        private bool q = true;

        public LineSegment(Point a, Point b)
        {
            if (a.Equals(b))
            {
                throw new ArgumentException("a line segment cannot be zero lenght or below");
                q = false;
            }
            else
            {
                point1 = a;
                point2 = b;
            }
        }
        public LineSegment(LineSegment ls)
        {
            if(q)
            {
                this.point1 = ls.point1;
                this.point2 = ls.point2;  
            }
        }
        public Point StartOfSegment
        {
            get {return point1; }
        }
        public Point EndOfSegment
        {
            get { return point2; }
        }
        public double GetLenght(LineSegment line)
        {
            double len = 0;
            int a, b;
            a = line.point2.x - line.point1.x;
            b = line.point2.x - line.point1.y;
            len = Math.Sqrt(a * a + b * b);
            return len;
        }
        public override string ToString()
        {
            string s = "Line[(" + this.point1.x + "," + this.point1.y + "),(" + this.point2.x + "," + this.point2.y + ")]";
            return s;
        }
        public override bool Equals(object obj)
        {
            bool e = false;
            if(this is LineSegment && obj is LineSegment)
            {
                LineSegment a = this;
                LineSegment b = (LineSegment)obj;
                if(a.point1.x == b.point1.x && a.point1.y == a.point1.y && a.point2.x == b.point2.x && a.point2.y == a.point2.y)
                {
                    e = true;
                }

            }

            return e;
        }

        public static bool operator ==(LineSegment a , LineSegment b)
        {
            bool result = false;
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null && (object)b != null) || ((object)a != null && (object)b == null))
            {
                return false;
            }
            if (a.point1.x == b.point1.x && a.point1.y == b.point1.y&& a.point2.x == b.point2.x && a.point2.y == b.point2.y)
            {
                result = true;
            }
            return result;
        }
        public static bool operator !=(LineSegment a , LineSegment b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + point1.GetHashCode();
                hash = hash * 23 + point2.GetHashCode();
                return hash;
            }
        }
        public static bool operator <(LineSegment a, LineSegment b)
        {
            bool result=false;
            if(a.GetLenght(a) < b.GetLenght(b))
            {
                result = true;
            }
            return result;
        }
        public static bool operator >(LineSegment a, LineSegment b)
        {
            bool result=false;
            if (a.GetLenght(a) > b.GetLenght(b))
            {
                result = true;
            }
            return result;
        }
        public static bool operator >=(LineSegment a, LineSegment b)
        {
            bool result = false;
            if (a.GetLenght(a) <= b.GetLenght(b))
            {
                result = true;
            }
            return result;
        }
        public static bool operator <=(LineSegment a, LineSegment b)
        {
            bool result = false;
            if (a.GetLenght(a) <= b.GetLenght(b))
            {
                result = true;
            }
            return result;
        }
        public static bool operator <(LineSegment a , double b)
        {
            bool result = false;
            if(a.GetLenght(a) < b)
            {
                result = true;
            }
            return result;
        }
        public static bool operator >(LineSegment a, double b)
        {
            bool result = false;
            if (a.GetLenght(a) > b)
            {
                result = true;
            }
            return result;
        }
        public static bool operator >=(LineSegment a, double b)
        {
            bool result = false;
            if (a.GetLenght(a) >= b)
            {
                result = true;
            }
            return result;
        }
        public static bool operator <=(LineSegment a, double b)
        {
            bool result = false;
            if (a.GetLenght(a) <= b)
            {
                result = true;
            }
            return result;
        }

    }
    }
