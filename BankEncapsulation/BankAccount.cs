using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;  //  A private field of type double named balance with a value of 0

        public void Deposit(double amount)  //Define a method named Deposit that will accept a double and store that value in the balance field
        {
            Console.WriteLine($"Your desposit of {amount} is recieved.");
            _balance = amount;
        }

        public double GetBalance()  //Define a method named GetBalance that will return the amount stored in the balance field 
        {
            return _balance;
        }
    }
}
