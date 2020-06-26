using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.CoordinatorMenu
{
    public partial class CoordinatorMenuForm : BaseForm.BaseForm
    {
        public CoordinatorMenuForm()
        {
            InitializeComponent();
        }

        private void sponsorshipButton_Click(object sender, EventArgs e)
        {
            Form sponsorshipOverviewForm = new SponsorshipOverview.SponsorshipOverviewForm();
            sponsorshipOverviewForm.Show();
            Hide();
        }
    }
}
