namespace HesapMakinesi
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
            buttonHesapla = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(377, 83);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(123, 61);
            buttonHesapla.TabIndex = 0;
            buttonHesapla.Text = "Topla";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(110, 73);
            label1.Name = "label1";
            label1.Size = new Size(63, 28);
            label1.TabIndex = 1;
            label1.Text = "Sayı1:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(205, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(205, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 34);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(110, 133);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 3;
            label2.Text = "Sayı2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(622, 83);
            label3.Name = "label3";
            label3.Size = new Size(70, 28);
            label3.TabIndex = 5;
            label3.Text = "Sonuç:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(715, 83);
            label4.Name = "label4";
            label4.Size = new Size(34, 28);
            label4.TabIndex = 6;
            label4.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(715, 266);
            label5.Name = "label5";
            label5.Size = new Size(34, 28);
            label5.TabIndex = 13;
            label5.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(622, 266);
            label6.Name = "label6";
            label6.Size = new Size(70, 28);
            label6.TabIndex = 12;
            label6.Text = "Sonuç:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(205, 310);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 34);
            textBox3.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(110, 316);
            label7.Name = "label7";
            label7.Size = new Size(63, 28);
            label7.TabIndex = 10;
            label7.Text = "Sayı2:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(205, 250);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 34);
            textBox4.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(110, 256);
            label8.Name = "label8";
            label8.Size = new Size(63, 28);
            label8.TabIndex = 8;
            label8.Text = "Sayı1:";
            // 
            // button1
            // 
            button1.Location = new Point(377, 266);
            button1.Name = "button1";
            button1.Size = new Size(123, 61);
            button1.TabIndex = 7;
            button1.Text = "Çarp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1156, 620);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(buttonHesapla);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonHesapla;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private Button button1;
    }
}
