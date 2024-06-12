namespace Futbol_Ligi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int gsPuan = 0, fbPuan = 0, bjkPuan = 0, tsPuan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int gs, fb, bjk, ts;
            gs = rnd.Next(0, 5);
            fb = rnd.Next(0, 5);
            bjk = rnd.Next(0, 5);
            ts = rnd.Next(0, 5);

            labelGala1.Text = gs.ToString();
            labelFener1.Text = fb.ToString();
            labelBesik1.Text = bjk.ToString();
            labelTrab1.Text = ts.ToString();

            if (gs > fb)
            {
                gsPuan += 3;
            }

            else if (fb > gs)
            {
                fbPuan += 3;
            }

            else
            {
                gsPuan += 1;
                fbPuan += 1;
            }

            if (ts > bjk)
            {
                tsPuan += 3;
            }

            else if (bjk > ts)
            {
                bjkPuan += 3;
            }

            else
            {
                bjkPuan += 1;
                tsPuan += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int gs, fb, bjk, ts;
            gs = rnd.Next(0, 5);
            fb = rnd.Next(0, 5);
            bjk = rnd.Next(0, 5);
            ts = rnd.Next(0, 5);

            labelGala2.Text = gs.ToString();
            labelFener2.Text = fb.ToString();
            labelBesik2.Text = bjk.ToString();
            labelTrab2.Text = ts.ToString();

            if (gs > bjk)
            {
                gsPuan += 3;
            }

            else if (bjk > gs)
            {
                bjkPuan += 3;
            }

            else
            {
                gsPuan += 1;
                bjkPuan += 1;
            }

            if (ts > fb)
            {
                tsPuan += 3;
            }

            else if (fb > ts)
            {
                fbPuan += 3;
            }

            else
            {
                fbPuan += 1;
                tsPuan += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int gs, fb, bjk, ts;
            gs = rnd.Next(0, 5);
            fb = rnd.Next(0, 5);
            bjk = rnd.Next(0, 5);
            ts = rnd.Next(0, 5);

            labelGala3.Text = gs.ToString();
            labelFener3.Text = fb.ToString();
            labelBesik3.Text = bjk.ToString();
            labelTrab3.Text = ts.ToString();

            if (gs > ts)
            {
                gsPuan += 3;
            }

            else if (ts > gs)
            {
                tsPuan += 3;
            }

            else
            {
                gsPuan += 1;
                tsPuan += 1;
            }

            if (fb > bjk)
            {
                fbPuan += 3;
            }

            else if (bjk > fb)
            {
                fbPuan += 3;
            }

            else
            {
                bjkPuan += 1;
                fbPuan += 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelGalaPuan.Text = gsPuan.ToString();
            labelTrabPuan.Text = tsPuan.ToString();
            labelFenerPuan.Text = fbPuan.ToString();
            labelBesikPuan.Text= bjkPuan.ToString();
        }
    }
}
