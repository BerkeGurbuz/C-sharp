namespace MatematikHesaplamaları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            labelUyari.Visible = false;
            label1.Text = "Bir kenarı giriniz:";
            panel1.Visible = true;
            label4.Visible = false;
            textBox2.Visible = false;
            button3.Visible = true;
            button4.Visible = false;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            panel1.Visible = true;
            label1.Text = "Kısa kenar:";
            label4.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kareKenarı, alan, cevre;

            kareKenarı = Convert.ToInt32(textBox1.Text);

            alan = kareKenarı * kareKenarı;
            cevre = kareKenarı * 4;

            labelAlan.Text = alan.ToString();
            labelCevre.Text = cevre.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kisa, uzun, alan, cevre;

            kisa = Convert.ToInt32(textBox1.Text);
            uzun = Convert.ToInt32(textBox2.Text);

            if (uzun > kisa)
            {
                labelUyari.Visible = false;
                alan = kisa * uzun;
                cevre = (2 * kisa) + (2 * uzun);

                labelAlan.Text = alan.ToString();
                labelCevre.Text = cevre.ToString();
            }

            else
            {
                labelUyari.Visible = true;
                labelUyari.Text = "Uzun kenar kısa kenardan büyk olmalı!!!";
                labelAlan.Text = "00";
                labelCevre.Text = "00";
            }

        }

        

        
    }
}
