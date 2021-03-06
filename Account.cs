using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public abstract class Account
    {
        private int accountNo;
        private string name;
        private string dateofBirth;
        internal double balance;
        private Address address;
        internal int transactionCount = 0;

        public Account(int accountNo, string name, string dateofBirth, Address address, double balance)
        {
            this.accountNo = accountNo;
            this.name = name;
            this.dateofBirth = dateofBirth;
            this.address = address;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            Console.WriteLine("Your depositted amount is  " + amount);
            Console.WriteLine("Your current balance is " + balance);
            transactionCount++;
        }

        public abstract void Withdraw(double amount);

        public void Transfer(Account receiver, double amount)
        {
            balance -= amount;
            transactionCount++;

            receiver.balance += amount;
            receiver.transactionCount++;

            Console.WriteLine("Your transferred amount : " + amount);
            Console.WriteLine("Your current balance is : " + balance);

        }

        public void ShowInformation()
        {
            Console.WriteLine("Your Account Balance is : " + balance);
            Console.WriteLine("The number of Transaction in your account : " + transactionCount);
        }
    }
}
