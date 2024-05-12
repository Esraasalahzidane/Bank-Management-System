using Bank.Shared;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bank.Views
{
    public partial class Transactions : FrmLayout
    {
        Client _clientToUpdate;
        List<string> accNumbers = new List<string>();

        public Transactions() : base("Transactions")
        {
            InitializeComponent();
            resetTransactionsForms();
            fillTransactionsComboboxesAccountNumbers();
        }
        public Transactions(int tabIndex, string clientAccountNumber) : base("Transactions")
        {
            InitializeComponent();
            resetTransactionsForms();
            fillTransactionsComboboxesAccountNumbers();

            switch (tabIndex)
            {
                case 0:
                    cbDepositeAccNum.Text = clientAccountNumber;
                    break;
                case 1:
                    cbWithdrawAccNum.Text = clientAccountNumber;
                    break;
                case 3:
                    cbTransferAccNumFrom.Text = clientAccountNumber;
                    break;
            }

            tabControlTransactions.SelectedIndex = tabIndex;
        }
        private void resetTransactionsForms()
        {
            resetDepositeForm();
            resetWithdrawForm();
            resetTatalBalancesForm();
            resetTransferForm();
            resetTransferLogForm();
        }
        private void fillTransactionsComboboxesAccountNumbers()
        {
            accNumbers = BusinessLayer.Clients.accountNumbers();

            foreach (string accNumber in accNumbers)
            {
                cbDepositeAccNum.Items.Add(accNumber);
                cbWithdrawAccNum.Items.Add(accNumber);
                cbTransferAccNumFrom.Items.Add(accNumber);
            }
        }

        ////////////////////////// Start here /////////////////////////
        private void tabControlTransactions_SelectedIndexChanged(object sender, EventArgs e) => resetTransactionsForms();

        ////////////////////////// Deposite /////////////////////////
        private void resetDepositeForm()
        {
            cbDepositeAccNum.Text = null;
            lblDepositeCurrentBalance.ResetText();
            numDepositeAmount.Value = 0;
            label7.Text = null;
            numDepositeAmount.Enabled = false;
            btnDeposit.Enabled = false;
        }
        private void cbDepositeAccNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbDepositeAccNum.Text))
            {
                _clientToUpdate = BusinessLayer.Clients.get(cbDepositeAccNum.SelectedItem.ToString());
                label7.Text = "Current Balance is:";
                lblDepositeCurrentBalance.Text = "$ " + _clientToUpdate.Balance;
                numDepositeAmount.Enabled = true;
            }
        }
        private void numDepositeAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numDepositeAmount.Value < 1)
            {
                e.Cancel = true;
                numDepositeAmount.Focus();
                errProvTransactions.SetError(numDepositeAmount, "Deposit Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numDepositeAmount, "");
                btnDeposit.Enabled = true;
            }
        }
        private void btnDeposit_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to perfoem this transaction?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                BusinessLayer.Transactions.deposit(cbDepositeAccNum.Text, int.Parse(numDepositeAmount.Value.ToString()));
                _clientToUpdate = BusinessLayer.Clients.get(cbDepositeAccNum.SelectedItem.ToString());
                lblDepositeCurrentBalance.Text = "$ " + (_clientToUpdate.Balance);

                MessageBox.Show(
                "Amount has been deposited ($" + numDepositeAmount.Value + ") Successfully",
                "Alarm"
                , MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                numDepositeAmount.Value = 0;
                resetDepositeForm();
            }
        }

        ////////////////////////// Withdraw /////////////////////////
        private void resetWithdrawForm()
        {
            cbWithdrawAccNum.Text = null;
            lblWithdrawCurrentBalance.ResetText();
            label11.Text = null;
            numWithdrawAmount.Value = 0;
            numWithdrawAmount.Enabled = false;
            btnWithdraw.Enabled = false;
        }
        private void comboBoxWithdrawAccountNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbWithdrawAccNum.Text))
            {
                _clientToUpdate = BusinessLayer.Clients.get(cbWithdrawAccNum.SelectedItem.ToString());

                if (_clientToUpdate.Balance == 0)
                {
                    resetWithdrawForm();
                    MessageBox.Show("Empty Balance!!",
                                    "Info",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }

                label11.Text = "Current Balance is:";
                lblWithdrawCurrentBalance.Text = "$ " + _clientToUpdate.Balance;

                numWithdrawAmount.Maximum = int.Parse(_clientToUpdate.Balance.ToString());
                numWithdrawAmount.Value = int.Parse(_clientToUpdate.Balance.ToString());

                numWithdrawAmount.Enabled = true;
            }
        }
        private void numWithdrawAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numWithdrawAmount.Value < 1)
            {
                e.Cancel = true;
                numWithdrawAmount.Focus();
                errProvTransactions.SetError(numWithdrawAmount, "WithDraw Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numWithdrawAmount, "");
                btnWithdraw.Enabled = true;
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to perfoem this transaction?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                BusinessLayer.Transactions.withdraw(cbWithdrawAccNum.Text, int.Parse(numWithdrawAmount.Value.ToString()));
                _clientToUpdate = BusinessLayer.Clients.get(cbWithdrawAccNum.SelectedItem.ToString());

                MessageBox.Show(
                "Amount has been withdrawn ($" + numWithdrawAmount.Value + ") Successfully",
                "Alarm"
                , MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                lblWithdrawCurrentBalance.Text = "$ " + _clientToUpdate.Balance;
                resetWithdrawForm();
            }

        }

        ///////////////////////// Total Balances /////////////////////////
        private void resetTatalBalancesForm()
        {

            refreshTotalBalancesGridView();
            printTotalBalances();
        }
        void refreshTotalBalancesGridView() => dgvTotalBalances.DataSource = BusinessLayer.Clients.get();
        private void printTotalBalances()
        {
            int totalBalances = BusinessLayer.Transactions.totalBalances();

            lblTotalBalancesNumber.Text = "Total Balances is: ($" + totalBalances + ")";
            lblTotalBalancesWord.Text = "( " + BusinessLayer.Transactions.getBalancesWord(totalBalances) + " ) Dollar (s)";
        }

        ////////////////////////// Transfer /////////////////////////
        private void resetTransferForm()
        {
            cbTransferAccNumFrom.Text = null;
            cbTransferAccNumTo.Text = null;
            label10.ResetText();
            label12.ResetText();
            lblTransferCurrentBalanceFrom.ResetText();
            lblTransferCurrentBalanceTo.ResetText();
            numTransferAmount.Value = 0;
            cbTransferAccNumTo.Enabled = false;
            numTransferAmount.Enabled = false;
            btnTransfer.Enabled = false;

        }
        private void cbTransferAccNumFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferAccNumFrom.Text))
            {
                _clientToUpdate = BusinessLayer.Clients.get(cbTransferAccNumFrom.SelectedItem.ToString());

                if (_clientToUpdate.Balance == 0)
                {
                    MessageBox.Show(
                            "Cannot Transfer From Acc. (" + _clientToUpdate.AccountNumber + ") \n" + "Balance is: $0",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

                    resetTransferForm();
                }
                else
                {
                    label12.Text = "Current Balance is:";
                    lblTransferCurrentBalanceFrom.Text = "$ " + _clientToUpdate.Balance;

                    fillTransferCbTransferAccNumTo();
                    cbTransferAccNumTo.Enabled = true;
                }
            }
        }
        private void fillTransferCbTransferAccNumTo()
        {
            cbTransferAccNumTo.Items.Clear();

            List<string> accNums = accNumbers
                .Where(e => e != cbTransferAccNumFrom.Text)
                .ToList();

            foreach (string accNumber in accNums)
                cbTransferAccNumTo.Items.Add(accNumber);
        }
        private void cbTransferAccNumTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbTransferAccNumTo.Text))
            {
                label10.Text = "Current Balance is:";
                lblTransferCurrentBalanceTo.Text = "$ " + BusinessLayer.Clients.get(cbTransferAccNumTo.SelectedItem.ToString()).Balance;

                numTransferAmount.Maximum = _clientToUpdate.Balance;
                numTransferAmount.Value = _clientToUpdate.Balance;
                numTransferAmount.Enabled = true;
            }

        }
        private void numTransferAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (numTransferAmount.Value < 1)
            {
                e.Cancel = true;
                numWithdrawAmount.Focus();
                errProvTransactions.SetError(numTransferAmount, "Transfer Amount Must be Greater Than $0");
            }
            else
            {
                e.Cancel = false;
                errProvTransactions.SetError(numTransferAmount, "");
                btnTransfer.Enabled = true;
            }
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to perfoem this transaction?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {
                BusinessLayer.Transactions.transfer(int.Parse(numTransferAmount.Value.ToString()), cbTransferAccNumFrom.Text, cbTransferAccNumTo.Text);
                Client toClient = BusinessLayer.Clients.get(cbTransferAccNumTo.SelectedItem.ToString());

                ClientTransfer clientsTransferLog = new ClientTransfer(
                    int.Parse(numTransferAmount.Value.ToString()),
                     _clientToUpdate.AccountNumber,
                     toClient.AccountNumber);

                BusinessLayer.Transactions.addTransferBalanceLog(clientsTransferLog);


                MessageBox.Show(
                "Transfer Done Successfully",
                "Alarm",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


                resetTransferForm();
            }
        }

        ////////////////////////// Transfer Log /////////////////////////
        private void resetTransferLogForm() => refreshTransferLogDgv();
        private void refreshTransferLogDgv() => dgvTransferLog.DataSource = BusinessLayer.Transactions.transferLog();
    }
}