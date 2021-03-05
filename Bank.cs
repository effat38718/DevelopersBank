using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public class Bank
    {
        public void CreateAccount()
        {
            Console.WriteLine("OPEN A BANK ACCOUNT");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SELECT THE TYPE OF YOUR ACCOUNT");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Checking Account");
            Console.WriteLine("3. Exit from the application");
            Console.WriteLine("Please Enter the Type Number : ");
            int type = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Date of birth : ");
            string dateofBirth = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Starting Balance : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            if (type == 1)
            {
                Account account = new SavingsAccount(name, dateofBirth, address, balance);
            }
            else if (type == 2)
            {
                Account account = new CheckingAccount(name, dateofBirth, address, balance);
            }
            else if (type == 3)
            {
                return;
            }
            else
            {
                Console.WriteLine("YOU HAVE ENTERED AN INVALID TYPE NUMBER.");
            }
        }
    }
}
