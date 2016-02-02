using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    interface Animals
    {
        //All animals can move, eat, give birth
        void Move();
        void Eat();
        void GiveBirth();
        void Greet();
    }
}
