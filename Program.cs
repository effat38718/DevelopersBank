 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class Program
    {
        public static string serviceNo;
        public static Bank bank;
        static void Main(string[] args)
        {
            Program program = new Program();
            Program.bank = new Bank();
            while(true)
            {
                program.LaunchApp();
                if(serviceNo == "quit" )
                {
                    return;
                }
                program.LaunchService();
            }
            /*Bank bank = new Bank();
            bank.CreateAccount();
            bank.Transaction();*/
            
        }

        public void LaunchApp()
        {
            Console.WriteLine("WELCOME TO DEVELOPES BANK!!");
            Console.WriteLine("HOW CAN I HELP YOU?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("TYPE 'open' FOR OPENING A BANK ACCOUNT");
            Console.WriteLine("TYPE 'account' FOR PERFORMING TRANSACTION FOR AN ACCOUNT");
            Console.WriteLine("TYPE 'quit' EXIT FROM THE APPLICATION");
            Console.WriteLine("-----------------------------");

            serviceNo = Console.ReadLine();
        }

        public void LaunchService()
        {
            switch(serviceNo)
            {
                case "open":
                    bank.CreateAccount();
                    break;
                case "account":
                    bank.Transaction();
                    break;
                case "quit":
                    return;
            }
        }

    }
}
