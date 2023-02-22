using BusDepotBL.Model;
using System;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class RouteAdd : Form
    {
        public Route Route { get; set; }
        public RouteAdd()
        {
            InitializeComponent();
        }

        private void RouteAdd_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e) //Проверка на входные
        {
            Route = new Route()
            {
                RouteNumber = Int32.Parse(textBox.Text)
            };
            Close();
        }
    }
}
