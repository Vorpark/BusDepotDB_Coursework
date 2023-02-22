using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusModelAdd : Form
    {
        public BusModel BusModel { get; set; }
        public BusModelAdd()
        {
            InitializeComponent();
        }
        public BusModelAdd(BusModel busModel) : this()
        {
            BusModel= busModel;
            textBox1.Text = busModel.BusName;
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var busModel = BusModel ?? new BusModel();
            busModel.BusName = textBox1.Text;
            BusModel = busModel;
            Close();
        }
    }
}
