using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FlappyBirdRecreated
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            menuTimer.Start();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            ActualGame window = new ActualGame();
            window.Show();
            menuTimer.Stop();
        }

        private void btn_how_Click(object sender, EventArgs e)
        {
            HowToPlay window1 = new HowToPlay();
            window1.Show();
            menuTimer.Stop();
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            //Animate(); looks bad
        }

        void Animate()
        {
                double speed = 1;
                for(int x = 0; x < 10; x++)
                {
                    icon.Top += Convert.ToInt32(speed);
;               }
                for (int y = 0; y < 10; y++) 
                {
                    icon.Top -= Convert.ToInt32(speed);
                }
            
        }
    }
}
