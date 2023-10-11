using BusDepotBL.Model;
using BusDepotUI.Main_Forms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class Main : Form
    {
        BusDepotContext db;
        bool access = false;
        public Main()
        {
            InitializeComponent();
            db = new BusDepotContext();
            db.Buses.Load();
            UpdateStatistics();
        }
        private void UpdateStatistics()
        {
            labelAllBusesCount.Text = db.Buses.Count().ToString();
            labelActiveBusesCount.Text = db.Buses.Where(x => x.BusOnWay == true).Count().ToString();
            labelAllDriversCount.Text = db.Drivers.Count().ToString();
        }

        private void BusesTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var strippedDownCatalogBusesTrack = new StrippedDownCatalog<Bus>(db.Buses, db);
            strippedDownCatalogBusesTrack.ShowDialog();
            Show();
        }

        private void BusesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogEdit(typeof(Bus));
        }

        private void DriversEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogEdit(typeof(Driver));
        }

        private void RoutesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogEdit(typeof(Route));
        }

        private void BusModelsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogEdit(typeof(BusModel));
        }

        private void BusDepotsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogEdit(typeof(BusDepot));
        }
        private void CatalogEdit(Type type)
        {
            if (access == true || CheckPassword() == true)
            {
                Hide();
                if (type == typeof(Bus))
                {
                    var catalogBusesEdit = new Catalog<Bus>(db.Buses, db);
                    catalogBusesEdit.ShowDialog();
                }
                else if (type == typeof(Driver))
                {
                    var catalogDriversEdit = new Catalog<Driver>(db.Drivers, db);
                    catalogDriversEdit.ShowDialog();
                }
                else if (type == typeof(Route))
                {
                    var catalogRoutesEdit = new Catalog<Route>(db.Routes, db);
                    catalogRoutesEdit.ShowDialog();
                }
                else if (type == typeof(BusModel))
                {
                    var catalogBusModelsEdit = new Catalog<BusModel>(db.BusModels, db);
                    catalogBusModelsEdit.ShowDialog();
                }
                else if (type == typeof(BusDepot))
                {
                    var catalogBusDepotsEdit = new Catalog<BusDepot>(db.BusDepots, db);
                    catalogBusDepotsEdit.ShowDialog();
                }
                Show();
            }
        }
        private bool CheckPassword()
        {
            var checkPasswordForm = new CheckAdminPassword();
            if (checkPasswordForm.ShowDialog() == DialogResult.OK)
            {
                access = true;
                return true;
            }
            else
            {
                MessageBox.Show("Пароль введен не верно", "Ошибка!", MessageBoxButtons.OK);
                return false;
            }
        }

        private void Main_VisibleChanged(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private void DispatchOfBusesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var dispatchCatalogBusesTrack = new DispatchCatalog(db.Buses, db);
            dispatchCatalogBusesTrack.ShowDialog();
            Show();
        }
    }
}
