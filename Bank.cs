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
            Console.WriteLine("Please Enter your choice : ");
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
                Console.WriteLine("Account No : " + counter);
                Console.WriteLine("YOU HAVE SUCCESSFULLY OPENED A SAVINGS ACCOUNT!!");
                Console.WriteLine("----------------------------------------------------");
                counter++;
            }
            else if (type == "checking")
            {
                Account account = new CheckingAccount(counter, name, dateofBirth, address, balance);
                accounts[counter] = account;
                Console.WriteLine("Account No : " + counter);
                Console.WriteLine("YOU HAVE SUCCESSFULLY OPENED A CHECKING ACCOUNT!!");
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
                int accountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the deposit amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                accounts[accountNo].Deposit(amount);
            }
            else if (transactionType == "withdraw")
            {
                Console.WriteLine("Enter Account number : ");
                int accountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the withdraw amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                accounts[accountNo].Withdraw(amount);
            }
            else if (transactionType == "transfer")
            {
                Console.WriteLine("Enter your account number : ");
                int senderAccountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the account number you want to transfer to : ");
                int receiverAccNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Transfer amount : ");
                double amount = Convert.ToDouble(Console.ReadLine());

                Account receiver = accounts[receiverAccNo];
                accounts[senderAccountNo].Transfer(receiver, amount);
            }
            else if (transactionType == "show")
            {
                Console.WriteLine("Enter Your Account number : ");
                int accountNo = Convert.ToInt32(Console.ReadLine());
                accounts[accountNo].ShowInformation();

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
