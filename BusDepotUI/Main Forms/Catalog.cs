using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        BusDepotContext db; 
        DbSet<T> set;
        public Catalog(DbSet<T> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
            dataGridView.AutoGenerateColumns = false;
        }

        private void UpdateColumn()
        {
            dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
            var newColumn = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(newColumn);

            if (typeof(T) == typeof(Bus))
            {
                newColumn.HeaderText = "Drivers";
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string cellValue = null;
                    var rowItemId = dataGridView.Rows[i].Cells[0].Value;

                    var itemsCollection = db.Buses.First(x => x.BusId == (int)rowItemId).Drivers;
                    foreach (var item in itemsCollection)
                    {
                        cellValue += $"{item.DriverFullName}, ";
                    }
                    dataGridView[newColumn.Index, i].Value = cellValue;
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                newColumn.HeaderText = "Buses";
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string cellValue = null;
                    var rowItemId = dataGridView.Rows[i].Cells[0].Value;

                    var itemsCollection = db.Drivers.First(x => x.DriverId == (int)rowItemId).Buses;
                    foreach (var item in itemsCollection)
                    {
                        cellValue += $"{item.BusNumber}, ";
                    }
                    dataGridView[newColumn.Index, i].Value = cellValue;
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                newColumn.HeaderText = "Buses";
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string cellValue = null;
                    var rowItemId = dataGridView.Rows[i].Cells[0].Value;

                    var itemsCollection = db.BusDepots.First(x => x.BusDepotId == (int)rowItemId).Buses;
                    foreach (var item in itemsCollection)
                    {
                        cellValue += $"{item.BusNumber}, ";
                    }
                    dataGridView[newColumn.Index, i].Value = cellValue;
                }
            }
            else if (typeof(T) == typeof(Route))
            {
                newColumn.HeaderText = "Buses";
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string cellValue = null;
                    var rowItemId = dataGridView.Rows[i].Cells[0].Value;

                    var itemsCollection = db.Routes.First(x => x.RouteId == (int)rowItemId).Buses;
                    foreach (var item in itemsCollection)
                    {
                        cellValue += $"{item.BusNumber}, ";
                    }
                    dataGridView[newColumn.Index, i].Value = cellValue;
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                newColumn.HeaderText = "Buses";
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    string cellValue = null;
                    var rowItemId = dataGridView.Rows[i].Cells[0].Value;

                    var itemsCollection = db.BusModels.First(x => x.BusModelId == (int)rowItemId).Buses;
                    foreach (var item in itemsCollection)
                    {
                        cellValue += $"{item.BusNumber}, ";
                    }
                    dataGridView[newColumn.Index, i].Value = cellValue;
                }
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;
            Form form = null;
            if (typeof(T) == typeof(Bus))
            {
                if (set.Find(id) is Bus bus)
                {
                    form = new BusEdit(bus, db);
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                if (set.Find(id) is Driver driver)
                {
                    form = new DriverEdit(driver, db);
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                if (set.Find(id) is BusDepot busDepot)
                {
                    form = new BusDepotEdit(busDepot, db);
                }
            }
            else if (typeof(T) == typeof(Route))
            {
                if (set.Find(id) is Route route)
                {
                    form = new RouteEdit(route, db);
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                if (set.Find(id) is BusModel busModel)
                {
                    form = new BusModelEdit(busModel, db);
                }
            }

            if (form.ShowDialog() == DialogResult.OK)
            {
                db.SaveChanges();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы точно хотите удалить данный объект?", "Внимание!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var id = dataGridView.SelectedRows[0].Cells[0].Value;
                if (typeof(T) == typeof(Bus))
                {
                    Bus bus = db.Buses.First(x => x.BusId == (int)id);
                    db.Buses.Attach(bus);
                    db.Buses.Remove(bus);
                }
                else if (typeof(T) == typeof(Driver))
                {
                    Driver driver = db.Drivers.First(x => x.DriverId == (int)id);
                    db.Drivers.Attach(driver);
                    db.Drivers.Remove(driver);
                }
                else if (typeof(T) == typeof(BusDepot))
                {
                    BusDepot busDepot = db.BusDepots.First(x => x.BusDepotId == (int)id);
                    db.BusDepots.Attach(busDepot);
                    db.BusDepots.Remove(busDepot);

                }
                else if (typeof(T) == typeof(Route))
                {
                    Route route = db.Routes.First(x => x.RouteId == (int)id);
                    db.Routes.Attach(route);
                    db.Routes.Remove(route);
                }
                else if (typeof(T) == typeof(BusModel))
                {
                    BusModel busModel = db.BusModels.First(x => x.BusModelId == (int)id);
                    db.BusModels.Attach(busModel);
                    db.BusModels.Remove(busModel);
                }
                db.SaveChanges();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Bus))
            {
                var form = new BusEdit(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Buses.Add(form.Bus);
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                var form = new DriverEdit(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Drivers.Add(form.Driver);
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                var form = new BusDepotEdit(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.BusDepots.Add(form.BusDepot);
                }

            }
            else if (typeof(T) == typeof(Route))
            {
                var form = new RouteEdit(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Routes.Add(form.Route);
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                var form = new BusModelEdit(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.BusModels.Add(form.BusModel);
                }
            }
            db.SaveChanges();
        }

        private void dataGridView_Enter(object sender, EventArgs e)
        {
            UpdateColumn();
        }

        private void dataGridView_Sorted(object sender, EventArgs e)
        {
            UpdateColumn();
        }
    }
}
