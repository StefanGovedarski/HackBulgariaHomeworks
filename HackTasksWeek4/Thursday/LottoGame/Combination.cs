using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LottoGames
{
    public class Combination<T,U>
    {
        public readonly T[] firstThree = new T[3];
        public readonly U[] secondThree = new U[3];

        public Combination(T t1 , T t2 , T t3 , U u1 ,U u2 , U u3)
        {
            T[] item1 = new T[3] {t1,t2,t3 };
            U[] item2 = new U[3] { u1, u2, u3 };
            firstThree = item1;
            secondThree = item2;

        }



        public override bool Equals(object obj)
        {
            if (this is Combination<T, U> && obj is Combination<T, U>)
            {
                Combination<T, U> loto1 = this;
                Combination<T, U> loto2 = (Combination<T, U>)obj;
                if (loto1.firstThree.Equals(loto2.firstThree) && loto1.secondThree.Equals(loto2.secondThree))
                {
                    return true;
                }
            }
            return false;
        }


        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                for (int i = 0; i < firstThree.Length; i++)
                {
                    hash = hash * 23 + firstThree[i].GetHashCode();
                }
                for (int i = 0; i < secondThree.Length; i++)
                {
                    hash = hash * 23 + secondThree[i].GetHashCode();
                }
                return hash;
            }
        }

    }
}
