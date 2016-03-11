using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7AnonymusAndLambda
{
    public delegate void ValueChanged(string message);

    class AverageAggregator
    {
        ValueChanged message = delegate (string mess)
        {
            Console.WriteLine(mess);
        };
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
            if (average != default(decimal))
            {
                message("The average is changed , added " + number);
            }
            Average = CalculateAverage(numbers);
        }


        private decimal CalculateAverage(List<int> list)
        {
            decimal avrg = 0;
            int len = list.Count;
            foreach (var el in list)
            {
                avrg += (decimal)el;
            }
            avrg = (decimal)avrg / len;
            if (average != default(decimal))
            {
                message("The new average is: " + average);
            }
            return avrg;
        }

    }
}

