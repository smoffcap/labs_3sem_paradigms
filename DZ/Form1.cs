using System;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class Form1 : Form
    {
        const double RUB_TO_USD = 0.0097;
        const double RUB_TO_EUR = 0.0094;
        const double RUB_TO_CNY = 0.071;
        const double RUB_TO_INR = 0.84;
        const double RUB_TO_GBP = 0.0079;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double rubAmount = Convert.ToDouble(txtAmount.Text);

                double convertedAmount = 0;
                string currency = cmbCurrency.SelectedItem.ToString();

                switch (currency)
                {
                    case "USD":
                        convertedAmount = rubAmount * RUB_TO_USD;
                        break;
                    case "EUR":
                        convertedAmount = rubAmount * RUB_TO_EUR;
                        break;
                    case "CNY":
                        convertedAmount = rubAmount * RUB_TO_CNY;
                        break;
                    case "INR":
                        convertedAmount = rubAmount * RUB_TO_INR;
                        break;
                    case "GBP":
                        convertedAmount = rubAmount * RUB_TO_GBP;
                        break;
                    default:
                        MessageBox.Show("Выберите валюту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                lblResult.Text = $"Результат: {convertedAmount:F2} {currency}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректную сумму.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
