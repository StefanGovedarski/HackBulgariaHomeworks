using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class Vector
    {

        private List<Point> vector;
        private Point vectorDimension;

        public Vector(params Point[] listOfCoordinates)
        {
            foreach(Point coord in listOfCoordinates)
            {
                vector.Add(coord);
            }
        }
        public Vector(Vector vec)
        {
            for(int i=0;i<vec.vector.Count;i++)
            {
                vector.Add(vec.vector[i]);
            }
        }
        public Point this[int index]
        {
            get { return vector[index]; }
            set { vector[index] = value; }
        }
        public Point VectorDimension
        {
            get {return vectorDimension; }
            set {this.vectorDimension = this.vector[0]; }
        }
        public int VectorLenght()
        {
            int len = 0;
            foreach(Point a in vector)
            {
                len++;
            }
            return len;
        }
        public override bool Equals(object obj)
        {
            bool check = false;
            if (obj is Vector && this is Vector)
            {
                Vector p1 = this;
                Vector p2 = (Vector)obj;
                int counter = 0;
                for(int i=0; i < p1.vector.Count; i++)
                {
                    if(p1[i] == p2[i])
                    {
                        counter++;
                    }
                }
                if(p1.vector.Count== counter && p2.vector.Count == counter)
                {
                    check = true;
                }
            }

            return check;
        }
        public override string ToString()
        {
            string s = "The vector is " + vectorDimension + "dimensions and it begins at " + vector[0];
            return s;
        }
        // define operators == and !=
        public static bool operator ==(Vector a, Vector b)
        {
            bool result = false;
            int counter = 0;
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null && (object)b != null) || ((object)a != null && (object)b == null))
            {
                return false;
            }
            for (int i = 0; i < a.vector.Count; i++)
            {
                if (a[i] == b[i])
                {
                    counter++;
                }
            }
            if (a.vector.Count == counter && a.vector.Count == counter)
            {
                result = true;
            }

            return result;
        }
        public static bool operator !=(Vector a, Vector b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                foreach (var el in vector)
                {
                    hash = hash * 23 + el.x.GetHashCode();
                    hash = hash * 23 + el.y.GetHashCode();
                }
                return hash;
            }
        }
        //define operators +, - between vectors (check if the 2 vectors have the same dimension!)
        //defining + 
        public static Vector operator  +(Vector a,Vector b)
        {
            if(a.vectorDimension != b.vectorDimension && a.VectorLenght() != b.VectorLenght())
            {
                throw new Exception("The vectors must be from the same dimension!");
            }
            LineSegment line = new LineSegment(a.vector[a.vector.Count - 1], (b.vector[b.vector.Count - 1]));
            int newVecLen = (int)line.GetLenght(line);
            Point[] PointArrayForConstructor = new Point[newVecLen];
            if(a.vector[0].x == b.vector[0].x && a.vector[0].y > b.vector[0].y )
            {
                for(int i=0,y=a.vector[0].y;i<newVecLen;i++,y--)
                {
                    PointArrayForConstructor[i] =  new Point(a.vector[0].x, y);
                }
            }
            if (a.vector[0].x == b.vector[0].x && a.vector[0].y < b.vector[0].y)
            {
                for (int i = 0, y = a.vector[0].y; i < newVecLen; i++, y++)
                {
                    PointArrayForConstructor[i] = new Point(a.vector[0].x, y);
                }
            }
            if (a.vector[0].y == b.vector[0].y && a.vector[0].x > b.vector[0].x)
            {
                for (int i = 0, x = a.vector[0].x; i < newVecLen; i++, x--)
                {
                    PointArrayForConstructor[i] = new Point(x,a.vector[0].y);
                }
            }
            if (a.vector[0].y == b.vector[0].y && a.vector[0].x < b.vector[0].x)
            {
                for (int i = 0, x = a.vector[0].x; i < newVecLen; i++, x++)
                {
                    PointArrayForConstructor[i] = new Point(x, a.vector[0].y);
                }
            }
            Vector newbie = new Vector(PointArrayForConstructor);
            return newbie;
        }
        //defining - will be almost the same except the vector will be reversed
        public static Vector operator -(Vector a, Vector b)
        {
            Vector newbie = a + b;
            newbie.vector.Reverse();
            return newbie;
        }
        //define operators +, -, *, / between a vector and a scalar
        public static Vector operator + (Vector a, int b)
        {
            int aLen = a.VectorLenght();
            Point[] newVecArrayForConstructor = new Point[aLen];
            for(int i=0; i < aLen; i++)
            {
                Point point = new Point(a.vector[i].x + b, a.vector[i].y + b);
                newVecArrayForConstructor[i] = point;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator -(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            Point[] newVecArrayForConstructor = new Point[aLen];
            for (int i = 0; i < aLen; i++)
            {
                Point point = new Point(a.vector[i].x - b, a.vector[i].y - b);
                newVecArrayForConstructor[i] = point;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator *(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            Point[] newVecArrayForConstructor = new Point[aLen];
            for (int i = 0; i < aLen; i++)
            {
                Point point = new Point(a.vector[i].x * b, a.vector[i].y * b);
                newVecArrayForConstructor[i] = point;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator /(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            Point[] newVecArrayForConstructor = new Point[aLen];
            for (int i = 0; i < aLen; i++)
            {
                Point point = new Point(a.vector[i].x / b, a.vector[i].y / b);
                newVecArrayForConstructor[i] = point;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }

        //define operator * - the dot product of 2 vectors (check if the 2 vectors have the same dimension!)
        //will use the old school formula a.b=ax*bx+ay*by since im not really sure what else to do...

        public static int operator * (Vector a ,Vector b)
        {
            int dotProduct = 0;
            int aX = (a.vector[a.vector.Count - 1].x - a.vector[0].x);
            if (aX < 0)
                aX *= -1;
            int bX = (b.vector[b.vector.Count - 1].x - b.vector[0].x);
            if (bX < 0)
                bX *= -1;
            int aY = (a.vector[a.vector.Count - 1].y - a.vector[0].y);
            if (aY < 0)
                aY *= -1;
            int bY = (b.vector[b.vector.Count - 1].y - b.vector[0].y);
            if (bY < 0)
                bY *= -1;
            dotProduct = (aX*bX) + (aY*bY);
            return dotProduct;
        }

    }
}
