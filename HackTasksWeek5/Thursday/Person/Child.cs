using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Child : Person
    {
        private int ToySize;
        private string ToyColour;

        public Child(string gender)
        {
            if(gender!="MALE"&&gender!="Male" && gender != "male" && gender != "Female" && gender != "female" && gender != "FEMALE")
            {
                Console.WriteLine("the syntax or gender of the input is wrong.We will use the default - male");
                this.Gender = "male";
            }
            else
            {
                this.Gender = gender;
            }
        }
        public void CreateToy(int toySize , string toyColour)
        {
            ToySize = toySize;
            ToyColour = toyColour;
        }
        public new void DoStuff()
        {
            Console.WriteLine("The child is playing");
        }
    }
}
