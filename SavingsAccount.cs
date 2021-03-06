using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class SavingsAccount : Account
    {
        public SavingsAccount(int accountNo, string name, string dateofBirth, string address, double balance) : base(accountNo, name, dateofBirth, address, balance)
        {

        }
        public override void Withdraw()
        {
            Console.WriteLine("Enter the Withdraw amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            if (amount < balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("SORRY YOUR ACOUNT BALANCE CANNOT BE ZERO!!");
            }

        }
    }
}
