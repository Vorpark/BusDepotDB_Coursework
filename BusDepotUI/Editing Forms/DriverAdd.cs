using BusDepotBL.Model;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusDepotUI.Editing_Forms
{
    public partial class DriverAdd : Form
    {
        public Driver Driver { get; set; }
        public DriverAdd()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Driver = new Driver()
            {
                DriverFirstName = textBox1.Text,
                DriverLastName = textBox2.Text,
                DriverMiddleName = textBox3.Text,
                DriverAge = Int32.Parse(textBox4.Text),
                DriverExperience = Int32.Parse(textBox5.Text)
            };
            Close();
        }
    }
}
