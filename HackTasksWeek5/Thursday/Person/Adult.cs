using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Adult : Person
    {
        public Adult(string gender)
        {
            if (gender != "MALE" && gender != "Male"  &&gender != "male" && gender != "Female" && gender != "female" && gender != "FEMALE")
            {
                Console.WriteLine("the syntax or gender of the input is wrong.We will use the default - male");
                this.Gender = "male";
            }
            else
            {
                this.Gender = gender;
            }
        }


        public new void DoStuff()
        {
            Console.WriteLine("Workiiing");
        }
        public bool IsThisAdultBoring(Adult adult)
        {
            Random rand = new Random(1);
            int boringMeter = rand.Next(100);
            if (boringMeter <= 50)
                return false;
            else
                return true;
        }
        public Child HaveAChild(Adult a,Adult b)
        {
            if((a.Gender=="Male"||a.Gender=="MALE"||a.Gender=="male")&&(b.Gender=="MALE"||b.Gender=="male"||b.Gender=="Male"))
            {
                Console.WriteLine("Not possible for two adults of the same gender to have a child");
            }
            else if((a.Gender == "Female" || a.Gender == "FEMALE" || a.Gender == "female") && (b.Gender == "FEMALE" || b.Gender == "female" || b.Gender == "Female"))
            {
                Console.WriteLine("Not possible for two adults of the same gender to have a child");
            }
            Child newChild = new Child("female");
            return newChild;
            
        }
    }
}
