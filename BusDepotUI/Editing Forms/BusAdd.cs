using BusDepotBL.Model;
using System;
using System.Data.Entity;
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
        }
        public BusAdd(Bus bus, BusDepotContext db) : this(db)
        {
            Bus = bus;
            textBox1.Text = bus.BusNumber;
            comboBox1.Text = bus.BusModel.BusName;
            comboBox2.Text = bus.BusDepot.BusDepotAddress;
            comboBox3.Text = bus.Route.RouteNumber.ToString();
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var bus = Bus ?? new Bus();
            bus.BusNumber = textBox1.Text;
            bus.BusModel = db.BusModels.FirstOrDefault(x => x.BusName == comboBox1.Text);
            bus.BusDepot = db.BusDepots.FirstOrDefault(x => x.BusDepotAddress == comboBox2.Text);
            bus.Route = db.Routes.FirstOrDefault(x => x.RouteNumber.ToString() == comboBox3.Text);
            Bus = bus;
            Close();
        }

        private void BusAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
