using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5oop
{
    class BMW : GermanCars
    {
        private int mileage;

        public BMW(int a)
        {
            mileage = a;
        }
        public int Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }

        public override bool IsEcoFriendly(bool testing)
        {
            return true;
        }
        public override int GetMileage(Car car)
        {
            return mileage;
        }
    }
}
