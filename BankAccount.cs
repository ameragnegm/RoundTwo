using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class BankAccount
    {
        
        public int AccountNumber { get;  } 
        public string AccountHolderName { get; set; }

        private int balance;
        public int Balance
        {
            get
            {
                return balance;
            }

            private set 
            {
                balance = value;   
            }

        }
        public BankAccount (int accountNumber , string Name , int initalbalance) 
        {
            AccountNumber = accountNumber;
            AccountHolderName = Name;
            Balance = initalbalance;
        }
         public void Deposit (int amount) 
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($" The current balance is {Balance}");
            }
            else
            {
                Console.WriteLine("The process failed .");

            }
        }


         public void withdraw(int amount) {
            if (amount > 0 && amount <= balance )
             {
                Balance -= amount;
                Console.WriteLine($" The current balance is {Balance}");
            }
            else
            {
                Console.WriteLine("The process failed ."); 

            }
        }
    }
}
