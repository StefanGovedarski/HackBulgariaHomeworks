using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackTask
{
    class Week1_Day3_Task8 : HackBgExecutable
    {
        public void Execute()
        {
            Console.WriteLine(@"A transversal T for A is a set that contains at least one element from each set of A");
            List<int> trans = new List<int>() { 4, 5, 6 };
            List<List<int>> family = new List<List<int>>();
            Console.WriteLine(IsTransversal(trans, family));
            
        }
        bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            List<int> Uno = new List<int>() {5,7,9};
            List<int> Dos = new List<int>() {1,5,3};
            List<int> Tres = new List<int>() {2,5};
            family.Add(Uno);
            family.Add(Dos);
            family.Add(Tres);
            int counter = 0;
            int checker = family.Count;
            for(int i = 0; i <family.Count; i++)
            {
                for(int j=0; j < transversal.Count; j ++)
                {
                    if(family[i].Contains(transversal[j]))
                    {
                        counter++;
                    }
                }
            }
            if (counter == checker)
                return true;
            else
            return false;
        }
    }
}
