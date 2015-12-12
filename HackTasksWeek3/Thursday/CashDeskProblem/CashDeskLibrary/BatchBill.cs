using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskLibrary
{
    //coins = [1,2,5,10,20,50,1] bills = [2,5,10,20,50,100]
    public class BatchBill : IEnumerator,IEnumerable
    {
        private List<int> batch = new List<int>();
        private int position = -1;

        public BatchBill( params int[] input)
        {
            List<int> current = new List<int>();
            for(int i=0;i<input.Length; i++)
            {
                if((int)input[i]==2 || (int)input[i] == 5 || (int)input[i] == 10 || (int)input[i] == 20 || (int)input[i] == 50 || (int)input[i] == 100)
                {
                    current.Add(input[i]);
                }
                else
                {
                    Console.WriteLine("Your bill " + (int)input[i] + "was denied! The cash desk accepts only 2,5,10,20,50,100 bills");
                }            
            }
            batch = current;
        }

        object IEnumerator.Current
        {
            get
            {
                return batch[position];
            }
        }

        public int Count(BatchBill batch)
        {
            int count = 0;
            foreach(Bill bill in batch)
            {
                count++;
            }
            return count;
        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)batch).GetEnumerator();
        }

        bool IEnumerator.MoveNext()
        {
            if(position < batch.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IEnumerator.Reset()
        {
            position = 0;
        }
        public int Total(BatchBill batch)
        {
            int total = 0;
            foreach(Bill element in batch)
            {
                total += (int)element;
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach(int bill in batch)
            {
                s.Append((int)bill + "$ Bill\n");
            }
            return s.ToString();
        }
    }
}
