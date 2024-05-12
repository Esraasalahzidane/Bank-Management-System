using Bank.Shared;
using Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bank.Views.Clients
{
    public partial class FrmClients : FrmLayout
    {
        List<string> accNumbers = new List<string>();
        Client _clientToUpdate;
        public FrmClients() : base("Clients")
        {
            InitializeComponent();
            refreshClientsGrigView();
        }
        ////////////////////////// Start Here /////////////////////////
        private void clientsTabControles_SelectedIndexChanged(object sender, EventArgs e) => resetClientsForms();

        ////////////////////////// Shared /////////////////////////
        private void resetClientsForms()
        {
            refreshClientsGrigView();
            resetAddNewClientForm();
            resetUpdateClientForm();
        }
        private void validateClientForm(TextBox textBox, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "required");
            }
            else if (textBox.Name == "txtAddNewClientAccountNumber" && BusinessLayer.Clients.isExsist(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Account Number (" + textBox.Text + ") is already used, Choose another one.");
            }
            else if ((textBox.Name == "txtAddNewClientEmail" || textBox.Name == "txtUpdateClientEmail") && !textBox.Text.Contains("@"))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Email, Include an '@' in the email address");
            }
            else if ((textBox.Name == "txtAddNewClientPhone" || textBox.Name == "txtUpdateClientPhone") && !textBox.Text.All(char.IsDigit))
            {
                e.Cancel = true;
                textBox.Focus();
                clientInfoErrorProvider.SetError(textBox, "Invalid Phone, Only Numbers Accepted");
            }
            else
            {
                e.Cancel = false;
                clientInfoErrorProvider.SetError(textBox, null);
            }

            updateProgressBarAddNewClient(addNewClientValidFormInputsCount());
        }
        private void validateClientForm(object sender, CancelEventArgs e) => validateClientForm((TextBox)sender, e);

        ////////////////////////// Show Clients /////////////////////////
        public void refreshClientsGrigView() => dgvClients.DataSource = BusinessLayer.Clients.get();
        private void depositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions frmTransactions = new Transactions(0, dgvClients.SelectedCells[0].Value.ToString());
            frmTransactions.ShowDialog();
            resetClientsForms();
        }
        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions frmTransactions = new Transactions(1, dgvClients.SelectedCells[0].Value.ToString());
            frmTransactions.ShowDialog();
            resetClientsForms();
        }
        private void transferBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions frmTransactions = new Transactions(3, dgvClients.SelectedCells[0].Value.ToString());
            frmTransactions.ShowDialog();
            resetClientsForms();
        }
        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                          "Are you sure to Delete Acc. (" + dgvClients.SelectedCells[0].Value.ToString() + ")?",
                          "Confirm"
                          , MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Question) == DialogResult.OK)
            {
                BusinessLayer.Clients.delete(dgvClients.SelectedCells[0].Value.ToString());

                MessageBox.Show("Client (" + dgvClients.SelectedCells[0].Value.ToString() + ") Deleted Successfully",
                 "Info",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Information);

                refreshClientsGrigView();
            }
        }

        ////////////////////////// Add New Client /////////////////////////
        private void resetAddNewClientForm()
        {
            txtAddNewClientAccountNumber.Clear();
            txtAddNewClientPinCode.Clear();
            txtAddNewClientFirstName.Clear();
            txtAddNewClientLastName.Clear();
            txtAddNewClientEmail.Clear();
            txtAddNewClientPhone.Clear();
            numAddNewClientBalance.Value = 0;
            circularProgressBarAddNewClient.Value = 0;
            circularProgressBarAddNewClient.Text = "0%";
            btnAddNewClient.Enabled = false;
        }
        private Client getClientInfo() =>
                 new Client(txtAddNewClientAccountNumber.Text.Trim(),
                 txtAddNewClientPinCode.Text.Trim(),
                 txtAddNewClientFirstName.Text.Trim(),
                 txtAddNewClientLastName.Text.Trim(),
                 txtAddNewClientEmail.Text.Trim(),
                 txtAddNewClientPhone.Text.Trim(),
                 int.Parse(numAddNewClientBalance.Text));
        private int addNewClientValidFormInputsCount()
        {
            int counter = 0;

            if (!String.IsNullOrWhiteSpace(txtAddNewClientAccountNumber.Text) && !BusinessLayer.Clients.isExsist(txtAddNewClientAccountNumber.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewClientPinCode.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewClientFirstName.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewClientLastName.Text))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewClientEmail.Text) &&
                txtAddNewClientEmail.Text.Contains("@"))
                counter++;
            if (!String.IsNullOrWhiteSpace(txtAddNewClientPhone.Text) &&
                txtAddNewClientPhone.Text.All(char.IsDigit))
                counter++;

            return counter;
        }
        private void updateProgressBarAddNewClient(int value)
        {
            circularProgressBarAddNewClient.Value = value;
            circularProgressBarAddNewClient.Text = (((float)circularProgressBarAddNewClient.Value / circularProgressBarAddNewClient.Maximum) * 100).ToString("0") + "%";
            circularProgressBarAddNewClient.ProgressColor = Color.FromArgb(192, 192, 255);
            circularProgressBarAddNewClient.Refresh();

            checkBtnAddNewClientStatus();
        }
        private void checkBtnAddNewClientStatus()
        {
            if (circularProgressBarAddNewClient.Value == 6)
                btnAddNewClient.Enabled = true;
            else
                btnAddNewClient.Enabled = false;
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                            "Are you sure to Add Client (" + txtAddNewClientFirstName.Text + ")?",
                            "Confirm"
                            , MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK)
            {
                BusinessLayer.Clients.post(getClientInfo());

                MessageBox.Show("Client (" + txtAddNewClientAccountNumber.Text + ") Added Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetAddNewClientForm();
            }
        }

        ////////////////////////// Update Client /////////////////////////
        private void resetUpdateClientForm()
        {
            changeUpdateClientFormInputsStatus(false);
            txtUpdateClientPinCode.Clear();
            txtUpdateClientFirstName.Clear();
            txtUpdateClientLastName.Clear();
            txtUpdateClientEmail.Clear();
            txtUpdateClientPhone.Clear();
            numUpdateClientBalance.Value = 0;
            btnUpdateClient.Enabled = false;
            fillComboBoxUpdateClientAccNumbers();
        }
        private void changeUpdateClientFormInputsStatus(bool status)
        {
            txtUpdateClientPinCode.Enabled = status;
            txtUpdateClientFirstName.Enabled = status;
            txtUpdateClientLastName.Enabled = status;
            txtUpdateClientEmail.Enabled = status;
            txtUpdateClientPhone.Enabled = status;
            numUpdateClientBalance.Enabled = status;
        }
        private void fillComboBoxUpdateClientAccNumbers()
        {
            cbUpdateClientAccNum.Items.Clear();
            accNumbers = BusinessLayer.Clients.accountNumbers();

            foreach (string accNumber in accNumbers)
                cbUpdateClientAccNum.Items.Add(accNumber);
        }
        private void fillUpdateClientFormWithSelectedClient()
        {
            txtUpdateClientPinCode.Text = _clientToUpdate.PinCode;
            txtUpdateClientFirstName.Text = _clientToUpdate.FirstName;
            txtUpdateClientLastName.Text = _clientToUpdate.LastName;
            txtUpdateClientEmail.Text = _clientToUpdate.Email;
            txtUpdateClientPhone.Text = _clientToUpdate.Phone;
            numUpdateClientBalance.Text = _clientToUpdate.Balance.ToString();
        }
        private void cbUpdateClientAccNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clientToUpdate = BusinessLayer.Clients.get(cbUpdateClientAccNum.SelectedItem.ToString());
            fillUpdateClientFormWithSelectedClient();
            changeUpdateClientFormInputsStatus(true);
            btnUpdateClient.Enabled = true;
        }
        private Client getUpdatedClientInfo() => new Client(
                    cbUpdateClientAccNum.Text,
                    txtUpdateClientPinCode.Text,
                    txtUpdateClientFirstName.Text,
                    txtUpdateClientLastName.Text,
                    txtUpdateClientEmail.Text,
                    txtUpdateClientPhone.Text,
                    int.Parse(numUpdateClientBalance.Text));
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to Update Client (" + txtUpdateClientFirstName.Text + ")?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {

                BusinessLayer.Clients.update(getUpdatedClientInfo());

                MessageBox.Show("Client (" + txtUpdateClientFirstName.Text + ") Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetClientsForms();
            }
        }
    }
}