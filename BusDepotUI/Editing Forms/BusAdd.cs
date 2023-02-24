using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusAdd : Form
    {
        public Bus Bus { get; set; }
        BusDepotContext db;
        public BusAdd()
        {
            InitializeComponent();
        }
        public BusAdd(BusDepotContext db) : this()
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
        public BusAdd(Bus bus, BusDepotContext db) : this(db)
        {
            Bus = bus;
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
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var bus = Bus ?? new Bus();
            bus.BusNumber = textBox1.Text;
            bus.BusModel = db.BusModels.FirstOrDefault(x => x.BusName == comboBox1.Text);
            bus.BusDepot = db.BusDepots.FirstOrDefault(x => x.BusDepotAddress == comboBox2.Text);
            bus.Route = db.Routes.FirstOrDefault(x => x.RouteNumber.ToString() == comboBox3.Text);
            bus.Drivers.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                string fullName = item.ToString();
                bus.Drivers.Add(db.Drivers.First(x => x.DriverFullName == fullName));
                db.Drivers.First(x => x.DriverFullName == fullName).Buses.Add(bus);
            }
            Bus = bus;
            Close();
        }

        private void BusAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
