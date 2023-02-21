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

        private void BusDepotTrackToolStripMenuItem_Click(object sender, EventArgs e) //TODO:Сортировка
        {
            var catalogBusDepotTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == false).ToList());
            catalogBusDepotTrack.Show();
        }

        private void BusOnWayTrackToolStripMenuItem_Click(object sender, EventArgs e) //TODO:Сортировка
        {
            var catalogBusOnWayTrack = new Catalog<Bus>(db.Buses.Where(x => x.BusOnWay == true).ToList());
            catalogBusOnWayTrack.Show();
        }
    }
}
