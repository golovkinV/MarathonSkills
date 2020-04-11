using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var user = client.GetUser("evalyn.christian@hr.gov", "DqqSGUE2");
            user.password = "shandao";
            user.runnerData.countryCode = "RUS";
            client.EditUser(user);
        }
    }
}
