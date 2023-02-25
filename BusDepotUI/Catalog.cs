using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Collections.Generic;
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
        public Catalog(List<T> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            dataGridView.DataSource = set;
        }
        public Catalog(DbSet<T> set, BusDepotContext db)
        {
                InitializeComponent();
                this.db = db;
                this.set = set;
                set.Load();
                dataGridView.DataSource = set.Local.ToBindingList();

                //TODO: Реализация нового столбца с ICollection определенного класса
                dataGridView.AutoGenerateColumns = false;
                dataGridView.Columns.RemoveAt(dataGridView.Columns.Count - 1);
        }
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Bus))
            {
                if (set.Find(id) is Bus bus)
                {
                    var form = new BusAdd(bus, db);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                if (set.Find(id) is Driver driver)
                {
                    var form = new DriverAdd(driver, db);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                if (set.Find(id) is BusDepot busDepot)
                {
                    var form = new BusDepotAdd(busDepot, db);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(Route))
            {
                if (set.Find(id) is Route route)
                {
                    var form = new RouteAdd(route, db);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                if (set.Find(id) is BusModel busModel)
                {
                    var form = new BusModelAdd(busModel, db);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        db.SaveChanges();
                    }
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Bus))
            {
                Bus bus = db.Buses.FirstOrDefault(x => x.BusId == (int)id);
                db.Buses.Attach(bus);
                db.Buses.Remove(bus);
                db.SaveChanges();
            }
            else if (typeof(T) == typeof(Driver))
            {
                Driver driver = db.Drivers.FirstOrDefault(x => x.DriverId == (int)id);
                db.Drivers.Attach(driver);
                db.Drivers.Remove(driver);
                db.SaveChanges();
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                BusDepot busDepot = db.BusDepots.FirstOrDefault(x => x.BusDepotId == (int)id);
                db.BusDepots.Attach(busDepot);
                db.BusDepots.Remove(busDepot);
                db.SaveChanges();

            }
            else if (typeof(T) == typeof(Route))
            {
                Route route = db.Routes.FirstOrDefault(x => x.RouteId == (int)id);
                db.Routes.Attach(route);
                db.Routes.Remove(route);
                db.SaveChanges();
            }
            else if (typeof(T) == typeof(BusModel))
            {
                BusModel busModel = db.BusModels.FirstOrDefault(x => x.BusModelId == (int)id);
                db.BusModels.Attach(busModel);
                db.BusModels.Remove(busModel);
                db.SaveChanges();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Bus))
            {
                var form = new BusAdd(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Buses.Add(form.Bus);
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                var form = new DriverAdd(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Drivers.Add(form.Driver);
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                var form = new BusDepotAdd(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.BusDepots.Add(form.BusDepot);
                    db.SaveChanges();
                }

            }
            else if (typeof(T) == typeof(Route))
            {
                var form = new RouteAdd(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.Routes.Add(form.Route);
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                var form = new BusModelAdd(db);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.BusModels.Add(form.BusModel);
                    db.SaveChanges();
                }
            }
        }
    }
}
