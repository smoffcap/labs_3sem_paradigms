namespace CurrencyConverterApp
{
    // Частичная форма Form1 для конвертера валют
    public partial class Form1
    {
        // Определение компонентов формы
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;  // Поле для ввода суммы в рублях
        private System.Windows.Forms.ComboBox cmbCurrency; // Выпадающий список для выбора валюты
        private System.Windows.Forms.Button btnConvert; // Кнопка для конвертации
        private System.Windows.Forms.Label lblResult; // Метка для отображения результата
        private System.Windows.Forms.Label lblAmountPrompt; // Метка с подсказкой "Введите сумму (в рублях)"

        // Этот метод используется для корректного освобождения ресурсов при закрытии формы
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();  // Очистка всех компонентов, если они существуют
            }
            base.Dispose(disposing);  // Вызов базового метода Dispose
        }

        // Инициализация всех компонентов формы
        private void InitializeComponent()
        {
            // Загрузка ресурсов, включая иконку приложения
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            // Инициализация компонентов формы
            txtAmount = new TextBox(); // Поле для ввода суммы
            cmbCurrency = new ComboBox(); // Выпадающий список для выбора валюты
            btnConvert = new Button(); // Кнопка для конвертации валюты
            lblResult = new Label(); // Метка для отображения результата
            lblAmountPrompt = new Label(); // Метка с подсказкой для ввода суммы

            // Настройка размеров и параметров компонентов формы
            SuspendLayout();  // Приостановка обновлений интерфейса, чтобы все изменения применялись одновременно

            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 40);  // Установка координат на форме (отступы по X и Y)
            txtAmount.Name = "txtAmount";  // Имя компонента
            txtAmount.Size = new Size(200, 23);  // Размеры поля (ширина и высота)
            txtAmount.TabIndex = 0;  // Индекс табуляции, чтобы при нажатии Tab можно было перемещаться по компонентам
            // 
            // cmbCurrency
            // 
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;  // Настройка списка на "Только для выбора" (без ввода)
            cmbCurrency.FormattingEnabled = true;  // Разрешение на отображение элементов списка
            // Список валют для выбора
            cmbCurrency.Items.AddRange(new object[] { "USD", "EUR", "CNY", "INR", "GBP" });
            cmbCurrency.Location = new Point(12, 70);  // Установка координат для выпадающего списка
            cmbCurrency.Name = "cmbCurrency";  // Имя компонента
            cmbCurrency.Size = new Size(121, 23);  // Размеры комбобокса
            cmbCurrency.TabIndex = 1;  // Индекс табуляции для комбобокса
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 100);  // Установка координат кнопки
            btnConvert.Name = "btnConvert";  // Имя кнопки
            btnConvert.Size = new Size(121, 23);  // Размер кнопки
            btnConvert.TabIndex = 2;  // Индекс табуляции для кнопки
            btnConvert.Text = "Конвертировать";  // Текст на кнопке
            btnConvert.UseVisualStyleBackColor = true;  // Применение стандартного стиля
            btnConvert.Click += btnConvert_Click;  // Привязка события нажатия кнопки к обработчику btnConvert_Click

            // 
            // lblResult
            // 
            lblResult.AutoSize = true;  // Автоматическое изменение размера метки по содержимому
            lblResult.Location = new Point(12, 130);  // Установка координат метки для результата
            lblResult.Name = "lblResult";  // Имя метки
            lblResult.Size = new Size(63, 15);  // Размер метки
            lblResult.TabIndex = 3;  // Индекс табуляции для метки
            lblResult.Text = "Результат:";  // Текст, который будет отображаться на метке

            // 
            // lblAmountPrompt
            // 
            lblAmountPrompt.AutoSize = true;  // Автоматическое изменение размера метки
            lblAmountPrompt.Location = new Point(12, 12);  // Установка координат для подсказки
            lblAmountPrompt.Name = "lblAmountPrompt";  // Имя метки
            lblAmountPrompt.Size = new Size(148, 15);  // Размер метки
            lblAmountPrompt.TabIndex = 4;  // Индекс табуляции для метки
            lblAmountPrompt.Text = "Введите сумму (в рублях)";  // Текст, который будет отображаться на метке подсказки

            // 
            // Form1
            // 
            ClientSize = new Size(284, 161);  // Размер всей формы (ширина и высота)
            Controls.Add(lblResult);  // Добавление метки для результата на форму
            Controls.Add(btnConvert);  // Добавление кнопки на форму
            Controls.Add(cmbCurrency);  // Добавление выпадающего списка на форму
            Controls.Add(txtAmount);  // Добавление текстового поля на форму
            Controls.Add(lblAmountPrompt);  // Добавление метки подсказки на форму
            Icon = (Icon)resources.GetObject("$this.Icon");  // Установка иконки для формы из ресурсов
            Name = "Form1";  // Имя формы
            Text = "Конвертер валют";  // Заголовок формы
            ResumeLayout(false);  // Возобновление обновлений интерфейса
            PerformLayout();  // Применение всех изменений к компонентам формы
        }
    }
}
