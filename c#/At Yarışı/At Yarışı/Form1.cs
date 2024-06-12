namespace At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label8.Text);
            derece++;
            label8.Text = derece.ToString();

            int birinciAtinGenisligi = pictureBox1.Width;
            int ikinciAtinGenisligi = pictureBox2.Width;
            int ucuncuAtinGenisligi = pictureBox3.Width;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            int bitisUzakligi = label5.Left;

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label7.Text = "1. At önde gidiyor";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label7.Text = "2. At önde gidiyor";
            }

            if (pictureBox3.Left > pictureBox2.Left + 5 && pictureBox3.Left > pictureBox1.Left + 5)
            {
                label7.Text = "3. At önde gidiyor";
            }

            if (pictureBox1.Left + birinciAtinGenisligi >= bitisUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("1. At yarışı kazandı!!!");
                
            }

            if (pictureBox2.Left + ikinciAtinGenisligi >= bitisUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("2. At yarışı kazandı!!!");
                
            }

            if (pictureBox3.Left + ucuncuAtinGenisligi >= bitisUzakligi)
            {
                timer1.Enabled = false;
                MessageBox.Show("3. At yarışı kazandı!!!");
                
            }

        }
    }
}
