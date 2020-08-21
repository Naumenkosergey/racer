using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label[] road = new Label[4];
        Random random = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < road.Length; i++)
            {
                road[i].Top += 2;
                if (road[i].Top > Height)
                    road[i].Top = -road[i].Height;
            }

            carblue.Top += 3;
            if (carblue.Top > Height)
            {
                carblue.Top = -carblue.Height;
                carblue.Left = random.Next(0, Width - carblue.Width);
            }


            carorange.Top += 4;
            if (carorange.Top > Height)
                carorange.Top = -carorange.Height;

            if (mycar.Bounds.IntersectsWith(carblue.Bounds))
            {
                GameOver();

            }
            if (mycar.Bounds.IntersectsWith(carorange.Bounds))
            {
                GameOver();

            }
        }

        private void GameOver()
        {
            label5.Visible = true;
            timer1.Stop();
            DialogResult dialogResult = MessageBox.Show("Еще?", "ты проиграл", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
                Restart();
            else
                Close();
        }

        void Restart()
        {
            carblue.Top = -carblue.Height;
            carorange.Top = -carorange.Height;
            timer1.Start();
            label5.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            road[0] = label1;
            road[1] = label2;
            road[2] = label3;
            road[3] = label4;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && mycar.Left > 0)
                mycar.Left -= 5;
            if (e.KeyCode == Keys.Right && mycar.Left < Width-mycar.Width)
                mycar.Left += 5;
        }
    }
}
