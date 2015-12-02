using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Pair
{
    class Pair
    {
        private readonly int X;
        private readonly int Y;

        internal Pair(int a, int b)
        {
            X = a;
            Y = b;
        }
        public override bool Equals(object obj)
        {
            bool eq = false;
            Pair obj1 = this;
            Pair obj2 = (Pair)obj;
            if (obj1.X == obj2.X && obj1.Y == obj2.Y)
            {
                eq = true;
            }

            return eq;
        }
        public override string ToString()
        {
            string s = "This class pair the two objects with values and compares them overriding the equals base method.Turning one them into a string will bring you no joy.";
            string q = "Buut if you insist , convert the current object from a Pair type object to another and then use the standart ToString() method";
            Console.WriteLine(s + q);
            return s + q;
        }
        public static bool operator ==(Pair a , Pair b)
        {
            bool result = false;
            if(Object.ReferenceEquals(a,b))
            {
                return true;
            }
            if(((object)a == null && (object)b != null)||((object)a!= null && (object)b == null))
            {
                return false;
            }
            if(a.X==b.X && a.Y == b.Y)
            {
                result = true;
            }

            return result;

        }
        public static bool operator !=(Pair a , Pair b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}
