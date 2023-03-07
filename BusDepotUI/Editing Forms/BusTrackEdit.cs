using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusTrackEdit : Form
    {
        public Bus Bus { get; set; }
        BusDepotContext db;
        public BusTrackEdit()
        {
            InitializeComponent();
        }
        public BusTrackEdit(Bus bus, BusDepotContext db) : this()
        {
            VisibleUpdate();
            this.db = db;
            Bus = bus;
            label1.Text = $"Номер автобуса: {bus.BusNumber}";
            checkBox1.Checked = Bus.BusOnWay;
            foreach (var item in Bus.Drivers)
            {
                comboBox1.Items.Add(item);
            }
            if(Bus.BusOnWay == true)
            {
                comboBox1.Text = Bus.DriverOnWay;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            bool check = true;

            if (checkBox1.Checked == true)
            {
                var driverOnWay = Bus.Drivers.FirstOrDefault(b => b.ToString() == comboBox1.Text);
                if (driverOnWay != null)
                {
                    var checkDriver = db.Buses.FirstOrDefault(b => b.DriverOnWay.ToString() == comboBox1.Text);
                    if (checkDriver != null && Bus.DriverOnWay != comboBox1.Text)
                    {
                        MessageBox.Show("Данный водитель уже находится в пути на другом транспорте", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
                else
                {
                    MessageBox.Show("Данного водителя не существует или ему отказано в доступе к управлению данным транспортом", "Ошибка!", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else
            {
                if (comboBox1.Text != "")
                {
                    MessageBox.Show("Невозможно выбрать водителя без отправления автобуса в путь", "Ошибка!", MessageBoxButtons.OK);
                }
                check = false;
            }

            if (check == true)
            {
                Bus.BusOnWay = true;
                Bus.DriverOnWay = comboBox1.Text;
            }
            else
            {
                Bus.BusOnWay = false;
                Bus.DriverOnWay = "";
            }
            Close();
        }
        private void VisibleUpdate()
        {
            if (checkBox1.Checked == true)
            {
                label3.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                label3.Visible = false;
                comboBox1.Visible = false;
            }
        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            VisibleUpdate();
        }
    }
}
