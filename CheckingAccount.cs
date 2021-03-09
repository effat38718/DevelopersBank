using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class CheckingAccount : Account
    {
        public CheckingAccount(int accountNo, string name, string dateofBirth, Address address, double balance) : base (accountNo, name, dateofBirth, address,balance)
        {

        }
        public override void Withdraw(double amount)
        {

            if(amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine("The amount " +amount+" has been withdrawn from your account");
                Console.WriteLine("Your new balance is : " + balance);
                transactionCount++;
            }
            else
            {
                Console.WriteLine("YOU DON'T HAVE SUFFICIENT BALANCE!!");
            }
        }
    }
}
