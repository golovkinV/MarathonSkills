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

namespace Client.RegistrationConfirmation
{
    public partial class RegistrationConfirmationForm : BaseForm.BaseForm
    {
        User user;
        public RegistrationConfirmationForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new RunnerMenu.RunnerMenuForm(user);
            Hide();
            runnerMenuForm.Show();
        }
    }
}
