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
        public RouteAdd(Route route) : this()
        {
            Route = route;
            textBox.Text = route.RouteNumber.ToString();
        }
        private void button_Click(object sender, EventArgs e) //TODO: проверка
        {
            var route = Route ?? new Route();
            route.RouteNumber = Int32.Parse(textBox.Text);
            Route = route;
            Close();
        }
    }
}
