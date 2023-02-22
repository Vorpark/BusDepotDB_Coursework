using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class Main : Form
    {
        BusDepotContext db;
        public Main()
        {
            InitializeComponent();
            db = new BusDepotContext();
        }

        private void BusInDepotTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusDepotTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == false).ToList());
            catalogBusDepotTrack.Show();
        }

        private void BusOnWayTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == true).ToList());
            catalogBusOnWayTrack.Show();
        }

        private void BusesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses.ToList());
            catalogBusOnWayTrack.Show();
        }

        private void DriversTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Driver>(db.Drivers.ToList());
            catalogBusOnWayTrack.Show();
        }

        private void RoutesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Route>(db.Routes.ToList());
            catalogBusOnWayTrack.Show();
        }

        private void BusModelsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusModel>(db.BusModels.ToList());
            catalogBusOnWayTrack.Show();
        }

        private void BusDepotsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusDepot>(db.BusDepots.ToList());
            catalogBusOnWayTrack.Show();
        }

        private void RouteAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new RouteAdd();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Routes.Add(form.Route); 
                db.SaveChanges();
            }
        }
    }
}
