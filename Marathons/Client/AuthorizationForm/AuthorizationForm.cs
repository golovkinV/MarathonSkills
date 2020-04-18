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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;
            var client = new UserService.Service1Client();
            
            try
            {
                var user = client.Login(login, password);
                passwordTextBox.Text = user.password;
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

    }
}
