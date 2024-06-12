namespace PizzaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            string checkBoxText = "";
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox1.Text + " ";
            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox3.Text + " ";
            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox2.Text + " ";
            }

            if (checkBox4.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox4.Text + " ";
            }

            if (checkBox5.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox5.Text + " ";
            }

            if (checkBox6.CheckState == CheckState.Checked)
            {
                checkBoxText += checkBox6.Text + " ";
            }

            

            if (checkBoxText == "")
            {
                listBox6.Items.Add("Bir Þey Seçilmedi");
            }

            else
            {
                listBox6.Items.Add(checkBoxText);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

        }
    }
}
