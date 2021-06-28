using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GameDevAssign2
{
    public partial class lvl5 : Form
    {
        private int stage = 0;


        public lvl5()
        {
            InitializeComponent();
            livesCheck();
            MessageBox.Show("What is the princess saying?");
            MessageBox.Show("Use the label above to determine what the princess is saying");

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



        private void btn1_click(object sender, EventArgs e)
        {
            if (stage == 0) //good
            {
                MessageBox.Show("You got half of it right");
                btn1.Enabled = false;
                stage++;

            }
            else if (stage == 3)//are
            {
                MessageBox.Show("you are 2/4 done");
                btn1.Enabled = false;
                // lbl1.Text = "koun watashi no yujin";
                //  btn2.Text = "My";
                //  btn1.Text = "Luck";
                // btn3.Text = "Friend";
                // btn4.Text = "Good";

                stage++;
            }
            else if (stage == 7)
            {
                MessageBox.Show("2/4 done!");
                stage++;
                btn1.Enabled = false;
            }
            else
            {
                livesCalculation();

            }

        }

        private void btn2_click(object sender, EventArgs e)
        {
            if (stage == 1) //morning
            {
                MessageBox.Show("well done, next word");

                lbl1.Text = "Ogenkidesuka";
                btn3.Enabled = true;
                btn4.Enabled = true;
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn2.Text = "how";
                btn1.Text = "are";
                btn3.Text = "you";
                btn4.Text = "doing";

                stage++;
            }
            else if (stage == 2) //how
            {
                MessageBox.Show("You got 1/4 right");
                btn2.Enabled = false;
                stage++;

            }
            else if (stage == 8)
            {
                MessageBox.Show("one more c'mon");
                stage++;
                btn2.Enabled = false;
            }
            else
            {
                livesCalculation();
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (stage == 4)//you 
            {
                MessageBox.Show("you are 3/4 done");
                btn3.Enabled = false;
                //lbl1.Text = "arigatou gozai mashi ta";
                // btn2.Text = "thank";
                //btn1.Text = "you";
                //btn3.Text = "much";
                // btn4.Text = "very";

                stage++;
            }

            else if (stage == 9)
            {
                MessageBox.Show("well done you completed the game!");
                this.Dispose();
                Congratulations congrats = new Congratulations();
                congrats.Show();
            }
            else
            {
                livesCalculation();
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (stage == 5)
            {
                MessageBox.Show("you completed it well done!");
                lbl1.Text = "koun watashi no yujin";
                btn2.Text = "My";
                btn1.Text = "Luck";
                btn3.Text = "Friend";
                btn4.Text = "Good";
                btn1.Enabled = true;
                btn2.Enabled = true;
                btn3.Enabled = true;
                btn4.Enabled = true;

                stage++;

            }
            else if (stage == 6)
            {
                MessageBox.Show("this is the last word and you 1/4 done you got this!");
                btn4.Enabled = false;
                stage++;
            }
            else
            {
                livesCalculation();
            }

        }


    }
}
