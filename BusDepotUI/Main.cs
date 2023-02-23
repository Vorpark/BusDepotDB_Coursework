using BusDepotBL.Model;
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

        private void BusesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new StrippedDownCatalog<Bus>(db.Buses, db);
            catalogBusOnWayTrack.Show();
        }

        private void BusesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses, db);
            catalogBusOnWayTrack.Show();
        }

        private void DriversEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Driver>(db.Drivers, db);
            catalogBusOnWayTrack.Show();
        }

        private void RoutesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Route>(db.Routes, db);
            catalogBusOnWayTrack.Show();
        }

        private void BusModelsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusModel>(db.BusModels, db);
            catalogBusOnWayTrack.Show();
        }

        private void BusDepotsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusDepot>(db.BusDepots, db);
            catalogBusOnWayTrack.Show();
        }
    }
}
