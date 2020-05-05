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

namespace Client.EditRunnerProfile
{
    public partial class EditRunnerProfileForm : BaseForm.BaseForm
    {
        User user;
        public EditRunnerProfileForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void EditRunnerProfileForm_Load(object sender, EventArgs e)
        {
            var client = new UserServiceClient();
            var countries = client.GetCountries();
            countryComboBox.ValueMember = "code";
            countryComboBox.DisplayMember = "name";
            foreach (Country country in countries)
            {
                countryComboBox.Items.Add(country);
            }

            firstNameTextBox.Text = user.firstName;
            emailInputLabel.Text = user.email;
            lastNameTextBox.Text = user.lastName;
            genderComboBox.SelectedItem = user.runnerData.gender;
            dateTimePicker.Value = DateTime.Parse(user.runnerData.dateOfBirth);

            //как поставить выбранный элемент 
            //MessageBox.Show(user.runnerData.country.ToString());
            countryComboBox.SelectedItem = user.runnerData.country;
            //MessageBox.Show(countryComboBox.SelectedItem.ToString());
        }

        private void EditRunnerProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var userData = user;
            userData.firstName = firstNameTextBox.Text;
            userData.lastName = lastNameTextBox.Text;
            userData.runnerData.gender = genderComboBox.SelectedItem.ToString();
            userData.runnerData.dateOfBirth = dateTimePicker.Value.ToString();

            var client = new UserServiceClient();
            client.EditUser(userData);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form runnerMenuForm = new RunnerMenu.RunnerMenuForm(user);
            Hide();
            runnerMenuForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(countryComboBox.SelectedItem.ToString());
        }
    }
}
