using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.VolunteerManagement
{
    public partial class VolunteerManagementForm : BaseForm.BaseForm
    {
        public VolunteerManagementForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new MainForm.MainForm();
            Hide();
            runnerMenuForm.Show();
        }
    }
}
