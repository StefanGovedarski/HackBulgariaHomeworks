using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackBulgariaWeek4Generics
{
    class Pair<T>
    {
        private T x;
        private T y;
        
        public Pair()
        {

        }
        public Pair(T x2 , T y2)
        {
            x = x2;
            y = y2;
        }

        public T X
        {
            get { return x; }
            set { x = value; }
        }
        public T Y
        {
            get { return y; }
            set {y = value; }
        }
        public override string ToString()
        {
            string s ="The Pair you have is: " + X + ";" + Y;
            return s;
        }
        public override bool Equals(object obj)
        {
            bool eq = false;
            Pair<T> obj1 = this;
            Pair<T> obj2 = (Pair<T>)obj;
            if(obj1.x.Equals(obj2.x) && obj1.y.Equals(obj2.y))
            {
                eq = true;
            }
            return eq;
        }
        public static bool operator ==(Pair<T> a , Pair<T> b)
        {
            bool eq = false;
            if (Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null && (object)b != null) || ((object)a != null && (object)b == null))
            {
                return false;
            }
            if (a.X.Equals(b.X) && a.Y.Equals(b.Y))
            {
                eq = true;
            }

            return eq;
        }
        public static bool operator !=(Pair<T>a , Pair<T> b)
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

