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
        public BusDepotAdd(BusDepot busDepot) : this()
        {
            BusDepot = busDepot;
            textBox1.Text = busDepot.BusDepotAddress;
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var busDepot = BusDepot ?? new BusDepot();
            busDepot.BusDepotAddress = textBox1.Text;
            BusDepot = busDepot;
            Close();
        }
    }
}
