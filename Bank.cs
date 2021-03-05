using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developers_Bank
{
    public class Bank
    {
        public string name;
        public string dateofBirth;
        public string Address;
        public double balance;
        public void CreateAccount()
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Date of birth : ");
            string dateofBirth = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your Starting Balance : ");
            double balance = Convert.ToDouble(Console.ReadLine());

            //if (SavingsAccount)
            //{
            //    Account account = new SavingsAccount(name, dateofBirth, address, balance);
            //}
            //else
            //{
            //    Account account = new CheckingAccount(name, dateofBirth, address, balance);
            //}
        }
    }
}
