using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public class Bank
    {
        public static int counter = 0;
        public Account[] accounts;

        public Bank()
        {
            this.accounts = new Account[100];
        }
        public void CreateAccount()
        {
            Console.WriteLine("OPEN A BANK ACCOUNT");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("SELECT THE TYPE OF YOUR ACCOUNT");
            Console.WriteLine("Type 'savings' for Savings Account");
            Console.WriteLine("Type 'checking' Checking Account");
            Console.WriteLine("Type 'quit' to Exit from the application");
            Console.WriteLine("Please Enter the Type Number : ");
            string type = Console.ReadLine();
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Date of birth : ");
            string dateofBirth = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Starting Balance : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            if (type == "savings")
            {
                Account account = new SavingsAccount(counter, name, dateofBirth, address, balance);
                accounts[counter] = account;
                Console.WriteLine("YOU HAVE SUCCESSFULLY OPENED A SAVINGS ACCOUNT!!");
                Console.WriteLine("Account No : " + counter);
                Console.WriteLine("----------------------------------------------------");
                counter++;
            }
            else if (type == "checking")
            {
                Account account = new CheckingAccount(counter, name, dateofBirth, address, balance);
                accounts[counter] = account;
                Console.WriteLine("YOU HAVE SUCCESSFULLY OPENED A CHECKING ACCOUNT!!");
                Console.WriteLine("Account No : " + counter);
                Console.WriteLine("----------------------------------------------------");
                counter++;
            }
            else if (type == "quit")
            {
                return;
            }
            else
            {
                Console.WriteLine("YOU HAVE ENTERED AN INVALID TYPE.");
            }
        }

        public void Transaction()
        {
            Console.WriteLine("PERFORM TRANSACTION FOR AN ACCOUNT");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Select the type of transaction");
            Console.WriteLine("Type 'deposit' to Make a deposit");
            Console.WriteLine("Type 'withdraw' to withdraw money");
            Console.WriteLine("Type 'transfer' to transfer money");
            Console.WriteLine("Type 'show' to show the number of transaction and balance");
            Console.WriteLine("Type 'quit' to exit the application");
            string transactionType = Console.ReadLine();

            if(transactionType == "deposit")
            {
                Console.WriteLine("Enter Account number : ");
                counter = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the deposit amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                this.accounts[counter].Deposit(amount);
            }
            else if (transactionType == "withdraw")
            {

            }
            else if (transactionType == "transfer")
            {

            }
            else if (transactionType == "show")
            {

            }
            else if (transactionType == "quit")
            {
                return;
            }
            else
            {
                Console.WriteLine("YOU HAVE ENTERED AN INVALID TRANSACTION TYPE.");
            }
        }
    }
}
