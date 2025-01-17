namespace CurrencyConverterApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAmountPrompt;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtAmount = new TextBox();
            cmbCurrency = new ComboBox();
            btnConvert = new Button();
            lblResult = new Label();
            lblAmountPrompt = new Label();
            SuspendLayout();
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(12, 40);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 0;
            // 
            // cmbCurrency
            // 
            cmbCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Items.AddRange(new object[] { "USD", "EUR", "CNY", "INR", "GBP" });
            cmbCurrency.Location = new Point(12, 70);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(121, 23);
            cmbCurrency.TabIndex = 1;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(12, 100);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(121, 23);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "Конвертировать";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 130);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(63, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Результат:";
            // 
            // lblAmountPrompt
            // 
            lblAmountPrompt.AutoSize = true;
            lblAmountPrompt.Location = new Point(12, 12);
            lblAmountPrompt.Name = "lblAmountPrompt";
            lblAmountPrompt.Size = new Size(148, 15);
            lblAmountPrompt.TabIndex = 4;
            lblAmountPrompt.Text = "Введите сумму (в рублях)";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 161);
            Controls.Add(lblResult);
            Controls.Add(btnConvert);
            Controls.Add(cmbCurrency);
            Controls.Add(txtAmount);
            Controls.Add(lblAmountPrompt);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Конвертер валют";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
