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
    public partial class lvl4 : Form
    {
        int ticks;
        int stage = 0;
        public static int lvl4Completion = 0;
        public lvl4()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks == 3)
            {
                SoundPlayer konichiwa = new SoundPlayer(@".\Sounds\Ogenkidesuka.wav");
                konichiwa.Play();
                timer1.Stop();
            }
            if (ticks == 5)
            {
                SoundPlayer Arigato = new SoundPlayer(@".\Sounds\Watashi wa genkidesu. Anata wa.wav");
                Arigato.Play();
                timer1.Stop();
            }
            if (ticks == 7)
            {
                SoundPlayer gomennassai = new SoundPlayer(@".\Sounds\Sayōnara.wav");
                gomennassai.Play();
                timer1.Stop();
            }
        }

        private void AnswertxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stage == 0)
            {
                if (AnswertxtBox.Text == "how are you" || AnswertxtBox.Text == "How are you" || AnswertxtBox.Text == "HOW ARE YOU")
                {
                    MessageBox.Show("Okay you got that one right keep it up");
                    timer1.Start();
                    stage++;
                    Console.WriteLine(stage);

                }
                else if (AnswertxtBox.Text != "how are you" || AnswertxtBox.Text != "How are you" || AnswertxtBox.Text != "HOW ARE YOU")
                {
                    livesCalculation();
                    Console.WriteLine(stage);
                }

            }
            else if (stage == 1)
            {
                if (AnswertxtBox.Text == "I'm fine what about you" || AnswertxtBox.Text == "im fine what about you" || AnswertxtBox.Text == "I'm fine and you" || AnswertxtBox.Text == "I'm fine and you" || AnswertxtBox.Text == "I'm fine and you" || AnswertxtBox.Text == "im fine what about you ")
                {
                    MessageBox.Show("nice it sounds like the conversation is about to end");
                    timer1.Start();
                    stage++;
                    Console.WriteLine(stage);
                }
                else if (AnswertxtBox.Text != "I'm fine what about you" || AnswertxtBox.Text != "im fine what about you" || AnswertxtBox.Text != "I'm fine and you" || AnswertxtBox.Text != "I'm fine and you" || AnswertxtBox.Text != "I'm fine and you" || AnswertxtBox.Text != "im fine what about you ")
                {
                    livesCalculation();
                    Console.WriteLine(stage);
                }
            }
            else if (stage == 2)
            {
                if (AnswertxtBox.Text == "goodbye" || AnswertxtBox.Text == "Goodbye" || AnswertxtBox.Text == "GOODBYE")
                {
                    MessageBox.Show("Thank you so much for helping me speak to him, it helped me out a lot");

                    timer1.Start();
                    lvl4Completion++;
                    Console.WriteLine(lvl4Completion);
                    this.Dispose();
                    Map2 backtoMap = new Map2();
                    backtoMap.ShowDialog();


                }
                else if (AnswertxtBox.Text != "goodbye" || AnswertxtBox.Text != "Goodbye" || AnswertxtBox.Text != "GOODBYE")
                {
                    livesCalculation();
                }
            }
        }
    }
}
