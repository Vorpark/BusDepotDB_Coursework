using BusDepotBL.Model;
using System;
using System.Data.Entity;
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

        }

        private void AcceptChanges(object sender, EventArgs e)
        {

        }
    }
}
