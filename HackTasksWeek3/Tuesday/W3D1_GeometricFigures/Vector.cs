using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_GeometricFigures
{
    class Vector
    {

        private List<int> vector;
        private int vectorDimension;

        public Vector(params int[] arrayOfCoordinates)
        {
            this.vector = new List<int>();
            for(int i =0;i < arrayOfCoordinates.Length;i++)
            {
                this.vector.Add(arrayOfCoordinates[i]);
            }
        }
        public Vector(Vector vec)
        {
            this.vector = new List<int>();
            for (int i=0;i<vec.vector.Count;i++)
            {
                this.vector.Add(vec.vector[i]);
            }
        }
        public int this[int index]
        {
            get { return vector[index]; }
            set { vector[index] = value; }
        }
        public int VectorDimension
        {
            get {return vectorDimension; }
            set {this.vectorDimension = vector.Count; }
        }
        public int VectorLenght()
        {
            return this.vector.Count;
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
                    hash = hash * 23 + el.GetHashCode();
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
            int newVecLen = a.VectorLenght();
            int[] PointArrayForConstructor = new int[newVecLen];
            for(int i=0;i<PointArrayForConstructor.Length;i++)
            {
                PointArrayForConstructor[i] = a[i] + b[i];
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
            int[] newVecArrayForConstructor = new int[aLen];
            for(int i=0; i < aLen; i++)
            {
                newVecArrayForConstructor[i] = a[i] + b ;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator -(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            int[] newVecArrayForConstructor = new int[aLen];
            for (int i = 0; i < aLen; i++)
            {

                newVecArrayForConstructor[i] = a[i] - b;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator *(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            int[] newVecArrayForConstructor = new int[aLen];
            for (int i = 0; i < aLen; i++)
            {
                newVecArrayForConstructor[i] =a[i]* b;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }
        public static Vector operator /(Vector a, int b)
        {
            int aLen = a.VectorLenght();
            int[] newVecArrayForConstructor = new int[aLen];
            for (int i = 0; i < aLen; i++)
            { 
                newVecArrayForConstructor[i] = a[i] /b;
            }
            Vector newVector = new Vector(newVecArrayForConstructor);
            return newVector;
        }

        //define operator * - the dot product of 2 vectors (check if the 2 vectors have the same dimension!)

        public static int operator * (Vector a ,Vector b)
        {
            int dotProduct = 0;
            int len1 = a.VectorLenght();
            int len2 = b.VectorLenght();
            dotProduct = (len1 + len2) *(len1+ len2);

            return dotProduct;
        }

    }
}
