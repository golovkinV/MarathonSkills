using Client.AdminService;
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
using User = Client.UserService.User;

namespace Client.RunnerMenu
{
    public partial class RunnerMenuForm : BaseForm.BaseForm
    {
        User user;
        public RunnerMenuForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new EditRunnerProfile.EditRunnerProfileForm(user);
            runnerMenuForm.Owner = this;
            Hide();
            runnerMenuForm.Show();
        }

        private void closePopupButton_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = false;
        }

        private void contactInfoButton_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainForm.MainForm();
            Hide();
            mainForm.Show();
        }

        private void sponsorshipButton_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form registerForEventForm = new RegisterForEvent.RegisterForEvent(user);
            Hide();
            registerForEventForm.Show();
        }
    }
}
