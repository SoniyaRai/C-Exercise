using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelop_Assignment
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance = 0;

        public BankAccount(string accountNumber, decimal balance) { 
            this.accountNumber = accountNumber;
            this.balance = balance;

            Console.WriteLine("Account number is " + accountNumber + "and" + "Balance is " + balance);
        }
        public decimal Deposit(decimal amount)
        {
            Console.WriteLine("Rs." + amount + " has been deposited");
            return balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Console.WriteLine("Rs."+amount+" has been withdrawn");
            return balance -= amount;
        }

        public decimal finalBalance()
        {
            Console.WriteLine("Final Balance is Rs." + balance);
            return balance;
        }
    }
}
