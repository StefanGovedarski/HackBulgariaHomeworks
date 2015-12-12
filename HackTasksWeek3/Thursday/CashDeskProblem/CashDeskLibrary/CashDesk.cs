using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashDeskLibrary
{
    public class CashDesk
    {
        public Dictionary<int,int> cash;

        public CashDesk()
        {
            cash = new Dictionary<int, int>();
        }

        public void TakeMoney(Bill bill)
        {
            if(cash.ContainsKey((int)bill))
            {
                cash[(int)bill]++;
            }
            else
            {
                cash.Add((int)bill, 1);
            }
   
        }
        public void TakeMoney(BatchBill batch)
        {
            foreach(int bill in batch)
            {
                if (cash.ContainsKey((int)bill))
                {
                    cash[(int)bill]++;
                }
                else
                {
                    cash.Add((int)bill, 1);
                }
            }

        }
        public void Total()
        {
            int total = 0;
            foreach(KeyValuePair<int,int> el in cash)
            {
                total += el.Key*el.Value;
            }
            Console.WriteLine(total);
        }
        public void Inspect()
        {
            if (cash == null)
            {
                Console.WriteLine("There is nothing in the cash desk at this time,maybe input something first?");
            }
            else
            {
                foreach (KeyValuePair<int, int> el in cash)
                {
                    Console.WriteLine("{0}$ - {1}", el.Key, el.Value);
                }
            }
        }
    }
}
