using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();     //4.	In the main method of your application, create a new instance of the BankAccount class

            Console.WriteLine("How much are you depositting?");
            double amountDeposited = double.Parse(Console.ReadLine()); // double.Parse because of way person might type amount of deposit

            ba.Deposit(amountDeposited);                       // Deposit from BankAccount class
            double startBalance = ba.GetBalance();              // GetBalance from BankAccount class, store into variable "userBalance"

            Console.WriteLine($"Your current balance is now:");
            Console.WriteLine(amountDeposited + startBalance);
        }
    }
}
