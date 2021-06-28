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
    public partial class Map : Form
    {
        private int timer1ticks;
        private int timer2ticks;
        private int timer3ticks;
        private int toNewMapTicks;
        public int lvl1Completion = lvl1.lvl1Completion;
        public static int lives = 3;
        SoundPlayer footstep = new SoundPlayer(@".\Sounds\footstep.wav");
        public Map()
        {
            InitializeComponent();
            livesCheck();
            CompletionStatus();



        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void CompletionStatus()
        {
            if (lvl1Completion == 3 && lvl2.lvl2Completion == 1 && lvl3.lvl3Completion == 1)
            {
                ToLvl1Timer.Stop();
                toLvl2Timer.Stop();
                toLvl3Timer.Stop();
                toNewMapTimer.Start();
                MessageBox.Show("you have earned an extra life congratulations");
                lives++;
                livesCheck();


            }
            else if (lvl1Completion == 3 && lvl2.lvl2Completion == 1 && lvl3.lvl3Completion == 0)
            {
                ToLvl1Timer.Stop();
                toLvl2Timer.Stop();
                toLvl3Timer.Start();
            }
            else if (lvl1Completion == 3 && lvl3.lvl3Completion == 0)
            {
                ToLvl1Timer.Stop();
                toLvl2Timer.Start();

            }
        }

        private void livesCalculation()
        {
            lives--;
            if (lives == 2)
            {
                PotatoLife3.Visible = false;
            }
            if (lives == 1)
            {
                potatoLife2.Visible = false;
            }
            if (lives == 0)
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
            if (lives == 3)
            {
                PotatoLife3.Visible = true;
                potatoLife2.Visible = true;
                potatoLife1.Visible = true;
            }
            if (lives == 2)
            {
                PotatoLife3.Visible = false;
                potatoLife2.Visible = true;
            }
            if (lives == 1)
            {
                PotatoLife3.Visible = false;
                potatoLife2.Visible = false;
            }
            if (lives == 0)
            {
                potatoLife1.Visible = false;
                MessageBox.Show("Johnny has run out of lives and needs a bit more learning before he can help others");
                this.Close();
                Main_menu menu = new Main_menu();
                menu.Show();

            }
        }

        private void ToLvl1Timer_Tick(object sender, EventArgs e)
        {

            timer1ticks++;
            if (timer1ticks == 1)
            {
                footstep.Play();
                PotatoPic1.Visible = true;
            }
            else if (timer1ticks == 2)
            {
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = true;

            }
            else if (timer1ticks == 3)
            {
                footstep.Play();
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = false;
                PotatoPic3.Visible = true;

            }
            else if (timer1ticks == 4)
            {
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = false;
                PotatoPic3.Visible = false;
                PotatoPic4.Visible = true;

            }
            else if (timer1ticks == 5)
            {
                footstep.Play();
                PotatoPic1.Visible = false;
                PotatoPic2.Visible = false;
                PotatoPic3.Visible = false;
                PotatoPic4.Visible = false;
                PotatoPic5.Visible = true;


            }
            else if (timer1ticks == 6)
            {
                ToLvl1Timer.Stop();
                MessageBox.Show("As Johnny walks past his town a man calls him to ask for his help");
                this.Dispose(); //change to close later
                lvl1 FirstLevel = new lvl1();
                FirstLevel.ShowDialog();


            }



        }

        private void toLvl2Timer_Tick(object sender, EventArgs e)
        {
            timer2ticks++;
            if (timer2ticks == 1)
            {
                footstep.Play();
                PotatoPic6.Visible = true;
            }
            else if (timer2ticks == 2)
            {
                PotatoPic6.Visible = false;
                PotatoPic7.Visible = true;
            }
            else if (timer2ticks == 3)
            {
                footstep.Play();
                PotatoPic6.Visible = false;
                PotatoPic7.Visible = false;
                PotatoPic8.Visible = true;
            }
            else if (timer2ticks == 4)
            {
                PotatoPic6.Visible = false;
                PotatoPic7.Visible = false;
                PotatoPic8.Visible = false;
                PotatoPic9.Visible = true;
            }
            else if (timer2ticks == 5)
            {
                footstep.Play();
                PotatoPic9.Visible = false;
                PotatoPic10.Visible = true;
            }
            else if (timer2ticks == 6)
            {
                PotatoPic10.Visible = false;
                PotatoPic11.Visible = true;
            }
            else if (timer2ticks == 7)
            {
                footstep.Play();
                PotatoPic11.Visible = false;
                PotatoPic12.Visible = true;
            }
            else if (timer2ticks == 8)
            {
                PotatoPic12.Visible = false;
                PotatoPic13.Visible = true;
            }
            else if (timer2ticks == 9)
            {
                footstep.Play();
                PotatoPic13.Visible = false;
                PotatoPic14.Visible = true;
            }
            else if (timer2ticks == 10)
            {
                toLvl2Timer.Stop();
                MessageBox.Show("AHHHH My car broke, someone help me please!");
                this.Dispose();
                lvl2 SecondLvl = new lvl2();
                SecondLvl.ShowDialog();
            }

        }

        private void PotatoLife3_Click(object sender, EventArgs e)
        {

        }

        private void potatoLife2_Click(object sender, EventArgs e)
        {

        }

        private void potatoLife1_Click(object sender, EventArgs e)
        {

        }

        private void toLvl3Timer_Tick(object sender, EventArgs e)
        {
            timer3ticks++;

            if (timer3ticks == 1)
            {
                footstep.Play();
                PotatoPic15.Visible = true;
            }
            else if (timer3ticks == 2)
            {
                PotatoPic15.Visible = false;
                PotatoPic16.Visible = true;
            }
            else if (timer3ticks == 3)
            {
                footstep.Play();
                PotatoPic16.Visible = false;
                PotatoPic17.Visible = true;
            }
            else if (timer3ticks == 4)
            {
                toLvl3Timer.Stop();
                MessageBox.Show("psst psst, Johnny I heard you learning japanese could you help me translate with this lady is saying to me?");
                this.Dispose();
                lvl3 ThirdLvl = new lvl3();
                ThirdLvl.ShowDialog();
            }

        }

        private void toNewMapTimer_Tick(object sender, EventArgs e)
        {
            toNewMapTicks++;
            if (toNewMapTicks == 1)
            {
                footstep.Play();
                PotatoPic18.Visible = true;
            }
            else if (toNewMapTicks == 2)
            {
                PotatoPic18.Visible = false;
                PotatoPic19.Visible = true;
            }
            else if (toNewMapTicks == 3)
            {
                footstep.Play();
                PotatoPic19.Visible = false;
                PotatoPic20.Visible = true;
            }
            else if (toNewMapTicks == 4)
            {
                PotatoPic20.Visible = false;
                PotatoPic21.Visible = true;
            }
            else if (toNewMapTicks == 5)
            {
                footstep.Play();
                PotatoPic21.Visible = false;
                PotatoPic22.Visible = true;
            }
            else if (toNewMapTicks == 6)
            {
                PotatoPic22.Visible = false;
                PotatoPic23.Visible = true;
            }
            else if (toNewMapTicks == 7)
            {
                footstep.Play();
                PotatoPic23.Visible = false;
                PotatoPic24.Visible = true;
            }
            else if (toNewMapTicks == 8)
            {
                MessageBox.Show("Johnny sees the castle, his final goal to learning Japanese");
                btnContinue.Visible = true;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Map2 map2 = new Map2();
            map2.ShowDialog();

        }
    }
}
