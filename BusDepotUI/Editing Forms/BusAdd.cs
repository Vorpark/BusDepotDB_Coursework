using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusAdd : Form
    {
        public Bus Bus { get; set; }
        public BusAdd()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Bus = new Bus()
            {
                BusNumber = textBox1.Text
            };
            Close();
        }
    }
}
