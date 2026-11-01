using System.Drawing.Design;
using System.Windows.Forms;
using static CurrencyConverter.ConverterAPIService;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        private readonly ConverterAPIService converterService = new();
        public Form1()
        {
            InitializeComponent();

            amountBox.DecimalPlaces = 2;
            amountBox.Minimum = 0;
            amountBox.Maximum = 999999999;
            amountBox.Increment = 0.01m;
            amountBox.Value = 100m;
        }

        private async void Form1_Shown(object? sender, EventArgs e)
        {
            try
            {
                var currencies = await converterService.GetCurrencies();

                currencyFrom.DataSource = currencies.ToArray();
                currencyFrom.DisplayMember = "name";
                currencyFrom.ValueMember = "iso_code";
                currencyFrom.SelectedValue = "RUB";

                currencyTo.DataSource = currencies.ToArray();
                currencyTo.DisplayMember = "name";
                currencyTo.ValueMember = "iso_code";
                currencyTo.SelectedValue = "USD";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки валют: {ex.Message}");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            decimal amount = amountBox.Value;

            if (currencyFrom.SelectedValue is not string from ||
                currencyTo.SelectedValue is not string to)
            {
                MessageBox.Show("Choise the currency");
                return;
            }

            button1.Enabled = false;
            result.Text = "Wait a cent...";

            try
            {
                var result_data = await converterService.ConvertAsync(amount, from, to);
                result.Text = $"{result_data.amount}\n\tby {result_data?.Date}";
            }
            catch (Exception ex)
            {
                result.Text = "Plrase try again later";
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
