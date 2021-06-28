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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SSTimer_Tick(object sender, EventArgs e)
        {
            SSTimer.Enabled = true;
            progressBar1.Increment(2);
            if (progressBar1.Value == 100)
            {
                SSTimer.Enabled = false;
                Main_menu menu = new Main_menu();
                menu.Show();
                this.Hide();
            }

        }
    }
}
