using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        }
        private void buttonEdit_Click(object sender, EventArgs e) //Реализовать через свитч для остальных
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Bus))
            {
                var bus = set.Find(id) as Bus;
                if (bus != null)
                {
                    var form = new BusAdd(bus);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        bus = form.Bus;
                        db.SaveChanges();

                    }
                }
            }
            else if (typeof(T) == typeof(Driver))
            {
                var driver = set.Find(id) as Driver;
                if (driver != null)
                {
                    var form = new DriverAdd(driver);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        driver = form.Driver;
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(BusDepot))
            {
                var busDepot = set.Find(id) as BusDepot;
                if (busDepot != null)
                {
                    var form = new BusDepotAdd(busDepot);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        busDepot = form.BusDepot;
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(Route))
            {
                var route = set.Find(id) as Route;
                if (route != null)
                {
                    var form = new RouteAdd(route);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        route = form.Route;
                        db.SaveChanges();
                    }
                }
            }
            else if (typeof(T) == typeof(BusModel))
            {
                var busModel = set.Find(id) as BusModel;
                if (busModel != null)
                {
                    var form = new BusModelAdd(busModel);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        busModel = form.BusModel;
                        db.SaveChanges();
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
