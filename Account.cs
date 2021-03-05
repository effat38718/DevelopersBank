using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public abstract class Account
    {
        public string name;
        public string dateofBirth;
        public string address;
        public double balance;

        public Account(string name, string dateofBirth, string address, double balance)
        {
            this.name = name;
            this.dateofBirth = dateofBirth;
            this.address = address;
            this.balance = balance;
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the deposit amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            balance = balance + amount;

        }

        public abstract void Withdraw();

        public void Transfer()
        {
            
        }

        public void ShowInformation()
        {

        }
    }
}
