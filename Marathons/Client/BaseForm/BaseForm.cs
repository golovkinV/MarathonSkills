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

namespace Client.BaseForm
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = Constants.GetTimer(Constants.startMarathonDate, DateTime.Now);
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
