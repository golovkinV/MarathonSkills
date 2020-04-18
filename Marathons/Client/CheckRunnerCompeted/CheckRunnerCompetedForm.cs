using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.CheckRunnerCompeted
{
    public partial class CheckRunnerCompetedForm : BaseForm.BaseForm
    {
        public CheckRunnerCompetedForm()
        {
            InitializeComponent();
        }

        private void competedButton_Click(object sender, EventArgs e)
        {
            Form authorizationForm = new AuthorizationForm();
            Hide();
            authorizationForm.Show();
        }

        private void newCompetitorButton_Click(object sender, EventArgs e)
        {
            Form registerAsRunnerForm = new RegsterAsRunner.RegisterAsRunnerForm();
            Hide();
            registerAsRunnerForm.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainForm.MainForm();
            Hide();
            mainForm.Show();
        }
    }
}
