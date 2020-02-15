using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KlotSongs.Controllers;

namespace KlotSongs
{
    public partial class LoginForm : Form
    {
        private bool isRegisterAction;
        private UserController userController;

        public LoginForm(UserController userController)
        {
            this.userController = userController;

            InitializeComponent();
            InitializeLogin();
        }

        protected void DisplayStatus(string text)
        {
            labelStatus.Text = text;
        }

        private void InitializeLogin(string display = "Enter Login info...")
        {
            isRegisterAction = false;

            textBoxPassword.UseSystemPasswordChar = true;
            DisplayStatus(display);

            buttonLogin.Text = "Login";
            buttonRegister.Text = "Register";
        }

        private void InitializeRegister(string display = "Enter Registration Info...")
        {
            isRegisterAction = true;

            textBoxPassword.UseSystemPasswordChar = false;
            DisplayStatus(display);

            buttonLogin.Text = "Cancel";
            buttonRegister.Text = "Confirm";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (isRegisterAction)
            {
                InitializeLogin();
            }
            else
            {
                //Trylogin

                if (userController.TryLogin(textBoxUsername.Text, textBoxPassword.Text))
                {
                    DisplayStatus("Login successful. Transitiong...");

                    TransitionToMainForm(/* userController.LoggedInUser */);
                }
                else
                {
                    DisplayStatus("Error logging in.");
                }
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (isRegisterAction)
            {
                if (userController.TryRegister(textBoxUsername.Text, textBoxPassword.Text))
                {
                    InitializeLogin("Registration successfull. Enter Login info...");
                }
                else
                {
                    DisplayStatus("Error registering new user.");
                }
            }
            else
            {
                InitializeRegister();
            }
        }

        private void TransitionToMainForm(/* userController.LoggedInUser */)
        {
            //Create main form and send the LoggedInUser to it

            //mainForm.Location = this.Location;
            //mainForm.StartPosition = FormStartPosition.Manual;
            //mainForm.FormClosing += delegate { InitializeLogin(); this.Show();};
            //mainForm.Show();

            this.Hide();
        }
    }
}
