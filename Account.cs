using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public abstract class Account
    {
        public int accountNo;
        public string name;
        public string dateofBirth;
        public string address;
        public double balance;

        public Account(int accountNo, string name, string dateofBirth, string address, double balance)
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
