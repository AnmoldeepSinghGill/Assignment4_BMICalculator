using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*-------------------------------------------------------------------------------------------------
 * Author: Anmoldeep Singh Gill
 * 
 * Student Number: 301044883
 * 
 * Create Date: 25 Jul, 2019
 * 
 * Description: This project initialise a splash screen thet is displayed for 3 sec
 * before the BMI Calculator Form is Displayed.
 * 
 * Revision History: Final Version (With all functionality)
 * -------------------------------------------------------------------------------------------------
 */

namespace Assignment4_BMICalculator
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            Program.bmiCalculator.Show();
            this.Hide();
            SplashTimer.Enabled = false;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            LoadingAnimation();
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            LoadingLabel.Visible = true;
        }

        private void Dot1Timer_Tick(object sender, EventArgs e)
        {
            Dot1Label.Visible = true;
        }

        private void Dot2Timer_Tick(object sender, EventArgs e)
        {
            Dot2Label.Visible = true;
        }

        private void LoadingAnimation()
        {
            LoadingLabel.Visible = false;
            Dot1Label.Visible = false;
            Dot2Label.Visible = false;
            LoadingTimer.Enabled = true;
            Dot1Timer.Enabled = true;
            Dot2Timer.Enabled = true;
        }
    }
}
