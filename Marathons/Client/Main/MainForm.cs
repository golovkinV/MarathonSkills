using Client.RegsterAsRunner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PrivateFontCollection fonts = new PrivateFontCollection();
            fonts.AddFontFile("openSansSemibold.ttf");
            fonts.AddFontFile("openSansLight.ttf");
            FontFamily openSansSemibold = fonts.Families[0];
            Font openSansSemiboldFont = new Font(openSansSemibold, 27, FontStyle.Bold);
            FontFamily openSansLight = fonts.Families[1];
            Font openSansLightFont = new Font(openSansLight, 16, FontStyle.Italic);
            headerLabel.Font = openSansSemiboldFont;
            locationLabel.Font = openSansLightFont;
            dateLabel.Font = openSansLightFont;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Form authorizationForm = new AuthorizationForm();
            Hide();
            authorizationForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = Constants.GetTimer(Constants.startMarathonDate, DateTime.Now);
        }

        private void wantRunnerButton_Click(object sender, EventArgs e)
        {
            Form checkRunnerCompetedForm = new CheckRunnerCompeted.CheckRunnerCompetedForm();
            checkRunnerCompetedForm.Show();
            Hide();
        }

        private void wantSponsorButton_Click(object sender, EventArgs e)
        {
        }
    }
}
