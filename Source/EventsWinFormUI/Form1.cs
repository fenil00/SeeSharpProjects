using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsWinFormUI
{
    using EventsLibrary;

    public partial class Form1 : Form
    {
        Customer customer = new Customer();

        public Form1()
        {
            InitializeComponent();

            LoadTestingData();

            WireUpForm();
        }

        private void LoadTestingData()
        {
            customer.CustomerName = "Fenil Desai";
            customer.CheckingAccount = new Account();
            customer.SavingsAccount = new Account();

            customer.CheckingAccount.AccountName = "Fenil's Checking Account";
            customer.SavingsAccount.AccountName = "Fenil's Savings Account";

            customer.CheckingAccount.AddDeposit("Initial Balance", 155.43M);
            customer.SavingsAccount.AddDeposit("Initial Balance", 98.45M);

            this.customer.CheckingAccount.TransactionApprovedEvent += CheckingAccount_TransactionApprovedEvent;
            this.customer.SavingsAccount.TransactionApprovedEvent += SavingsAccount_TransactionApprovedEvent;
            this.customer.CheckingAccount.OverdraftEvent += CheckingAccount_OverdraftEvent;
        }

        private void CheckingAccount_OverdraftEvent(object sender, OverdraftEventArgs e)
        {
          e.CancelTransaction = this.denyOverdraft.Checked;
            this.errorMessage.Text = $"You had an overdraft protection transfer of {string.Format("{0:C2}", e.AmountOverfrafted)}";
            errorMessage.Visible = true;
        }

        private void SavingsAccount_TransactionApprovedEvent(object sender, string e)
        {
            savingsTransactions.DataSource = null;
            savingsTransactions.DataSource = customer.SavingsAccount.Transactions;
            savingsBalanceValue.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void CheckingAccount_TransactionApprovedEvent(object sender, string e)
        {
            checkingTransactions.DataSource = null;
            checkingTransactions.DataSource = customer.CheckingAccount.Transactions;
            checkingBalanceValue.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void WireUpForm()
        {
            customerText.Text = customer.CustomerName;
            checkingTransactions.DataSource = customer.CheckingAccount.Transactions;
            savingsTransactions.DataSource = customer.SavingsAccount.Transactions;
            checkingBalanceValue.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
            savingsBalanceValue.Text = string.Format("{0:C2}", customer.SavingsAccount.Balance);
        }

        private void recordTransactionsButton_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions(customer);
            transactions.Show();
        }

        private void errorMessage_Click(object sender, EventArgs e)
        {
            errorMessage.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Deregister all Events listeners
            this.customer.CheckingAccount.TransactionApprovedEvent -= CheckingAccount_TransactionApprovedEvent;
            this.customer.SavingsAccount.TransactionApprovedEvent -= SavingsAccount_TransactionApprovedEvent;
            this.customer.CheckingAccount.OverdraftEvent -= CheckingAccount_OverdraftEvent;
        }
    }
}
