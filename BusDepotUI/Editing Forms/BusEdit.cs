using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusEdit : Form
    {
        public Bus Bus { get; set; }
        BusDepotContext db;
        bool editBool = false;
        public BusEdit()
        {
            InitializeComponent();
        }
        public BusEdit(BusDepotContext db) : this()
        {
            this.db = db;
            foreach (var item in db.BusModels)
            {
                comboBox1.Items.Add(item);
            }
            foreach (var item in db.BusDepots)
            {
                comboBox2.Items.Add(item);
            }
            foreach (var item in db.Routes)
            {
                comboBox3.Items.Add(item);
            }
            foreach (var item in db.Drivers)
            {
                checkedListBox1.Items.Add(item);
            }
        }
        public BusEdit(Bus bus, BusDepotContext db) : this(db)
        {
            Bus = bus;
            editBool = true;
            textBox1.Text = bus.BusNumber;
            comboBox1.Text = bus.BusModel.BusName;
            comboBox2.Text = bus.BusDepot.BusDepotAddress;
            comboBox3.Text = bus.Route.RouteNumber.ToString();
            foreach (var item in bus.Drivers)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (item == checkedListBox1.Items[i])
                    {
                        checkedListBox1.SetItemChecked(i, true);
                        break;
                    }
                }
            }
        }

        private void button_Click(object sender, EventArgs e) 
        {
            var bus = Bus ?? new Bus();
            bool check = true;

            if (textBox1.Text != "")
            {
                var busNumber = db.Buses.FirstOrDefault(b => b.BusNumber == textBox1.Text);
                if (busNumber == null)
                {
                    bus.BusNumber = textBox1.Text;
                }
                else
                {
                    if (editBool == true)
                    {
                        bus.BusNumber = textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("Данный номер автобуса уже существует", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Номер автобуса не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            var busModel = db.BusModels.FirstOrDefault(x => x.BusName == comboBox1.Text);
            if (busModel != null)
            {
                if (busModel.Buses.Contains(bus)) { bus.BusModel.Buses.Remove(bus); }
                bus.BusModel = busModel;
                busModel.Buses.Add(bus);
            }
            else
            {
                MessageBox.Show("Данной модели автобуса не существует", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            var busDepot = db.BusDepots.FirstOrDefault(x => x.BusDepotAddress == comboBox2.Text);
            if (busDepot != null)
            {
                if (busDepot.Buses.Contains(bus)) { bus.BusDepot.Buses.Remove(bus); }
                bus.BusDepot = busDepot;
                busDepot.Buses.Add(bus);
            }
            else
            {
                MessageBox.Show("Данной автобусной парковки не существует", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            var route = db.Routes.FirstOrDefault(x => x.RouteNumber.ToString() == comboBox3.Text);
            if (route != null)
            {
                if (route.Buses.Contains(bus)) { bus.Route.Buses.Remove(bus); }
                bus.Route = route;
                route.Buses.Add(bus);
            }
            else
            {
                MessageBox.Show("Данного маршрута не существует", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            bus.Drivers.Clear();
            foreach (var item in checkedListBox1.Items)
            {
                string fullName = item.ToString();
                var drivers = db.Drivers.First(x => x.DriverFullName == fullName).Buses;
                if (drivers.Contains(bus)) { drivers.Remove(bus); }
            }
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string fullName = item.ToString();
                var drivers = db.Drivers.First(x => x.DriverFullName == fullName);
                bus.Drivers.Add(drivers);
                drivers.Buses.Add(bus);
            }

            if(check == true)
            {
                Bus = bus;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
