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

namespace Client.EditRunnerProfile
{
    public partial class EditRunnerProfileForm : BaseForm.BaseForm
    {
        User user;
        public EditRunnerProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EditRunnerProfileForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = user.firstName;
            emailInputLabel.Text = user.email;
            lastNameTextBox.Text = user.lastName;
            genderComboBox.SelectedItem = user.runnerData.gender;
            dateTimePicker.Value = DateTime.Parse(user.runnerData.dateOfBirth);
        }

        private void EditRunnerProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new RunnerMenu.RunnerMenuForm(user);
            Hide();
            runnerMenuForm.Show();
        }
    }
}
