using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Geçiş
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "sarı")
            {
                button2.BackColor = Color.Yellow;
            }

            else if (comboBox1.Text == "mavi")
            {
                button2.BackColor = Color.Blue;
            }

            else if (comboBox1.Text == "kırmızı")
            {
                button2.BackColor = Color.Red;
            }

            else if (comboBox1.Text == "yeşil")
            {
                button2.BackColor = Color.Green;
            }

            else if (comboBox1.Text == "pembe")
            {
                button2.BackColor = Color.Pink;
            }

            else
            {
                button2.BackColor = Color.White;
            }
        }
    }
}
