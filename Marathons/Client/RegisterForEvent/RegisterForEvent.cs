using Client.AdminService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.RegisterForEvent
{
    public partial class RegisterForEvent : BaseForm.BaseForm
    {
        public RegisterForEvent()
        {
            InitializeComponent();
        }

        private async void RegisterForEvent_Load(object sender, EventArgs e)
        {
            var client = new AdminService.AdminServiceClient();
            var charities = await client.GetAllCharityAsync();
            foreach (Charity charity in charities)
            {
                charityComboBox.Items.Add(charity.name);
            }
        }
    }
}
