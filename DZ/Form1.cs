using System;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    // Класс формы, отвечающий за логику конвертера валют
    public partial class Form1 : Form
    {
        // Константы для курсов валют, где базовая валюта - рубль (RUB)
        const double RUB_TO_USD = 0.0097; // 1 RUB = 0.0097 USD
        const double RUB_TO_EUR = 0.0094; // 1 RUB = 0.0094 EUR
        const double RUB_TO_CNY = 0.071;  // 1 RUB = 0.071 CNY
        const double RUB_TO_INR = 0.84;   // 1 RUB = 0.84 INR
        const double RUB_TO_GBP = 0.0079; // 1 RUB = 0.0079 GBP

        // Конструктор формы
        public Form1()
        {
            InitializeComponent(); // Инициализация компонентов формы (например, кнопки, текстовые поля и т.д.)
        }

        // Обработчик события нажатия кнопки для конвертации валют
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // Преобразуем введенную сумму в рублях в число типа double
                double rubAmount = Convert.ToDouble(txtAmount.Text);

                // Переменная для хранения конвертированной суммы
                double convertedAmount = 0;

                // Получаем выбранную валюту из выпадающего списка (ComboBox)
                string currency = cmbCurrency.SelectedItem.ToString();

                // Выбираем курс конверсии в зависимости от выбранной валюты
                switch (currency)
                {
                    case "USD": // Если выбрана валюта USD (доллар США)
                        convertedAmount = rubAmount * RUB_TO_USD; // Конвертируем рубли в доллары
                        break;
                    case "EUR": // Если выбрана валюта EUR (евро)
                        convertedAmount = rubAmount * RUB_TO_EUR; // Конвертируем рубли в евро
                        break;
                    case "CNY": // Если выбрана валюта CNY (китайский юань)
                        convertedAmount = rubAmount * RUB_TO_CNY; // Конвертируем рубли в юани
                        break;
                    case "INR": // Если выбрана валюта INR (индийская рупия)
                        convertedAmount = rubAmount * RUB_TO_INR; // Конвертируем рубли в рупии
                        break;
                    case "GBP": // Если выбрана валюта GBP (фунт стерлингов)
                        convertedAmount = rubAmount * RUB_TO_GBP; // Конвертируем рубли в фунты
                        break;
                    // В случае, если валюта не была выбрана
                    default:
                        MessageBox.Show("Выберите валюту.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Прерываем выполнение функции, если валюта не выбрана
                }

                // Отображаем результат в метке (Label) с двумя знаками после запятой
                lblResult.Text = $"Результат: {convertedAmount:F2} {currency}";
            }
            // Если произошла ошибка при попытке преобразования введенной суммы в число
            catch (FormatException)
            {
                // Показать сообщение об ошибке ввода
                MessageBox.Show("Введите корректную сумму.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
