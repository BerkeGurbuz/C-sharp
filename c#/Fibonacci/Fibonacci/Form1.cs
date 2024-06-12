using System.Numerics;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int fibo = 0, fibo2 = 1, a, terimSayisi;
            listBox1.Items.Clear();
            listBox1.Items.Add(fibo);
            listBox1.Items.Add(fibo2);
            terimSayisi = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < terimSayisi - 2; i++)
            {
                a = fibo2;
                fibo2 += fibo;
                fibo = a;
                
                listBox1.Items.Add(fibo2);
                
            }
            //label2.Text = fibo2.ToString();
            label3.Text = terimSayisi.ToString() + ". Terim:";

            if (terimSayisi < 0)
            {
                listBox1.Items.Clear();
                label3.Visible = false;
                label2.Text = "Fibonacci'nin negatif terimi bulunmaz.";
            }

            else if (terimSayisi == 0)
            {
                listBox1.Items.Clear();
                label3.Visible = true;
                label2.Text = "0";

            }

            else if (terimSayisi == 1)
            {
                listBox1.Items.Clear();
                label3.Visible = true;
                listBox1.Items.Add("0");
                label2.Text = "0";
            }

            else
            {
                label2.Text = fibo2.ToString();
                label3.Visible = true;
            }
        }
    }
}
