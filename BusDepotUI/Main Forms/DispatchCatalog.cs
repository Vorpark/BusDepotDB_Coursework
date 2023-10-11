using BusDepotBL.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Main_Forms
{
    public partial class DispatchCatalog : Form
    {
        BusDepotContext db;
        DbSet<Bus> set;
        public DispatchCatalog(DbSet<Bus> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
        }

        private void DispatchCatalog_Load(object sender, EventArgs e)
        {
            var routeNumbers = db.Routes.Select(x => x.RouteNumber);
            foreach(var item in routeNumbers)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedItem = 0;
            labelRouteNameOfCurrentRoute.Text = db.Routes.First(x => x.RouteNumber.Equals(comboBox.SelectedItem)).ToString();
        }

        private void AcceptChanges(object sender, EventArgs e)
        {

        }
    }
}
