using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNo, string name, string dateofBirth, Address address, double balance) : base(accountNo, name, dateofBirth, address, balance)
        {

        }
        public override void Withdraw(double amount)
        {
            if (amount < balance)
            {
                balance -= amount;
                Console.WriteLine("The amount " + amount + " has been withdrawn from your account");
                Console.WriteLine("Your new balance is : " + balance);
                transactionCount++;
            }
            else
            {
                Console.WriteLine("SORRY YOUR ACOUNT BALANCE CANNOT BE ZERO!!");
            }

        }
    }
}
