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
using Client.CoordinatorService;

namespace Client.AllRunner
{
    public partial class AllRunnerForm : BaseForm.BaseForm
    {
        public AllRunnerForm()
        {
            InitializeComponent();
        }

        private void AllRunnerForm_Load(object sender, EventArgs e)
        {
            var client = new CoordinatorService.CoordinatorServiceClient();
            var countries = client.GetAllRunners();
            comboBox1.ValueMember = "email";
            comboBox1.DisplayMember = "name";
            dataGridView1.DataSource = countries;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new CoordinatorMenu.CoordinatorMenuForm();
            Hide();
            runnerMenuForm.Show();
        }
    }
}
