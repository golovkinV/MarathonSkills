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

namespace Client.AdministratorMenu
{
    public partial class AdministratorMenuForm : BaseForm.BaseForm
    {
        public AdministratorMenuForm(User user)
        {
            InitializeComponent();
        }

        public AdministratorMenuForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainForm.MainForm();
            Hide();
            mainForm.Show();
        }

        private void AdministratorMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form manageCharitiesForm = new ManageCharities.ManageCharitiesForm();
            Hide();
            manageCharitiesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form volunteerManagementsForm = new VolunteerManagement.VolunteerManagementForm();
            Hide();
            volunteerManagementsForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form volunteerManagementsForm = new AllUsers.AllUsersForm();
            Hide();
            volunteerManagementsForm.Show();
        }
    }
}
