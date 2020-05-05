using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingForm.AdminService;

namespace TestingForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var client = new UserService.UserServiceClient();
            var user = client.Login("evalyn.christian@hr.gov", "DqqSGUE2");
            user.password = "shandao";
            user.runnerData.country.code = "RUS";
            //client.EditUser(user);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var task = await client.GetAllCharityAsync();
            var charity = task[0];
            charity.name = "Arise";

            await client.EditCharityAsync(charity);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            await client.AddCharityAsync("KEK", "TEST", "KEK");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var list = new List<Volunteer>();
            var kek = new Volunteer();
            kek.firstName = "Ivan";
            kek.lastName = "Petrov";
            kek.countryCode = "RUS";
            kek.gender = "Male";
            list.Add(kek);
            var kek1 = new Volunteer();
            kek1.firstName = "Ahmad";
            kek1.lastName = "Tea";
            kek1.countryCode = "RUS";
            kek1.gender = "Male";
            list.Add(kek1);
            await client.AddVolunteersAsync(list.ToArray());
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var keks = await client.GetAllUserAsync();
            var lol = 0;
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var keks = await client.GetAllUserAsync();
            var user = keks[0];
            user.firstName = "TEST";
            await client.EditUserAsync(user);
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            await client.AddUserAsync("test", "test", "test", "test", "C");
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            var client = new UserService.UserServiceClient();
            await client.RegisterAsRunnerAsync("test@yandex.ru", "kek", "Ahmad", "Tea", "Male", "15.05.1999", "RUS");
            var list = new List<string>();
            list.Add("15_5FM");
            list.Add("15_5FR");
            await client.RegisterForEventAsync("test@yandex.ru", list.ToArray(), "A", 13, 20);
        }

        private async void button10_Click(object sender, EventArgs e)
        {
            var client = new SponsorService.SponsorServiceClient();
            var keks = await client.GetRunnersAsync();
            var lol = 0;
        }
    }
}
