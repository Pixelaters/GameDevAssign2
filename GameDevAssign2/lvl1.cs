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

namespace GameDevAssign2
{
    public partial class lvl1 : Form
    {

        public static int lvl1Completion = 0;
        SoundPlayer scribble = new SoundPlayer(@".\Sounds\Scribble.wav");
        int lightsTimerticks;
        public lvl1()
        {
            InitializeComponent();
            MessageBox.Show("Help! My light broke and I cant find any of my furniture");
            MessageBox.Show("Help one of the neighbours find his furniture");
        }

        private void btnShoe_Click(object sender, EventArgs e)
        {
            scribble.Play();
            lblShoe.Text = "S̶h̶o̶e̶";
            lvl1Completion++;
            completed();
        }

        private void btnShoe_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            scribble.Play();
            lblPhoto.Text = "F̶a̶m̶i̶l̶y̶ ̶p̶h̶o̶t̶o̶";
            lvl1Completion++;
            completed();
        }

        private void btnLamp_Click(object sender, EventArgs e)
        {
            scribble.Play();
            lblLamp.Text = "L̶a̶m̶p̶";
            lvl1Completion++;
            completed();
        }

        public void completed()
        {
            if (lvl1Completion == 3)
            {
                this.Hide();
                MessageBox.Show("Thank you so much for finding my furniture");
                Map backtoMap = new Map();
                backtoMap.ShowDialog();


            }
        }

        private void lightsTimer_Tick(object sender, EventArgs e)
        {
            lightsTimerticks++;
            if (lightsTimerticks == 1)
            {
                lightsOutPicBox.Visible = false;
            }
            else if (lightsTimerticks == 2)
            {
                lightsOutPicBox.Visible = false;
            }
            else if (lightsTimerticks == 3)
            {
                lightsOutPicBox.Visible = false;

            }
            else if (lightsTimerticks == 4)
            {
                lightsOutPicBox.Visible = true;
            }
            else if (lightsTimerticks == 5)
            {
                lightsOutPicBox.Visible = false;
            }
            else if (lightsTimerticks == 6)
            {
                lightsOutPicBox.Visible = true;
            }
            else if (lightsTimerticks == 7)
            {
                lightsTimerticks = 0;
            }


            //if (lightsOutPicBox.Visible == true)
            //{
            //    lightsOutPicBox.Visible = false;

            //}
            //else if (lightsOutPicBox.Visible == false)
            //{
            //    lightsOutPicBox.Visible = true;

            //}

        }
    }
}
