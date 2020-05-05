using Client.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class AuthorizationForm : BaseForm.BaseForm
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        User user;

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            var client = new UserService.UserServiceClient();
            
            try
            {
                user = client.Login(login, password);
                passwordTextBox.Text = user.password;
                popupPanel.Visible = true;
            }
            catch
            {
                ShowNotification("Что-то не так");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
        }

        private void ShowNotification(string text)
        {
            MessageBox.Show(text);
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainForm.MainForm();
            Hide();
            mainForm.Show();
        }

        private void closePopupButton_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = false;
        }

        private void logAsRunnerButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new RunnerMenu.RunnerMenuForm(user);
            runnerMenuForm.Owner = this;
            Hide();
            runnerMenuForm.Show();
        }
    }
}
