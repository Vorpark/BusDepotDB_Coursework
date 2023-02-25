using BusDepotBL.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
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
            if (access == true || CheckPassword() == true)
            {
                Hide();
                var catalogBusesEdit = new Catalog<Bus>(db.Buses, db);
                catalogBusesEdit.ShowDialog();
                Show();
            }
        }

        private void DriversEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (access == true || CheckPassword() == true)
            {
                Hide();
                var catalogDriversEdit = new Catalog<Driver>(db.Drivers, db);
                catalogDriversEdit.ShowDialog();
                Show();
            }
        }

        private void RoutesEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (access == true || CheckPassword() == true)
            {
                Hide();
                var catalogRoutesEdit = new Catalog<Route>(db.Routes, db);
                catalogRoutesEdit.ShowDialog();
                Show();
            }
        }

        private void BusModelsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (access == true || CheckPassword() == true)
            {
                Hide();
                var catalogBusModelsEdit = new Catalog<BusModel>(db.BusModels, db);
                catalogBusModelsEdit.ShowDialog();
                Show();
            }
        }

        private void BusDepotsEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (access == true || CheckPassword() == true)
            {
                Hide();
                var catalogBusDepotsEdit = new Catalog<BusDepot>(db.BusDepots, db);
                catalogBusDepotsEdit.ShowDialog();
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
    }
}
