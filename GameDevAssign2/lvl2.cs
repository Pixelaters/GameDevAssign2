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
    public partial class lvl2 : Form
    {

        private int ticks;
        public int stage = 1;
        public static int lvl2Completion = 0;





        public lvl2()
        {
            InitializeComponent();
            Lvl1Timer.Start();
            MessageBox.Show("Thank you for comming Johnny, my car broke please help me fix it");
        }



        private void lvl1_Load(object sender, EventArgs e)
        {

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



        private void Lvl1Timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            this.Text = ticks.ToString();

            if (ticks == 1)
            {
                PicRoof.Visible = true;
                Lvl1Timer.Stop();
            }
            if (ticks == 2)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                //btnRoof.Text = "bell";
                //btnBody.Text = "pants";
                //btnWheel.Text = "Earth";
                //btnBonnet.Text = "male";

                Lvl1Timer.Stop();
            }
        }

        private void btnRoof_Click(object sender, EventArgs e)
        {
            if (stage == 1)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                btnRoof.Text = "Rūfu";
                btnWheel.Text = "Ringo";
                btnBody.Text = "Doa";
                btnBonnet.Text = "Būto";
                Lvl1Timer.Start();
                stage++;
            }
            else
            {
                livesCalculation();

            }
            Console.WriteLine(Map.lives);
        }

        private void picBody_Click(object sender, EventArgs e)
        {

        }

        private void btnBody_Click(object sender, EventArgs e)
        {
            if (stage == 2)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                picBonnet.Visible = true;
                btnRoof.Text = "Rūfu";
                btnWheel.Text = "Hoīru";
                btnBody.Text = "Doa";
                btnBonnet.Text = "Būto";
                Lvl1Timer.Start();
                stage++;
            }
            else
            {
                livesCalculation();

            }
            Console.WriteLine(Map.lives);
        }

        private void btnWheel_Click(object sender, EventArgs e)
        {
            if (stage == 4)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                picBonnet.Visible = true;

                picWheel2.Visible = true;
                picTrunk.Visible = true;
                btnRoof.Text = "Sora";
                btnWheel.Text = "bon'netto";
                btnBody.Text = "Chikyū";
                btnBonnet.Text = "Būto";
                Lvl1Timer.Start();
                stage++;
            }
            else if (stage == 5)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                picBonnet.Visible = true;

                picWheel2.Visible = true;
                picTrunk.Visible = true;
                btnRoof.Text = "GG";
                btnWheel.Text = "GG";
                btnBody.Text = "GG";
                btnBonnet.Text = "GG";
                Lvl1Timer.Start();
                MessageBox.Show("Thanks for fixing my car I can finally go back to work!");

                lvl2Completion = 1;
                Console.WriteLine("test");
                Console.WriteLine(lvl2Completion);
                this.Dispose();
                Map backtoMap = new Map();
                backtoMap.ShowDialog();


            }
            else
            {
                livesCalculation();
            }
            Console.WriteLine(Map.lives);

        }

        private void btnBonnet_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                picBody.Visible = true;
                PicRoof.Visible = true;
                picBonnet.Visible = true;

                picWheel2.Visible = true;
                btnRoof.Text = "Mado";
                btnWheel.Text = "Hoīru";
                btnBody.Text = "Denwa";
                btnBonnet.Text = "Chikyū";
                Lvl1Timer.Start();
                stage++;
            }
            else
            {

                livesCalculation();
            }

        }



        private void picBonnet_Click(object sender, EventArgs e)
        {

        }

        private void potatoLife1_Click(object sender, EventArgs e)
        {

        }

        private void potatoLife2_Click(object sender, EventArgs e)
        {

        }

        private void PotatoLife3_Click(object sender, EventArgs e)
        {


        }
    }
}
