namespace Double_Aritmetik_Örnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark, carpim, bolum;

            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;

            labelToplam.Text = toplam.ToString();
            labelFark.Text = fark.ToString();
            labelCarpim.Text = carpim.ToString();
            labelBolum.Text = bolum.ToString();
        }
    }
}
