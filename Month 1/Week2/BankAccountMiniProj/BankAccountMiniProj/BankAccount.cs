using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountMiniProj
{
    class BankAccount
    {
        public string name;
        public uint balance;

        public void Initialize(string name)
        {
            this.name = name;
            balance = 0;
        }

        public void Deposit(uint amount)
        {
            balance += amount;
        }

        public bool Withdraw(uint amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Not Enough Balance!");
                return false;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name} \tBalance: {balance}");
        }

        public void Transfer(BankAccount other, uint amount)
        {
            if (Withdraw(amount))
            {
                other.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Transaction Failed, Not Enough Money!");
            }
        }
    }
}
