using Client.AdminService;
using Client.UserService;
using Client.RunnerService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charity = Client.AdminService.Charity;
using User = Client.UserService.User;

namespace Client.RegisterForEvent
{
    public partial class RegisterForEvent : BaseForm.BaseForm
    {
        User user;
        int marathonCost;
        List<string> listEvents;
        string raceKitOptions;
        public RegisterForEvent(User user)
        {
            this.user = user;
            logoutButton.Visible = true;
            InitializeComponent();
        }

        private async void RegisterForEvent_Load(object sender, EventArgs e)
        {
            calculateRaceCost();
            var client = new AdminServiceClient();
            var charities = await client.GetAllCharityAsync();
            charityComboBox.DisplayMember = "name";
            charityComboBox.ValueMember = "id";
            charityComboBox.DataSource = charities;
        }

        private void raceOptions_Changed(object sender, EventArgs e)
        {
            calculateRaceCost();
        }

        private void calculateRaceCost()
        {
            int optionA_cost = 0;
            int optionB_cost = 20;
            int optionC_cost = 45;
            int fullMarathonCost = 145;
            int halfMarathonCost = 75;
            int funRunCost = 20;
            int raceKitOptionsCost = optionA.Checked ? optionA_cost : optionB.Checked ? optionB_cost : optionC_cost;
            int eventsCost = (fullMarathon_checkBox.Checked ? fullMarathonCost : 0)
                + (halfMarathon_checkBox.Checked ? halfMarathonCost : 0)
                + (funRun_checkBox.Checked ? funRunCost : 0);
            listEvents = new List<string>();
            if (fullMarathon_checkBox.Checked)
            {
                listEvents.Add("15_5FM");
            }
            if (halfMarathon_checkBox.Checked)
            {
                listEvents.Add("15_5HM");
            }
            if (funRun_checkBox.Checked)
            {
                listEvents.Add("15_5FM");
            }
            raceKitOptions = optionA.Checked ? "A" : optionB.Checked ? "B" : "C";
            marathonCost = eventsCost + raceKitOptionsCost;
            costLabel.Text = "$" + marathonCost.ToString();
        }

        private void showCharityInfoButton_Click(object sender, EventArgs e)
        {
            var charityId = charityComboBox.SelectedValue.ToString();
            var client = new RunnerServiceClient();
            var charity = client.GetCharity(int.Parse(charityId));
            popupPanel.BringToFront();
            popupPanel.Visible = true;
            nameCharityLabel.Text = charity.name;
            descriptionLabel.Text = charity.desc;

            /*
             * Автор убейся, файлы с землей, а в БД с дефисом
             */
            string logo = charity.logo.Replace("-", "_").Substring(0, charity.logo.Length - 4);
            charityLogo.Image = (Image)Properties.Resources.ResourceManager.GetObject(logo);
        }

        private void closePopupButton_Click(object sender, EventArgs e)
        {
            popupPanel.Visible = false;
        }

        private async void registerButton_Click(object sender, EventArgs e)
        {
            var client = new UserService.UserServiceClient();
            var charityId = int.Parse(charityComboBox.SelectedValue.ToString());
            try
            {
                await client.RegisterForEventAsync(user.email, listEvents.ToArray(), raceKitOptions, charityId, marathonCost);
                Form registrationConfirmation = new RegistrationConfirmation.RegistrationConfirmationForm(user);
                Hide();
                registrationConfirmation.Show();
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new RunnerMenu.RunnerMenuForm(user);
            Hide();
            runnerMenuForm.Show();
        }
    }
}
