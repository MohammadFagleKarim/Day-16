using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string OpeningDate { get; set; }
        public double Balance { get; private set; }

        public bool Deposit(double amount)
        {
            Balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            Balance -= amount;
            return true;
        }

        public double BalanceInfo()
        {
            return Balance;
        }

        //private string number;
        //private string openingDate;
        //private double balance;
        
        //public Account()
        //{
        //    balance = 0;
        //}

        //public Account(string accountNumber, string openingDate) : this()
        //{
        //    this.number = accountNumber;
        //    this.openingDate = openingDate;
        //}

        //public string Number
        //{
        //    get { return number; }
        //    set { number = value; }
        //}

        //public string OpeningDate
        //{
        //    get { return openingDate; }
        //    set { openingDate = value; }
        //}

        //public double Balance
        //{
        //    get { return balance; }
        //}

        //public bool Deposit(double amount)
        //{
        //    balance = Balance + amount;
        //    return true;
        //}

        //public bool Withdraw(double amount)
        //{
        //    if (amount <= Balance)
        //    {
        //        balance = Balance - amount;
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
