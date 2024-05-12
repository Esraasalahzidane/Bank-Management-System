using Bank.Shared;
using Shared.ModelViews;
using System;
using System.Windows.Forms;

namespace Bank.Views
{
    public partial class Currencies : FrmLayout
    {
        CountryCurrency currencyToUpdate;
        public Currencies() : base("Currency Exchange")
        {
            InitializeComponent();
            resetCurrencyExchangeForms();
        }
        ////////////////////////// Start Here /////////////////////////
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) => resetCurrencyExchangeForms();

        ////////////////////////// Shared /////////////////////////
        private void resetCurrencyExchangeForms()
        {
            refreshCurrencies();
            resetUpdateRateForm();
            resetCurrencyCalculatorForm();
        }

        ////////////////////////// Show Currency Exhange /////////////////////////
        private void refreshCurrencies() => dgvClients.DataSource = BusinessLayer.Currencies.get();


        ////////////////////////// Update Rate /////////////////////////
        private void resetUpdateRateForm()
        {
            cbUpdateRateCurrencyCode.ResetText();
            numUpdateRate.Value = 0;
            lblCurrenyInfo.ResetText();
            btnUpdateRate.Enabled = false;
            cbUpdateRateCurrencyCode.DataSource = BusinessLayer.Currencies.getCodes();
        }
        private string getCurrencyDetails(CountryCurrency countryCurrency) =>
             "Name: " + countryCurrency.Currency + "\n" +
             "Country: " + countryCurrency.Country + "\n" +
             "Rate(" + countryCurrency.ExchangeRateUSD + "$)";
        private void cbUpdateRateCurrencyCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyToUpdate = BusinessLayer.Currencies.get(cbUpdateRateCurrencyCode.SelectedItem.ToString());
            numUpdateRate.Value = decimal.Parse(currencyToUpdate.ExchangeRateUSD.ToString());
            lblCurrenyInfo.Text = getCurrencyDetails(currencyToUpdate);
            btnUpdateRate.Enabled = true;
        }
        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                           "Are you sure to perfoem this transaction?",
                           "Confirm"
                           , MessageBoxButtons.OKCancel,
                           MessageBoxIcon.Question) == DialogResult.OK)
            {
                currencyToUpdate.ExchangeRateUSD = numUpdateRate.Value;
                BusinessLayer.Currencies.update(currencyToUpdate);

                MessageBox.Show("Currency (" + cbUpdateRateCurrencyCode.SelectedItem.ToString() + ") Updated Successfully",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetUpdateRateForm();
            }
        }

        ////////////////////////// Currency Calculator /////////////////////////
        private void resetCurrencyCalculatorForm()
        {
            cbCurrencyCalculaterFromCountryCode.ResetText();
            cbCurrencyCalculaterToCountryCode.ResetText();
            cbCurrencyCalculaterToCountryCode.Enabled = false;
            numCurrencyCalcAmountToExchange.Enabled = false;
            numCurrencyCalcAmountToExchange.Value = 0;
            cbCurrencyCalculaterFromCountryCode.DataSource = BusinessLayer.Currencies.getCodes();
            cbCurrencyCalculaterToCountryCode.DataSource = BusinessLayer.Currencies.getCodes();
            btnCurrencyCalcConvert.Enabled = false;

            if (tabControlCurrencyExchange.SelectedIndex != 2)
                lblAmountExchange.ResetText();
        }

        private void cbCurrencyCalculaterCurrencyCodeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrenyCalculaterCurrencyFromInfo.Text = getCurrencyDetails(BusinessLayer.Currencies.get(cbCurrencyCalculaterFromCountryCode.SelectedItem.ToString()));
            cbCurrencyCalculaterToCountryCode.Enabled = true;
        }
        private void cbCurrencyCalculaterCurrencyCodeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCurrenyCalculaterCurrencyToInfo.Text = getCurrencyDetails(BusinessLayer.Currencies.get(cbCurrencyCalculaterToCountryCode.SelectedItem.ToString()));
            numCurrencyCalcAmountToExchange.Enabled = true;
        }
        private void numCurrencyCalcAmountToExchange_ValueChanged(object sender, EventArgs e)
        {
            btnCurrencyCalcConvert.Enabled = true;
        }
        private void btnCurrencyCalcConvert_Click(object sender, EventArgs e)
        {
            lblAmountExchange.Text =
                numCurrencyCalcAmountToExchange.Value + " " +
                BusinessLayer.Currencies.get(cbCurrencyCalculaterFromCountryCode.Text).Code + " = " +
                BusinessLayer.Currencies.calculater(cbCurrencyCalculaterFromCountryCode.Text, cbCurrencyCalculaterToCountryCode.Text, decimal.Parse(numCurrencyCalcAmountToExchange.Value.ToString())) + " " +
                BusinessLayer.Currencies.get(cbCurrencyCalculaterToCountryCode.Text).Code;

            resetCurrencyCalculatorForm();
        }
    }
}