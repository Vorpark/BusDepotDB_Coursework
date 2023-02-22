using BusDepotBL.Model;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusModelAdd : Form
    {
        public BusModel BusModel { get; set; }
        public BusModelAdd()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            BusModel = new BusModel()
            {
                BusName = textBox1.Text
            };
            Close();
        }
    }
}
