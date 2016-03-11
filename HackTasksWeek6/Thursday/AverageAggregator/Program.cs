using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AverageAggregator avrg = new AverageAggregator(new List<int>() { 11, 23, 3, 4, 5, 5, 6 } );
            avrg.AverageEvent += Avrg_AverageEvent;
            avrg.ReactEvent += Avrg_ReactEvent;
            Console.WriteLine("the starting average is {0}",avrg.Average);
            avrg.AddNumber(66);
            avrg.AddNumber(1001);

        }

        private static void Avrg_ReactEvent(object sender, EventArgs e)
        {
            Console.WriteLine( "The average now is {0}:",sender);
        }

        private static void Avrg_AverageEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Average has changed");
        }
    }
}
