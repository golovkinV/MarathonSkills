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
            var client = new UserService.Service1Client();
            var user = client.Login("evalyn.christian@hr.gov", "DqqSGUE2");
            user.password = "shandao";
            user.runnerData.countryCode = "RUS";
            client.EditUser(user);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var client = new AdminService.Service1Client();
            var task = await client.GetAllCharityAsync();
            var charity = task[0];
            charity.name = "Arise";

            await client.EditCharityAsync(charity);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var client = new AdminService.Service1Client();
            await client.AddCharityAsync("KEK", "TEST", "KEK");
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var client = new AdminService.Service1Client();
            var list = new List<Volunteer>();
            list.Add(new Volunteer("Ivan", "Petrov", "RUS", "Male"));
            list.Add(new Volunteer("Ahmad", "Tea", "RUS", "Male"));
            list.Add(new Volunteer("Ivan", "Petrov", "RUS", "Male"));
            await client.AddVolunteersAsync(list.ToArray()); 
        }
    }
}
