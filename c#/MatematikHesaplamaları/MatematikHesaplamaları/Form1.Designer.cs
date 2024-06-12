namespace MatematikHesaplamaları
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
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            labelAlan = new Label();
            labelCevre = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            button4 = new Button();
            labelUyari = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.Location = new Point(163, 62);
            button1.Name = "button1";
            button1.Size = new Size(127, 68);
            button1.TabIndex = 0;
            button1.Text = "Kare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.Location = new Point(549, 62);
            button2.Name = "button2";
            button2.Size = new Size(133, 68);
            button2.TabIndex = 1;
            button2.Text = "Dikdörtgen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(19, 44);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 2;
            label1.Text = "Bir kenarı giriniz:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(194, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 34);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.Location = new Point(513, 231);
            button3.Name = "button3";
            button3.Size = new Size(116, 53);
            button3.TabIndex = 4;
            button3.Text = "Hesapla";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(592, 318);
            label2.Name = "label2";
            label2.Size = new Size(55, 28);
            label2.TabIndex = 5;
            label2.Text = "Alan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(592, 373);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 6;
            label3.Text = "Çevre:";
            // 
            // labelAlan
            // 
            labelAlan.AutoSize = true;
            labelAlan.Font = new Font("Segoe UI", 15F);
            labelAlan.Location = new Point(679, 318);
            labelAlan.Name = "labelAlan";
            labelAlan.Size = new Size(34, 28);
            labelAlan.TabIndex = 7;
            labelAlan.Text = "00";
            // 
            // labelCevre
            // 
            labelCevre.AutoSize = true;
            labelCevre.Font = new Font("Segoe UI", 15F);
            labelCevre.Location = new Point(679, 373);
            labelCevre.Name = "labelCevre";
            labelCevre.Size = new Size(34, 28);
            labelCevre.TabIndex = 8;
            labelCevre.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(19, 112);
            label4.Name = "label4";
            label4.Size = new Size(114, 28);
            label4.TabIndex = 9;
            label4.Text = "Uzun kenar:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(194, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 34);
            textBox2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(55, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 193);
            panel1.TabIndex = 11;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.Location = new Point(659, 231);
            button4.Name = "button4";
            button4.Size = new Size(116, 53);
            button4.TabIndex = 12;
            button4.Text = "Hesapla";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // labelUyari
            // 
            labelUyari.AutoSize = true;
            labelUyari.Font = new Font("Segoe UI", 15F);
            labelUyari.Location = new Point(312, 475);
            labelUyari.Name = "labelUyari";
            labelUyari.Size = new Size(0, 28);
            labelUyari.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(840, 669);
            Controls.Add(labelUyari);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(labelCevre);
            Controls.Add(labelAlan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label labelAlan;
        private Label labelCevre;
        private Label label4;
        private TextBox textBox2;
        private Panel panel1;
        private Button button4;
        private Label labelUyari;
    }
}
