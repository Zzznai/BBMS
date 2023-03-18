using BloodBankManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }
        int move = 0;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //Write the code to show Loading Animation
            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            //If the loading is complete then display login form and close this form
            if(move==640)
            {
                //Stop the Timer and Close this Form
                timerSplash.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm(); 
                loginForm.Show();

                
            }
        }

        private void IntroForm_Load(object sender, EventArgs e)
        {
            //Load the Timer
            timerSplash.Start();

        }
    }
}
