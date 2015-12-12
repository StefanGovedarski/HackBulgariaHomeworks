using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskLibrary
{
    public class Bill
    {
        private int bill;



        public Bill(int a)
        {
            if (a <= 0)
            {
                throw new Exception("The bill cannot be lower than 0");
            }
            else if (a == 2 || a == 5 || a == 10 || a == 20 || a == 50 || a == 100)
            {
                bill = a;
            }
            else
            {
                Console.WriteLine("Your bill " + a + "was denied! The cash desk accepts only 2,5,10,20,50,100 bills");
            }
        }
        public override string ToString()
        {
            string s = "A " + bill + "$ bill.";
            return s;
        }
        public override bool Equals(object obj)
        {
            bool e = false;
            if(this is Bill && obj is Bill)
            {
                Bill a = this;
                Bill b = (Bill)obj;
                if(a.bill == b.bill)
                {
                    e = true;
                }
            }

            return e;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + bill.GetHashCode();
                return hash;
            }
        }
        public static bool operator == (Bill a , Bill b)
        {
            bool e = false;
            if (a.bill == b.bill && a.bill != 0 && b.bill != 0 && a!=null && b!= null)
                e = true;
            else
                e = false;
            return e;
        }
        public static bool operator !=(Bill a, Bill b)
        {
            return !(a == b);
        }
        public int Value(Bill bill)
        {
            int val = 0;
            val = bill.bill;
            Console.WriteLine("The bill value is +" + bill.bill);
            return val;
        }
        public static explicit operator int (Bill bill)
        {
            int a = bill.bill;
            return a;
        }
    }
}
