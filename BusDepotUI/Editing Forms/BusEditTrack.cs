using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusEditTrack : Form
    {
        public Bus Bus { get; set; }
        public BusEditTrack()
        {
            InitializeComponent();
        }
        public BusEditTrack(Bus bus) : this()
        {
            Bus = bus;
            label1.Text = $"Номер автобуса: {bus.BusNumber}";
            checkBox1.Checked = Bus.BusOnWay;
        }
        private void button_Click(object sender, EventArgs e)
        {
            Bus.BusOnWay = checkBox1.Checked;
            Close();
        }
    }
}
