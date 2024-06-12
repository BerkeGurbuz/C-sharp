namespace KayıtRehberi
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            adSoyadLabel = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            telefonLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            adresLabel = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            sehirLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(102, 355);
            button1.Name = "button1";
            button1.Size = new Size(83, 31);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(60, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(145, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 29);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(504, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Ad Soyad:";
            // 
            // adSoyadLabel
            // 
            adSoyadLabel.AutoSize = true;
            adSoyadLabel.Font = new Font("Segoe UI", 12F);
            adSoyadLabel.Location = new Point(589, 56);
            adSoyadLabel.Name = "adSoyadLabel";
            adSoyadLabel.Size = new Size(28, 21);
            adSoyadLabel.TabIndex = 4;
            adSoyadLabel.Text = "00";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(145, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 29);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(60, 101);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 5;
            label3.Text = "Telefon:";
            label3.Click += label3_Click;
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Font = new Font("Segoe UI", 12F);
            telefonLabel.Location = new Point(589, 98);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new Size(28, 21);
            telefonLabel.TabIndex = 8;
            telefonLabel.Text = "00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(504, 98);
            label5.Name = "label5";
            label5.Size = new Size(62, 21);
            label5.TabIndex = 7;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(60, 148);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 9;
            label4.Text = "Şehir:";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Samsun", "Sakarya", "İstanbul", "Ankara", "İzmir" });
            comboBox1.Location = new Point(145, 145);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 29);
            comboBox1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(504, 136);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 11;
            label6.Text = "Şehir:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.Font = new Font("Segoe UI", 12F);
            adresLabel.Location = new Point(589, 174);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new Size(28, 21);
            adresLabel.TabIndex = 12;
            adresLabel.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(60, 195);
            label7.Name = "label7";
            label7.Size = new Size(53, 21);
            label7.TabIndex = 13;
            label7.Text = "Adres:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(145, 192);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 83);
            textBox3.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(504, 174);
            label8.Name = "label8";
            label8.Size = new Size(53, 21);
            label8.TabIndex = 15;
            label8.Text = "Adres:";
            // 
            // sehirLabel
            // 
            sehirLabel.AutoSize = true;
            sehirLabel.Font = new Font("Segoe UI", 12F);
            sehirLabel.Location = new Point(589, 136);
            sehirLabel.Name = "sehirLabel";
            sehirLabel.Size = new Size(28, 21);
            sehirLabel.TabIndex = 16;
            sehirLabel.Text = "00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(sehirLabel);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(adresLabel);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(telefonLabel);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(adSoyadLabel);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label adSoyadLabel;
        private TextBox textBox2;
        private Label label3;
        private Label telefonLabel;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private Label label6;
        private Label adresLabel;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private Label sehirLabel;
    }
}
