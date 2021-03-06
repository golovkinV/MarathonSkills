﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.SponsorshipOverview
{
    public partial class SponsorshipOverviewForm : BaseForm.BaseForm
    {
        public SponsorshipOverviewForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new CoordinatorMenu.CoordinatorMenuForm();
            Hide();
            runnerMenuForm.Show();
        }

        private void SponsorshipOverviewForm_Load(object sender, EventArgs e)
        {
            var client = new CoordinatorService.CoordinatorServiceClient();
            var countries = client.GetCharities();
            dataGridView1.DataSource = countries;
        }
    }
}
