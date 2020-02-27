using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerAndAccountAppExample1
{
    public partial class CustomerAndAccountUi : Form
    {
        //private Customer customerObj = null;

        public CustomerAndAccountUi()
        {
            InitializeComponent();
        }

        private Customer _customer;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _customer = new Customer();
            _customer.Name = customerNameTextBox.Text;
            _customer.Email = emailTextBox.Text;

            //_customer.BankAccount = new Account();
            //_customer.BankAccount.AccountNumber = accountNumberTextBox.Text;
            //_customer.BankAccount.OpeningDate = openingDateTextBox.Text;

            Account anAccount = new Account();
            anAccount.AccountNumber = accountNumberTextBox.Text;
            anAccount.OpeningDate = openingDateTextBox.Text;

            _customer.BankAccount = anAccount;
            

            //customerObj = new Customer();
            //Account anAccount = new Account(accountNumberTextBox.Text, openingDateTextBox.Text);
            //customerObj.Name = customerNameTextBox.Text;
            //customerObj.Email = emailTextBox.Text;
            //customerObj.CustomerAccount = anAccount;
            //MessageBox.Show(customerObj.Name + " has opened an account with " + customerObj.CustomerAccount.Number + " number");
        }

        private void DepositeButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isSuccess = _customer.BalanceDeposit(amount);

            if(isSuccess)
            {
                amountTextBox.Clear();
            }

            //double amount = Convert.ToDouble(amountTextBox.Text);
            //if (customerObj.CustomerAccount.Deposit(amount))
            //{
            //    MessageBox.Show(amount + " Tk. has been deposited");
            //}
            //else
            //{
            //    MessageBox.Show("Operation failed");
            //}
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(amountTextBox.Text);
            bool isSuccess = _customer.BalanceWithdraw(amount);

            if (isSuccess)
            {
                amountTextBox.Clear();
            }

            //double amount = Convert.ToDouble(amountTextBox.Text);
            //if (customerObj.CustomerAccount.Withdraw(amount))
            //{
            //    MessageBox.Show(amount + " Tk. has been withdrawn");
            //}
            //else
            //{
            //    MessageBox.Show("Insufficient amount");
            //}
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayCustomerNameTextBox.Text = _customer.Name;
            displayEmailTextBox.Text = _customer.Email;
            displayAccountNumberTextBox.Text = _customer.BankAccount.AccountNumber;
            displayOpeningDateTextBox.Text = _customer.BankAccount.OpeningDate;

            displayBalanceTextBox.Text = Convert.ToString(_customer.BankAccount.BalanceInfo());

            //customerName2TextBox.Text = customerObj.Name;
            //email2TextBox.Text = customerObj.Email;
            //accountNumber2TextBox.Text = customerObj.CustomerAccount.Number;
            //openingDate2TextBox.Text = customerObj.CustomerAccount.OpeningDate;
            //BalanceTextBox.Text = customerObj.CustomerAccount.Balance.ToString();
        }
    }
}
