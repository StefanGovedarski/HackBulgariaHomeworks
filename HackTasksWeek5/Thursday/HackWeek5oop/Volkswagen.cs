using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackWeek5oop
{
    class Volkswagen : GermanCars
    {
        private int mileage;

         public Volkswagen(int a)
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
            if (testing)
                return false;
            else
                return false;
        }
        public override int GetMileage(Car car)
        {
            return mileage;
        }
    }
}
