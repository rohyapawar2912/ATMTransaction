using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal initialBalance = 6000;
            ATMTransaction atm = new ATMTransaction(initialBalance);

            while (true)
            {
                Console.WriteLine("Please select below option :");
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("3 - check balance");
                Console.WriteLine("4 - exit ");
                Console.WriteLine("--------------------------------------------------");
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine(" Deposit amount: ");
                        decimal depositAmount = Convert.ToInt32(Console.ReadLine());
                        atm.Deposite(depositAmount);
                        break;
                    case 2:
                        Console.WriteLine("Withdraw amount : ");
                        decimal withdrawAmount = Convert.ToInt32(Console.ReadLine());
                        atm.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        atm.Displaybalance();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using ATM . Good Bye");
                        return;
                    default:
                        Console.WriteLine("invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
