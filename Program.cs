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
        public string open;
        public string account;
        static void Main(string[] args)
        {
            Program program = new Program();
            while(true)
            {
                program.LaunchApp();
                if(serviceNo == "quit" )
                {
                    return;
                }
                program.LaunchService();
            }
        }

        public void LaunchApp()
        {
            Console.WriteLine("WELCOME TO DEVELOPES BANK!!");
            Console.WriteLine("HOW CAN I HELP YOU?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("PRESS 1: OPENING A BANK ACCOUNT");
            Console.WriteLine("PRESS 2: PERFORM TRANSACTION FOR AN ACCOUNT");
            Console.WriteLine("PRESS 3: EXIT FROM THE APPLICATION");
            Console.WriteLine("-----------------------------");

            serviceNo = Console.ReadLine();
        }

        public void LaunchService()
        {
            switch(serviceNo)
            {
                case "open":
                    switch (open)
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
