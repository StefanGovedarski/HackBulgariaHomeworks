using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HackTask
{
    class Week2_Day2_Task6 : HackBgExecutable
    {
        public void Execute()
        {
            /*Bank Account Balance

Pesho has extracted his bank account statement in a file and he wants to know how much money he has received,
has spent and what is his balance (received - spent). 
He wants to be able to check that for any given date range.
This is my version of the file:
2015.5.20;input;25,50
2015.5.20;output;20,00
2015.5.21;input;100
2015.5.21;input;50
2015.6.21;output;150
*/

            string filename = "../../outputs/bank.txt";
            Console.WriteLine("lets check if the bank file exists :");
            Console.WriteLine(File.Exists(filename) ? "File exists" : "File does not exist");
            string transaction = File.ReadAllText(filename);
            string[] separator = new string[10];
            separator = transaction.Split(new char[] { ';', '\n', '\r' });
            for (int i = 0; i < separator.Length; i++)
            {
                Console.WriteLine(separator[i]);
            }
            Console.WriteLine("Your balance is: ");
            Balance(filename);
            Console.WriteLine("input two dates between which you want to check in the format of  YYYY.MM.DD: ");
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            DateTime.TryParse(Console.ReadLine(),out date1);
            DateTime.TryParse(Console.ReadLine(), out date2);

        }
        public static void Balance(string filename)
        {
            float balance = 0;
            string transaction = File.ReadAllText(filename);
            string[] separator = new string[10];
            separator = transaction.Split(new char[] { ';', '\n','\r' });
            for(int i=0;i<separator.Length;i++)
            {
                if(separator[i]=="input" || separator[i]=="output")
                {
                    balance += float.Parse(separator[i + 1]);
                }
            }
            Console.WriteLine(balance);
        }
        public static void CheckBetweenDates(DateTime date1 , DateTime date2 ,  string filename)
        {
            float balance = 0;
            string transaction = File.ReadAllText(filename);
            string[] separator = new string[10];
            DateTime datee = new DateTime();
            DateTime datee2 = new DateTime();
            separator = transaction.Split(new char[] { ';', '\n', '\r' });
            for(int i=0;i<separator.Length;i++)
            {
                if(DateTime.TryParse(separator[i],out datee))
                {
                    if(datee>=date1)
                    {
                        for(int j= i;j<separator[i].Length;j++)
                        {
                            if (DateTime.TryParse(separator[j], out datee2))
                            {
                                if(datee2 <= date2)
                                {
                                    if (separator[j+1] == "input" || separator[j+1] == "output")
                                    {
                                        balance += float.Parse(separator[j + 2]);
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
