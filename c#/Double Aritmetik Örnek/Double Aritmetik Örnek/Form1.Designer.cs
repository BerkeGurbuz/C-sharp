namespace Double_Aritmetik_Örnek
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
            labelSayi1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelSayi2 = new Label();
            label1 = new Label();
            labelToplam = new Label();
            label3 = new Label();
            labelFark = new Label();
            label5 = new Label();
            labelCarpim = new Label();
            label7 = new Label();
            labelBolum = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(286, 356);
            button1.Name = "button1";
            button1.Size = new Size(157, 75);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelSayi1
            // 
            labelSayi1.AutoSize = true;
            labelSayi1.Font = new Font("Segoe UI", 15F);
            labelSayi1.Location = new Point(182, 80);
            labelSayi1.Name = "labelSayi1";
            labelSayi1.Size = new Size(63, 28);
            labelSayi1.TabIndex = 1;
            labelSayi1.Text = "1.Sayı";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(266, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(266, 130);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 34);
            textBox2.TabIndex = 4;
            // 
            // labelSayi2
            // 
            labelSayi2.AutoSize = true;
            labelSayi2.Font = new Font("Segoe UI", 15F);
            labelSayi2.Location = new Point(182, 133);
            labelSayi2.Name = "labelSayi2";
            labelSayi2.Size = new Size(63, 28);
            labelSayi2.TabIndex = 3;
            labelSayi2.Text = "2.Sayı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(55, 246);
            label1.Name = "label1";
            label1.Size = new Size(80, 28);
            label1.TabIndex = 5;
            label1.Text = "Toplam:";
            // 
            // labelToplam
            // 
            labelToplam.AutoSize = true;
            labelToplam.Font = new Font("Segoe UI", 15F);
            labelToplam.Location = new Point(147, 246);
            labelToplam.Name = "labelToplam";
            labelToplam.Size = new Size(23, 28);
            labelToplam.TabIndex = 6;
            labelToplam.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(55, 296);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 7;
            label3.Text = "Fark:";
            // 
            // labelFark
            // 
            labelFark.AutoSize = true;
            labelFark.Font = new Font("Segoe UI", 15F);
            labelFark.Location = new Point(147, 296);
            labelFark.Name = "labelFark";
            labelFark.Size = new Size(23, 28);
            labelFark.TabIndex = 8;
            labelFark.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(266, 246);
            label5.Name = "label5";
            label5.Size = new Size(79, 28);
            label5.TabIndex = 9;
            label5.Text = "Çarpım:";
            // 
            // labelCarpim
            // 
            labelCarpim.AutoSize = true;
            labelCarpim.Font = new Font("Segoe UI", 15F);
            labelCarpim.Location = new Point(357, 246);
            labelCarpim.Name = "labelCarpim";
            labelCarpim.Size = new Size(23, 28);
            labelCarpim.TabIndex = 10;
            labelCarpim.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(266, 296);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 11;
            label7.Text = "Bölüm:";
            // 
            // labelBolum
            // 
            labelBolum.AutoSize = true;
            labelBolum.Font = new Font("Segoe UI", 15F);
            labelBolum.Location = new Point(357, 296);
            labelBolum.Name = "labelBolum";
            labelBolum.Size = new Size(23, 28);
            labelBolum.TabIndex = 12;
            labelBolum.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(947, 518);
            Controls.Add(labelBolum);
            Controls.Add(label7);
            Controls.Add(labelCarpim);
            Controls.Add(label5);
            Controls.Add(labelFark);
            Controls.Add(label3);
            Controls.Add(labelToplam);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(labelSayi2);
            Controls.Add(textBox1);
            Controls.Add(labelSayi1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelSayi1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelSayi2;
        private Label label1;
        private Label labelToplam;
        private Label label3;
        private Label labelFark;
        private Label label5;
        private Label labelCarpim;
        private Label label7;
        private Label labelBolum;
    }
}
