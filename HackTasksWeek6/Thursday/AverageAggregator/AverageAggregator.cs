using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageAggregator
{
    class AverageAggregator
    {
        public delegate void MyEventHandler(object sender, EventArgs e);
        public event MyEventHandler AverageEvent;
        public event MyEventHandler ReactEvent;
        private List<int> numbers = new List<int>();
        private decimal average;

        public AverageAggregator(List<int> input)
        {
            this.numbers = input;
            Average = CalculateAverage(numbers);
        }

        public decimal Average
        {
            get { return average; }
            set
            { 
                average = value;
            }
        }

        public void AddNumber(int number)
        {
            numbers.Add(number);
            Console.WriteLine("added {0}",number);
            if (average != default(decimal))
            {
                if (AverageEvent != null)
                {
                    AverageEvent(this, EventArgs.Empty);
                }
            }
            Average = CalculateAverage(numbers);
        }


        private decimal CalculateAverage(List<int> list)
        {
            decimal avrg = 0;
            int len = list.Count;
            foreach(var el in list)
            {
                avrg += (decimal)el;
            }
            avrg = (decimal)avrg / len;
            if(ReactEvent != null)
            {
                ReactEvent(avrg, EventArgs.Empty);
            }

            return avrg;
        }

    }
}
