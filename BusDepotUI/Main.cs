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
            var catalogBusDepotTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == false).ToList(), db);
            catalogBusDepotTrack.Show();
        }

        private void BusOnWayTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == true).ToList(), db);
            catalogBusOnWayTrack.Show();
        }

        private void BusesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses, db);
            catalogBusOnWayTrack.Show();
        }

        private void DriversTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Driver>(db.Drivers, db);
            catalogBusOnWayTrack.Show();
        }

        private void RoutesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Route>(db.Routes, db);
            catalogBusOnWayTrack.Show();
        }

        private void BusModelsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusModel>(db.BusModels, db);
            catalogBusOnWayTrack.Show();
        }

        private void BusDepotsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusDepot>(db.BusDepots, db);
            catalogBusOnWayTrack.Show();
        }
    }
}
