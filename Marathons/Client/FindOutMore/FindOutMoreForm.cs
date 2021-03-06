﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FindOutMore
{
    public partial class FindOutMoreForm : BaseForm.BaseForm
    {
        public FindOutMoreForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new MainForm.MainForm();
            Hide();
            runnerMenuForm.Show();
        }

        private void PreviosRaceResultsButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new PreviosRaceResults.PreviosRaceResultsForm();
            Hide();
            runnerMenuForm.Show();
        }
    }
}
