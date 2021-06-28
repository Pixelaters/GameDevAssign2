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
    public partial class lvl3 : Form
    {
        int ticks;
        public static int lvl3Completion = 0;
        int stage = 0;
        public lvl3()
        {
            InitializeComponent();
            livesCheck();
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

        private void PlayTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 3)
            {
                SoundPlayer konichiwa = new SoundPlayer(@".\Sounds\konichiwa.wav");
                konichiwa.Play();
                PlayTimer.Stop();
            }
            if (ticks == 5)
            {
                SoundPlayer Arigato = new SoundPlayer(@".\Sounds\Arigato.wav");
                Arigato.Play();
                PlayTimer.Stop();
            }
            if (ticks == 7)
            {
                SoundPlayer gomennassai = new SoundPlayer(@".\Sounds\gomennassai.wav");
                gomennassai.Play();
                PlayTimer.Stop();
            }
        }

        private void Answertxtbx1_TextChanged(object sender, EventArgs e)
        {




        }



        private void Answertxtbx1_Leave_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stage == 0)
            {
                if (Answertxtbx1.Text == "hello" || Answertxtbx1.Text == "Hello" || Answertxtbx1.Text == "HELLO")
                {
                    MessageBox.Show("Okay you got that one right keep it up");
                    PlayTimer.Start();
                    stage++;
                    Console.WriteLine(stage);

                }
                else if (Answertxtbx1.Text != "hello" || Answertxtbx1.Text != "Hello" || Answertxtbx1.Text != "HELLO")
                {
                    livesCalculation();
                    Console.WriteLine(stage);
                }

            }
            else if (stage == 1)
            {
                if (Answertxtbx1.Text == "thank you" || Answertxtbx1.Text == "Thank you" || Answertxtbx1.Text == "THANK YOU")
                {
                    MessageBox.Show("nice it sounds like the conversation is about to end");
                    PlayTimer.Start();
                    stage++;
                    Console.WriteLine(stage);
                }
                else if (Answertxtbx1.Text != "thank you" || Answertxtbx1.Text != "Thank you" || Answertxtbx1.Text != "THANK YOU")
                {
                    livesCalculation();
                    Console.WriteLine(stage);
                }
            }
            else if (stage == 2)
            {
                if (Answertxtbx1.Text == "sorry" || Answertxtbx1.Text == "Sorry" || Answertxtbx1.Text == "SORRY")
                {
                    MessageBox.Show("You so much better at Japanese than me thank you for the help");
                    PlayTimer.Start();
                    lvl3Completion++;
                    Console.WriteLine(lvl3Completion);

                    this.Dispose();
                    Map backtoMap = new Map();
                    backtoMap.ShowDialog();


                }
                else if (Answertxtbx1.Text != "sorry" || Answertxtbx1.Text != "Sorry" || Answertxtbx1.Text != "SORRY")
                {
                    livesCalculation();
                }
            }

        }
    }
}
