using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class StrippedDownCatalog<T> : Form
        where T : class
    {
        BusDepotContext db;
        DbSet<T> set;
        public StrippedDownCatalog(DbSet<T> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            dataGridView.DataSource = set.Local.ToBindingList();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (set.Find(id) is Bus bus)
            {
                var form = new BusTrackEdit(bus, db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}
