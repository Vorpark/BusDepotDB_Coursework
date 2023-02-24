using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class DriverAdd : Form
    {
        public Driver Driver { get; set; }
        BusDepotContext db;
        public DriverAdd()
        {
            InitializeComponent();
        }
        public DriverAdd(BusDepotContext db) : this()
        {
            this.db = db;
        }
        public DriverAdd(Driver driver, BusDepotContext db) : this(db)
        {
            Driver = driver;
            textBox1.Text = driver.DriverFirstName;
            textBox2.Text = driver.DriverLastName;
            textBox3.Text = driver.DriverMiddleName;
            textBox4.Text = driver.DriverAge.ToString();
            textBox5.Text = driver.DriverExperience.ToString();
        }
        private void button_Click(object sender, EventArgs e)
        {
            var driver = Driver ?? new Driver();
            bool check = true;

            if (textBox1.Text != "")
            {
                driver.DriverFirstName = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (textBox2.Text != "")
            {
                driver.DriverLastName = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Фамилия не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (textBox4.Text != "")
            {
                int driverAge;
                bool success = Int32.TryParse(textBox4.Text, out driverAge);
                if (success)
                {
                    driver.DriverAge = driverAge;
                    if (driver.DriverAge < 18 || driver.DriverAge > 100)
                    {
                        MessageBox.Show("Неверно введен возраст водителя", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
                else
                {
                    MessageBox.Show("Возраст не может содержать буквы", "Ошибка!", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("Возраст не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (textBox5.Text != "")
            {
                int driverExperience;
                bool success = Int32.TryParse(textBox5.Text, out driverExperience);
                if (success)
                {
                    driver.DriverExperience = driverExperience;
                    if (driver.DriverExperience < 0 || driver.DriverExperience > 100 || (driver.DriverAge - driver.DriverExperience < 18))
                    {
                        MessageBox.Show("Неверно введен стаж водителя", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
                else
                {
                    MessageBox.Show("Стаж водителя не может содержать буквы", "Ошибка!", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("Стаж не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (check == true)
            {
                driver.DriverMiddleName = textBox3.Text;
                driver.DriverFullName = $"{driver.DriverLastName} {driver.DriverFirstName} {driver.DriverMiddleName}";
                Driver = driver;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
