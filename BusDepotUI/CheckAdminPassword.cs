using System;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class CheckAdminPassword : Form
    {
        public CheckAdminPassword()
        {
            InitializeComponent();
        }

        private void Check_Click(object sender, EventArgs e)
        {
            var enterPassword = textBox1.Text;
            if(enterPassword == "123")
            {
                DialogResult= DialogResult.OK;
            }
            Close();
        }
    }
}
