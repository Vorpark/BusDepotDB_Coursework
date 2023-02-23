using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class DriverAdd : Form
    {
        public Driver Driver { get; set; }
        public DriverAdd()
        {
            InitializeComponent();
        }
        public DriverAdd(Driver driver) : this()
        {
            Driver = driver;
            textBox1.Text = driver.DriverFirstName;
            textBox2.Text = driver.DriverLastName;
            textBox3.Text = driver.DriverMiddleName;
            textBox4.Text = driver.DriverAge.ToString();
            textBox5.Text = driver.DriverExperience.ToString();
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var driver = Driver ?? new Driver();
            driver.DriverFirstName = textBox1.Text;
            driver.DriverLastName = textBox2.Text;
            driver.DriverMiddleName = textBox3.Text;
            driver.DriverAge = Int32.Parse(textBox4.Text);
            driver.DriverExperience = Int32.Parse(textBox5.Text);
            Driver = driver;
            Close();
        }
    }
}
