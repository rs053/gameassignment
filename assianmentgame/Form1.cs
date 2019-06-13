using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace assianmentgame
{
    public partial class Form1 : Form
    {
        int x = 0, y = 0;
        int z = 2, cunt = 0;

        GenreateFire obj = new GenreateFire();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                Gun.ImageLocation = @"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\giphy.gif";
                if (y == z && cunt < 2)
                {
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\shot.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                    MessageBox.Show("Game Over Bullets Finished");
                    btnShot.Enabled = false;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\reload.wav");
                splayer.Play();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void Gun_Click(object sender, EventArgs e)
        {

        }

        private void chamber_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click_1(object sender, EventArgs e)
        {
            x = x + 1;
            if (x == 1)
            {

                Gun.ImageLocation = @"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\tenor.gif";

            }
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\reload.wav");
                splayer.Play();
            }

        }

        private void btnSpin_Click_1(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\reload.wav");
                splayer.Play();
            }

            if (x > 0)
            {

                chamber.ImageLocation = @"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\gun.jpg";
            }
            else
            {
                MessageBox.Show("Click load chamber first");
            }
        }

        private void btnPlayagain_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnShot.Enabled = true;
            Gun.ImageLocation = @"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\gun.jpg";
            chamber.ImageLocation = @"C:\Users\ravid\source\repos\assianmentgame\assianmentgame\pic\gun ch.jpg";

        }

        private int value()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            return random;

        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
