using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_lab_6
{
    public partial class Bilyard : Form
    {
        public decimal SpeedCount = 1;
        public int Speed = 1;
        public int ballPosX = 100, ballPosY = 100;
        public int moveStepY = 2, moveStepX = 2;
        public int ballWidth = 50, ballHeight = 50;
        public Bilyard()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bilyard_Load(object sender, EventArgs e)
        {

        }

        private void bob_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        int tick = 1;
        int a = 0;
        int b = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = tick.ToString();
            tick++;
            a++;
            if (a == 10)
            {
                b++;
                a = 0;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
                timer2.Enabled = true;
            }
        }

        private void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SpeedCount > speedUpDown.Value)
            {
                Speed = Speed - 1;
            }
            else
            {
                Speed = Speed + 1;
            }
            SpeedCount = speedUpDown.Value;
        }

        private void PaintBob(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(this.BackColor);
            if (b % 2 == 0)
            {
                e.Graphics.FillEllipse(Brushes.Blue, ballPosX, ballPosY, ballWidth, ballHeight);
            }
            else
            {
                e.Graphics.FillEllipse(Brushes.Red, ballPosX, ballPosY, ballWidth, ballHeight);
            }
            e.Graphics.DrawEllipse(Pens.Black, ballPosX, ballPosY, ballWidth, ballHeight);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ballPosX += moveStepX * Speed;
            if (ballPosX < bob.Left+5 || ballPosX+ ballWidth > bob.Right-5)
            {
                moveStepX = -moveStepX;
            }
            ballPosY += moveStepY * Speed;
            if (ballPosY + ballHeight > bob.Bottom-5 || ballPosY < bob.Top+5)
            {
                moveStepY = -moveStepY;
            }
            this.Refresh();
        }
    }
}
