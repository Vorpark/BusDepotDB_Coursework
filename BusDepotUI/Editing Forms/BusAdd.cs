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
        public BusAdd(Bus bus) : this()
        {
            Bus = bus;
            textBox1.Text = bus.BusNumber;
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var bus = Bus ?? new Bus();
            bus.BusNumber = textBox1.Text;
            Bus = bus;
            Close();
        }

        private void BusAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
