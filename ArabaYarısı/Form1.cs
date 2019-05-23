using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            yellowCar.Location = new Point(81, 350);
            greenCar.Location = new Point(202, 350);
            blueCar.Location = new Point(319, 350);
            lblSonuc.Text = "";
            timer1.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yellowCar.Top < 12 || blueCar.Top < 12 || greenCar.Top < 12)

            {
                if (yellowCar.Top < 12)
                {
                    lblSonuc.Text = "Sarı araç kazandı.";
                    onePing();
                    lblSonuc.ForeColor = Color.Yellow;
                }

                else if (blueCar.Top < 12)
                {
                    lblSonuc.Text = "Mavi araç kazandı.";
                    onePing();
                    lblSonuc.ForeColor = Color.Blue;
                }

                else if (greenCar.Top < 12)
                {
                    lblSonuc.Text = "Yeşil araç kazandı.";
                    onePing();
                    lblSonuc.ForeColor = Color.Green;
                }
                timer1.Enabled = false;
                timer1.Stop();
            }

            else
            {
                Random rnd = new Random();
                Random rnd1 = new Random();
                Random rnd2 = new Random();

                yellowCar.Top -= rnd.Next(0, rnd.Next(1, 10));
                blueCar.Top -= rnd.Next(0, rnd1.Next(1, 10));
                greenCar.Top -= rnd.Next(0, rnd2.Next(1, 10));
            }
        }

        private void onePing()
        {
            SystemSounds.Beep.Play();
        }
    }
}

