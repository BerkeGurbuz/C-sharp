using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string CekilenKart(int cekilenKartDegeri)
        {
            string resim = "";
            switch(cekilenKartDegeri)
            {
                case 1:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\1200px-Playing_card_heart_A.svg.png";
                    
                case 2:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\kUPA2-215x300.png";
                    
                case 3:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\11035950-three-of-hearts-playing-card.jpg";
                    
                case 4:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\İskambil Falı Kupa Dörtlü Kartının Anlamı-min.jpg";
                    
                case 5:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166163021-612x612.jpg";
                    
                case 6:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166163018-170667a.jpg";
                    
                case 7:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166089254-612x612.jpg";
                    
                case 8:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166087009-612x612.jpg";
                    
                case 9:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166087097-612x612.jpg";
                    
                case 10:
                    return resim = "C:\\Users\\Admin\\Desktop\\c#\\Blackjack\\istockphoto-166087315-612x612.jpg";               
                    
                default:
                    return resim = "";
                    
            }
        }        

        int cekilenKartDegeri1 = 0, cekilenKartDegeri2 = 0, sayac1 = 0, sayac2 = 0, toplam1 = 0, toplam2 = 0;
        int oyuncuPuan = 0, bilgisayarPuan = 0;
        DialogResult result;
        PictureBox picturebox;

        private void button1_Click(object sender, EventArgs e)
        {

            cekilenKartDegeri1 = random.Next(1, 11);

            sayac1++;

            switch (sayac1)
            {
                case 1:
                    picturebox = pictureBox1;
                    break;
                case 2:
                    picturebox = pictureBox2;
                    break;
                case 3:
                    picturebox = pictureBox3;
                    break;
                case 4:
                    picturebox = pictureBox4;
                    break;
                case 5:
                    picturebox = pictureBox5;
                    break;
            }

            picturebox.ImageLocation = CekilenKart(cekilenKartDegeri1);
            toplam1 += cekilenKartDegeri1;
            label1.Text = toplam1.ToString();

            if (sayac1 == 5)
            {
                button1.Enabled = false;
            }

            if (toplam1 >= 21)
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;


            while (toplam2 <= 17)
            {
                cekilenKartDegeri2 = random.Next(1, 11);
                sayac2++;

                switch (sayac2)
                {
                    case 1:
                        picturebox = pictureBox6;
                        break;
                    case 2:
                        picturebox = pictureBox7;
                        break;
                    case 3:
                        picturebox = pictureBox8;
                        break;
                    case 4:
                        picturebox = pictureBox9;
                        break;
                    case 5:
                        picturebox = pictureBox10;
                        break;
                }
                picturebox.ImageLocation = CekilenKart(cekilenKartDegeri2);
                toplam2 += cekilenKartDegeri2;
                label2.Text = toplam2.ToString();


            }

            if ((toplam1 > toplam2 || toplam2 > 21) && toplam1 <= 21)
            {
                MessageBox.Show("Kazandınız!!!");
                oyuncuPuan++;
            }

            else if ((toplam2 > toplam1 || toplam1 > 21) && toplam2 <= 21)
            {
                MessageBox.Show("Kaybettiniz...");
                bilgisayarPuan++;
            }

            else
            {
                MessageBox.Show("Berabere");
            }

            label3.Text = oyuncuPuan.ToString();
            label4.Text = bilgisayarPuan.ToString();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            label1.Text = "0";
            label2.Text = "0";
            toplam1 = 0;
            toplam2 = 0;
            sayac1 = 0;
            sayac2 = 0;
            pictureBox1.ImageLocation = null;
            pictureBox2.ImageLocation = null;
            pictureBox3.ImageLocation = null;
            pictureBox4.ImageLocation = null;
            pictureBox5.ImageLocation = null;
            pictureBox6.ImageLocation = null;
            pictureBox7.ImageLocation = null;
            pictureBox8.ImageLocation = null;
            pictureBox9.ImageLocation = null;
            pictureBox10.ImageLocation = null;
        }








    }
}
