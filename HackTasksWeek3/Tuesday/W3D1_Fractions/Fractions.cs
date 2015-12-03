using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D1_Fractions
{
    class Fractions
    {
        private int numerator;
        private int denumerator;

        internal Fractions(int num , int denum)
        {
            if(denum == 0)
            {
                throw new ArgumentException("Deminator cannot be 0");
            }
            else
            {

                Numerator = num;
                Denumerator = denum;
            }
        }
        internal int Numerator
        {
            get {return numerator; }
            set {numerator = value; }
        }
        internal int Denumerator
        {
            get { return denumerator; }
            set { denumerator = value; }
        }
        public override string ToString()
        {
            string s = "This class represents fractions ... the current fraction is :" + numerator.ToString() + "/" + denumerator.ToString();
            Console.WriteLine(s);
            return s;          
        }
        public override bool Equals(object obj)
        {
            bool eq = false;
            if (this is Fractions && obj is Fractions)
            {
                Fractions obj1 = this;
                Fractions obj2 = (Fractions)obj;
                if (((float)obj1.numerator / obj1.denumerator) == ((float)obj2.numerator / obj2.denumerator))
                {
                    eq = true;
                }
            }

            return eq;
        }
        public static bool operator ==(Fractions a , Fractions b)
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
            if (a.numerator == b.numerator && a.denumerator == b.denumerator)
            {
                result = true;
            }

            return result;
        }
        public static bool operator !=(Fractions a , Fractions b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + numerator.GetHashCode();
                hash = hash * 23 + denumerator.GetHashCode();
                return hash;
            }
        }

        public static Fractions operator + (Fractions a,Fractions b)
        {
            Fractions result = new Fractions(a.numerator*b.denumerator + b.numerator+a.denumerator ,a.denumerator * b.denumerator );
            return result;
        }
        public static Fractions operator -(Fractions a, Fractions b)
        {
            Fractions result = new Fractions(a.numerator * b.denumerator - b.numerator + a.denumerator, a.denumerator * b.denumerator);
            return result;
        }
        public static Fractions operator *(Fractions a, Fractions b)
        {
            Fractions result = new Fractions(a.numerator * b.numerator,a.denumerator* b.denumerator);
            return result;
        }
        public static Fractions operator /(Fractions a, Fractions b)
        {
            Fractions result = new Fractions(a.numerator * b.denumerator, a.denumerator * b.numerator);
            return result;
        }
        public static double operator +(Fractions a, double b)
        {
            double something = a.numerator / a.denumerator;
            double result =something + b;
            return result;
        }
        public static double operator -(Fractions a, double b)
        {
            double something = a.numerator / a.denumerator;
            double result = something + b;
            return result;
        }
        public static double operator /(Fractions a, double b)
        {
            double something = a.numerator / a.denumerator;
            double result = something / b;
            return result;
        }
        public static double operator *(Fractions a, double b)
        {
            double something = a.numerator / a.denumerator;
            double result = something * b;
            return result;
        }
        public static explicit operator double(Fractions frac)
        {
            double b = frac.numerator / frac.denumerator;
            return b;
        }
    }
}
