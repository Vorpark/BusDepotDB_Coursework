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
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses.ToList(), db);
            catalogBusOnWayTrack.Show();
        }

        private void DriversTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Driver>(db.Drivers.ToList(), db);
            catalogBusOnWayTrack.Show();
        }

        private void RoutesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<Route>(db.Routes.ToList(), db);
            catalogBusOnWayTrack.Show();
        }

        private void BusModelsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusModel>(db.BusModels.ToList(), db);
            catalogBusOnWayTrack.Show();
        }

        private void BusDepotsTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogBusOnWayTrack = new Catalog<BusDepot>(db.BusDepots.ToList(), db);
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

        private void BusAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new BusAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Buses.Add(form.Bus);
                db.SaveChanges();
            }
        }

        private void DriverAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new DriverAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Drivers.Add(form.Driver);
                db.SaveChanges();
            }
        }

        private void BusModelAddToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form = new BusModelAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.BusModels.Add(form.BusModel);
                db.SaveChanges();
            }
        }

        private void BusDepotAddToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var form = new BusDepotAdd();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.BusDepots.Add(form.BusDepot);
                db.SaveChanges();
            }
        }
    }
}
