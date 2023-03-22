using BloodBankManagementSystem.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    /// <summary>
    /// Represents the introductory form for the Blood Bank Management System, which displays a loading animation and transitions to the login form when loading is complete.
    /// </summary>
    public partial class IntroForm : Form
    {
        // Tracks the current position of the loading animation
        int move = 0;

        public IntroForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Advances the loading animation and displays the login form when loading is complete.
        /// </summary>
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            // Write the code to show Loading Animation
            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            // If the loading is complete, display the login form and close this form
            if (move == 640)
            {
                // Stop the Timer and Close this Form
                timerSplash.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        /// <summary>
        /// Loads the form and fades it in gradually for a smoother transition.
        /// </summary>
        private async void IntroForm_Load(object sender, EventArgs e)
        {
            // Load the Timer
            timerSplash.Start();

            // Fade in the form gradually
            for (double opacity = 0; opacity <= 1; opacity += 0.1)
            {
                this.Opacity = opacity;
                await Task.Delay(5);
            }
        }
    }
}
