using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.AllUsers
{
    public partial class AllUsersForm : BaseForm.BaseForm
    {
        public AllUsersForm()
        {
            InitializeComponent();
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var countries = client.GetAllUser();
            dataGridView1.DataSource = countries;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new AdministratorMenu.AdministratorMenuForm();
            Hide();
            runnerMenuForm.Show();
        }
    }
}
