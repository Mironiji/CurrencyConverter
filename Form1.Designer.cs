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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Font = new Font("MV Boli", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 457);
            button1.Name = "button1";
            button1.Size = new Size(270, 68);
            button1.TabIndex = 0;
            button1.Text = "CONVERT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(71, 324);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(221, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(224, 224, 224);
            label1.Font = new Font("MV Boli", 11.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 341);
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
            label2.Location = new Point(165, 240);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "FROM";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(223, 238);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(69, 27);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(223, 281);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(69, 27);
            comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(187, 283);
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
            pictureBox1.Location = new Point(22, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 201);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 396);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 8;
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(327, 546);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
    }
}
