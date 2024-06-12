namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        int dakika = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int salise = Convert.ToInt32(label1.Text);
            salise++;

            label1.Text = salise.ToString();

            if (salise == 10) 
            {
                salise = 0;
                label1.Text = salise.ToString();

                saniye++;

                label2.Text = saniye.ToString();
            }

            if (saniye == 60)
            {
                saniye = 0;
                label2.Text = saniye.ToString();

                dakika++;
                label3.Text = dakika.ToString();
            }
        }
    }
}
