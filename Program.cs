 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Program
    {
        public string serviceNo;
        public string open;
        public string account;
        public string name;
        public string dateofBirth;
        public string Address;
        public double balance;
        static void Main(string[] args)
        {
            while(true)
            {

            }
        }

        public void LaunchApp()
        {
            Console.WriteLine("WELCOME TO DEVELOPES BANK!!");
            Console.WriteLine("HOW CAN I HELP YOU?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("PRESS 1: FOR OPENING A BANK ACCOUNT");
            Console.WriteLine("PRESS 2: FOR PERFORMING TRANSACTION");
            Console.WriteLine("PRESS 3: TO QUIT");
            Console.WriteLine("-----------------------------");

            this.serviceNo = Console.ReadLine();
        }

        public void LaunchService()
        {
            switch(serviceNo)
            {
                case "open":
                    //Console.WriteLine("Enter your name : ");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("Enter your Date of birth : ");
                    //string dateofBirth = Console.ReadLine();
                    //Console.WriteLine("Enter your Address : ");
                    //string address = Console.ReadLine();
                    //Console.WriteLine("Enetr your Starting Balance");
                    //double balance = Convert.ToDouble(Console.ReadLine());
                    switch(open)
                    {
                        case "savings":
                            break;
                        case "checking":
                            break;
                        case "quit":
                            return;
                    }
                    break;
                case "account":
                    switch(account)
                    {
                        case "deposit":
                            break;
                        case "withdraw":
                            break;
                        case "transfer":
                            break;
                        case "show":
                            break;
                        case "quit":
                            return;
                    }
                    break;
                case "quit":
                    return;
            }
        }

    }
}
