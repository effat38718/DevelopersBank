using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    class CheckingAccount : Account
    {
        public CheckingAccount(string name, string dateofBirth, string address, double balance) : base (name, dateofBirth, address,balance)
        {

        }
        public override void Withdraw()
        {
            Console.WriteLine("Enter the withdraw amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if(amount <= balance)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("YOU DON'T HAVE SUFFICIENT baLANCE!!");
            }
        }
    }
}
