using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAndAccountAppExample1
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { set; get; }
        public Account BankAccount { get; set; }

        public bool BalanceDeposit(double amount)
        {
            if(BankAccount == null)
            {
                return false;
            }

            return BankAccount.Deposit(amount);
        }

        public bool BalanceWithdraw(double amount)
        {
            if (BankAccount == null)
            {
                return false;
            }

            return BankAccount.Withdraw(amount);
        }

        public string CustomerAccountNumber
        {
            get { return BankAccount.AccountNumber; }
        }

        //private string name;
        //private string email;
        //private Account customerAccount = null;

        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; }
        //}

        //public Account CustomerAccount
        //{
        //    get { return customerAccount; }
        //    set { customerAccount = value; }
        //}
    }
}
