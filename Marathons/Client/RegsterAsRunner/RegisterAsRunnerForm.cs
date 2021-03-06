﻿using Client.UserService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.RegsterAsRunner
{
    public partial class RegisterAsRunnerForm : BaseForm.BaseForm
    {
        public RegisterAsRunnerForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form mainForm = new MainForm.MainForm();
            Hide();
            mainForm.Show();
        }

        private void RegisterAsRunnerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            Form registerForEvent = new RegisterForEvent.RegisterForEvent(user);
            Hide();
            registerForEvent.Show();
        }

        private void RegisterAsRunnerForm_Load(object sender, EventArgs e)
        {


        }
    }
}
