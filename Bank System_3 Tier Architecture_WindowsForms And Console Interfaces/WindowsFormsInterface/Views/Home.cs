using Bank.Views;
using Bank.Views.Clients;
using System;

namespace Bank.Shared
{
    public partial class Home : FrmLayout
    {
        public Home() : base("Home")
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            FrmClients frmClientsHome = new FrmClients();
            frmClientsHome.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Transactions frmTransactions = new Transactions();
            frmTransactions.ShowDialog();
        }
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Users frmManageUsers = new Users();
            frmManageUsers.ShowDialog();
        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            Currencies frmCurrencyExchange = new Currencies();
            frmCurrencyExchange.ShowDialog();
        }
    }
}