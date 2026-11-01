namespace CurrencyConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            currencyFrom = new ComboBox();
            currencyTo = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            result = new Label();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            amountBox = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amountBox).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 456);
            button1.Name = "button1";
            button1.Size = new Size(270, 68);
            button1.TabIndex = 0;
            button1.Text = "CONVERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("MV Boli", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 331);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "SUM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(224, 224, 224);
            label2.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 240);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "FROM";
            label2.Click += label2_Click;
            // 
            // currencyFrom
            // 
            currencyFrom.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currencyFrom.FormattingEnabled = true;
            currencyFrom.Location = new Point(87, 240);
            currencyFrom.Name = "currencyFrom";
            currencyFrom.Size = new Size(212, 28);
            currencyFrom.TabIndex = 4;
            // 
            // currencyTo
            // 
            currencyTo.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currencyTo.FormattingEnabled = true;
            currencyTo.Location = new Point(87, 283);
            currencyTo.Name = "currencyTo";
            currencyTo.Size = new Size(212, 28);
            currencyTo.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 283);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 6;
            label3.Text = "TO";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.moneyMan;
            pictureBox1.Image = Properties.Resources.moneyMan1;
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = Properties.Resources.moneyMan;
            pictureBox1.Location = new Point(29, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 201);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            result.Location = new Point(29, 371);
            result.Name = "result";
            result.Size = new Size(0, 28);
            result.TabIndex = 8;
            result.Click += label4_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(185, 527);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 9;
            label4.Text = "(c) Mironiji, 2026";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // amountBox
            // 
            amountBox.Font = new Font("Mongolian Baiti", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountBox.Location = new Point(87, 330);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(212, 29);
            amountBox.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(327, 548);
            Controls.Add(amountBox);
            Controls.Add(label4);
            Controls.Add(result);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(currencyTo);
            Controls.Add(currencyFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Currency Converter";
            Load += Form1_Load;
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amountBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox currencyFrom;
        private ComboBox currencyTo;
        private Label label3;
        private PictureBox pictureBox1;
        private Label result;
        private Label label4;
        private ErrorProvider errorProvider1;
        private NumericUpDown amountBox;
    }
}
