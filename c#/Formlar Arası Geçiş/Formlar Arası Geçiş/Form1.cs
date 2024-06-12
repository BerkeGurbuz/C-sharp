namespace Formlar_Arası_Geçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form2 yeni = new Form2();
                yeni.Show();
                this.Hide(); //bu satırı kullanmazsak butona her basışımızda yeni bi form2 açar.
                
            }

            else
            {
                MessageBox.Show("Hatalı Giriş!!");
            }
        }
    }
}
