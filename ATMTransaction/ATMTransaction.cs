using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATMTransaction
    {
        private decimal balance;
        public ATMTransaction(decimal initialbalance)
        {
            balance = initialbalance;
        }

        public void Deposite(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited :{amount:c}");
            Console.WriteLine($"now balance : {balance:c}");
        }
        public void Withdraw(decimal amount)
        {
            if(amount > balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            balance -= amount;
            Console.WriteLine($"Withdraw : {amount :c}");
            Console.WriteLine($"now balance : {balance :c}");
        }
        public void Displaybalance()
        {
            Console.WriteLine($"Current Balance : {balance :c}");

        }
    }
}
