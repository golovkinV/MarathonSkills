using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ManageCharities
{
    public partial class ManageCharitiesForm : BaseForm.BaseForm
    {
        public ManageCharitiesForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new MainForm.MainForm();
            Hide();
            runnerMenuForm.Show();
        }

        private void ManageCharitiesForm_Load(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var countries = client.GetAllCharity();
            dataGridView1.DataSource = countries;
        }
    }
}
