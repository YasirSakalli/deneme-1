using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kosucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int yaş = 16;
        int Gün = 0;
        int yarışşkg = 0;
        int s1 = 0;
        int s2 = 0;
        int sayı1 = 1;
        int sayı2 = 1;
        double hız = 10;
        double direnç = 2;
        int GP = 2;
        double saat = 8;
        double yorgunluk = 0;
        double hız2 = 10;
        double açlık = 0;
        double kilo = 55;
        double para = 10;
        string lig = "liseler arası yarışlar";
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (GP >= 1 )
            {
                
                timer1.Enabled = true;
                timer4.Enabled = true;
                açlık = açlık + 0.03;
                s1++;
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (s1==0)
            {
                label17.Visible = false;
                progressBar1.Enabled = false;
                timer4.Enabled = false;
                timer1.Enabled = false;
                
            }
            if (s2==0)
            {
                label18.Visible = false;
                progressBar2.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                progressBar1.Maximum = 100;
                progressBar1.Step = 11;
                progressBar2.Maximum = 100;
                progressBar2.Step = 11;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (hız < 3)
            {
                hız = 3;
                label17.Visible = true;
                label18.Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            label5.Text = direnç.ToString();
            label6.Text = hız.ToString();
            label4.Text = GP.ToString();
            label15.Text = saat.ToString();
            label20.Text = yorgunluk.ToString();
            label26.Text = para.ToString();
            label22.Text = açlık.ToString();
            label11.Text = lig.ToString();
            label7.Text = Gün.ToString();
            label9.Text = yarışşkg.ToString();
            label13.Text = yaş.ToString();
            label24.Text = kilo.ToString();
            if (saat==24)
            {
                saat = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (GP >= 1)
            {
                timer5.Enabled = true;
                timer6.Enabled = true;
                s2++;
                açlık = açlık + 0.4;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            direnç = direnç + 0.5;
            hız2 = hız2 + 0.05;
            hız = hız + 0.05;
            yorgunluk = yorgunluk + 2;
            hız = hız - yorgunluk / 2;
            timer4.Enabled = false;



        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            hız2 = hız2 + 0.2;
            hız = hız + 0.2;
            direnç = direnç + 0.1;
            yorgunluk = yorgunluk + 5;
            hız = hız - yorgunluk / 2;
            timer5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Enabled = false;
            progressBar2.Value = 0;
            saat = 8;
            açlık = açlık + (saat +8)/ 3;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            progressBar2.PerformStep();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            saat = saat + 1;
            s1 = 0;
            progressBar1.Value = 0;
            s2 = 0;
            progressBar2.Value = 0;
            yorgunluk = 0;
            hız = hız2;
            button1.Enabled = true;
            button2.Enabled = true;
            açlık = açlık + 0.3;
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value==100)
            {
                progressBar1.Enabled = false;
                progressBar1.Value = 0;
                timer7.Enabled = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(label9.Text == "0")
            {
                Form2 yarış = new Form2();
                yarış.Show();
                this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (açlık!=0)
            {
                if (para >= açlık/3)
                {
                    para = para - açlık / 3;
                    açlık = 0;
                }
                
            }
        }
    }
}
