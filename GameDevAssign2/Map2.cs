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
    public partial class Map2 : Form
    {
        private int timer4ticks;
        private int timer5ticks;
        SoundPlayer footstep = new SoundPlayer(@".\Sounds\footstep.wav");
        public Map2()
        {
            InitializeComponent();
            livesCheck();
            CompletionStatus();


        }

        private void livesCalculation()
        {
            Map.lives--;
            if (Map.lives == 2)
            {
                PotatoLife3.Visible = false;
            }
            if (Map.lives == 1)
            {
                potatoLife2.Visible = false;
            }
            if (Map.lives == 0)
            {
                potatoLife1.Visible = false;
                MessageBox.Show("Johnny has run out of lives and needs a bit more learning before he can help others");
                this.Close();
                Main_menu menu = new Main_menu();
                menu.Show();

            }

        }

        private void livesCheck()
        {

            if (Map.lives == 2)
            {
                PotatoLife3.Visible = false;
            }
            if (Map.lives == 1)
            {
                potatoLife2.Visible = false;
            }
            if (Map.lives == 0)
            {
                potatoLife1.Visible = false;
                MessageBox.Show("Johnny has run out of lives and needs a bit more learning before he can help others");
                this.Dispose();
                Main_menu menu = new Main_menu();
                menu.Show();

            }
        }

        private void CompletionStatus()
        {
            if (lvl4.lvl4Completion == 1)
            {
                toLvl4Timer.Stop();
                toLvl5Timer.Start();
            }
        }

        private void toLvl4Timer_Tick(object sender, EventArgs e)
        {
            timer4ticks++;
            if (timer4ticks == 1)
            {

                footstep.Play();
                PotatoPic1.Visible = true;
            }
            else if (timer4ticks == 2)
            {
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = true;

            }
            else if (timer4ticks == 3)
            {
                footstep.Play();
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = false;
                PotatoPic3.Visible = true;

            }
            else if (timer4ticks == 4)
            {
                toLvl4Timer.Stop();
                MessageBox.Show("As Johnny walks towards to castle he comes accross this women struggling to understand what the man is saying");
                this.Hide(); //change to close later
                lvl4 FourthLevel = new lvl4();
                FourthLevel.ShowDialog();
            }

        }

        private void toLvl5Timer_Tick(object sender, EventArgs e)
        {
            timer5ticks++;
            if (timer5ticks == 1)
            {

                footstep.Play();
                PotatoPic4.Visible = true;
                MessageBox.Show("Johnny sees the castle with nothing in his way and starts sprinting towards it");


            }
            else if (timer5ticks == 2)
            {
                PotatoPic4.Visible = false;
                PotatoPic5.Visible = true;



            }
            else if (timer5ticks == 3)
            {
                footstep.Play();
                PotatoPic5.Visible = false;
                PotatoPic6.Visible = true;

            }
            else if (timer5ticks == 4)
            {
                PotatoPic6.Visible = false;
                PotatoPic7.Visible = true;

            }
            else if (timer5ticks == 5)
            {
                footstep.Play();
                PotatoPic7.Visible = false;
                PotatoPic8.Visible = true;

            }
            else if (timer5ticks == 6)
            {
                PotatoPic8.Visible = false;
                PotatoPic9.Visible = true;


            }
            else if (timer5ticks == 7)
            {
                footstep.Play();
                PotatoPic9.Visible = false;
                PotatoPic10.Visible = true;

            }
            else if (timer5ticks == 8)
            {
                PotatoPic10.Visible = false;
                PotatoPic11.Visible = true;

            }
            else if (timer5ticks == 9)
            {
                footstep.Play();
                PotatoPic11.Visible = false;
                PotatoPic12.Visible = true;

            }
            else if (timer5ticks == 10)
            {
                PotatoPic12.Visible = false;
                PotatoPic13.Visible = true;


            }
            else if (timer5ticks == 11)
            {
                footstep.Play();
                PotatoPic13.Visible = false;
                PotatoPic14.Visible = true;

            }
            else if (timer5ticks == 12)
            {
                PotatoPic14.Visible = false;
                PotatoPic15.Visible = true;

            }
            else if (timer5ticks == 13)
            {
                footstep.Play();
                PotatoPic15.Visible = false;
                PotatoPic16.Visible = true;

            }
            else if (timer5ticks == 14)
            {
                PotatoPic16.Visible = false;
                PotatoPic17.Visible = true;


            }

            else if (timer5ticks == 15)
            {
                footstep.Play();
                PotatoPic17.Visible = false;
                PotatoPic18.Visible = true;



            }
            else if (timer5ticks == 16)
            {
                PotatoPic18.Visible = false;
                PotatoPic19.Visible = true;

            }
            else if (timer5ticks == 17)
            {
                footstep.Play();
                PotatoPic19.Visible = false;
                PotatoPic20.Visible = true;

            }
            else if (timer5ticks == 18)
            {
                PotatoPic20.Visible = false;
                PotatoPic21.Visible = true;

            }
            else if (timer5ticks == 19)
            {
                footstep.Play();
                PotatoPic21.Visible = false;
                PotatoPic22.Visible = true;


            }
            else if (timer5ticks == 20)
            {
                PotatoPic22.Visible = false;
                PotatoPic23.Visible = true;

            }
            else if (timer5ticks == 21)
            {
                footstep.Play();
                PotatoPic23.Visible = false;
                PotatoPic24.Visible = true;

            }
            else if (timer5ticks == 22)
            {
                PotatoPic24.Visible = false;
                PotatoPic25.Visible = true;

            }
            else if (timer5ticks == 23)
            {
                footstep.Play();
                PotatoPic25.Visible = false;
                PotatoPic26.Visible = true;


            }
            else if (timer5ticks == 24)
            {

                this.Dispose();
                lvl5 fifthlvl = new lvl5();
                fifthlvl.ShowDialog();
            }

        }
    }
}
