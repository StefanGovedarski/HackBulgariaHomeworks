using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashDeskLibrary;

namespace CashDeskApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            CashDesk desk = new CashDesk();
            Menu(s , desk);
            Exit(s);
        }
        public static void Menu(string s , CashDesk desk)
        {
            Console.WriteLine("Welcome To The Cash Desk!");
            Console.WriteLine("Input !menu to use the cash desk features. You can type exit at any point to !exit the cash desk.");
            s = Console.ReadLine();
            if(s=="!menu")
            {
                Console.WriteLine("The cash desk feature are:\n 1) Input money into the cash desk\n 2) Show the total amount of money you currently have\n 3)Show the your money in the cash desk in more detail");
                Console.WriteLine("Please input 1) to put money into the desk 2) for showing the total amount or 3) for showing in details");
                s = Console.ReadLine();
                while((s!= "1)" && s!="2)" && s!="3)" && Exit(s)== false))
                {
                    Console.WriteLine("Invalid input. Retry or write !exit to exit");
                    s = Console.ReadLine();
                }
                if(s == "1)")
                {
                    Console.WriteLine("Currently you can input a bill or a whole batch of bills into this cash desk");
                    Console.WriteLine("To input a single bill please write !bill");
                    Console.WriteLine("The input a whole batch please write !batch");
                    s = Console.ReadLine();
                    while(Exit(s)==false  && s!= "!bill" && s!="!batch")
                    {
                        Console.WriteLine("Invalid input.Retry or write !exit to exit");
                        s = Console.ReadLine();
                    }
                    if(s == "!bill")
                    {
                        Console.WriteLine("Input the bill you want. The desk will reject the bills that are not 2,5,10,20,50,100$");
                        int b = Int32.Parse(Console.ReadLine());
                        Bill bill = new Bill(b);
                        desk.TakeMoney(bill);
                    }
                    if(s == "!batch")
                    {
                        Console.WriteLine("Input the bills into the batch.The desk will reject the bills that are not 2,5,10,20,50,100$.Input 0 to stop putting bills in");
                        List<int> batch =new List<int>();
                        int a = Int32.Parse(Console.ReadLine());
                        while(a!=0)
                        {
                            batch.Add(a);
                            a = Int32.Parse(Console.ReadLine());
                        }
                        BatchBill bach = new BatchBill(batch.ToArray());
                        desk.TakeMoney(bach);
                    }
                    Menu(s , desk);
                    
                }
                else if(s == "2)")
                {
                    desk.Total();
                    Menu(s, desk);
                }
                else if(s=="3)")
                {
                    desk.Inspect();
                    Menu(s, desk);
                }
            }
        }
        public static bool Exit(string s)
        {
            if (s == "!exit")
            {
                Console.WriteLine("Goodbye!");
                return true;
            }
            return false;
        }
    }
}
