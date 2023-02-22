using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusDepotAdd : Form
    {
        public BusDepot BusDepot { get; set; }
        public BusDepotAdd()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            BusDepot = new BusDepot()
            {
                BusDepotAddress = textBox1.Text
            };
            Close();
        }
    }
}
