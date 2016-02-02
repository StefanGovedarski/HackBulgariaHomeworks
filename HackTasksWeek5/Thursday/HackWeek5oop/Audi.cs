using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5oop
{
    class Audi : GermanCars
    {
        private int mileage;

        public Audi(int a)
        {
            mileage = a;
        }
        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public override int GetMileage(Car car)
        {
            return mileage;
        }
    }
}
