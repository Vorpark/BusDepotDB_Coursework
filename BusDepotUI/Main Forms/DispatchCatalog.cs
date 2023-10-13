using BusDepotBL.Model;
using System;
using System.Data.Entity;
using System.Linq;
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
            var routeNumbers = db.Routes.Select(x => x.RouteNumber);
            foreach(var item in routeNumbers)
            {
                comboBox.Items.Add(item);
            }
            comboBox.SelectedIndex = 0;
            UpdateLabelRouteNameOfCurrentRoute();
            UpdateDataGridViewOfCurrentRoute();
        }
        private void UpdateLabelRouteNameOfCurrentRoute()
        {
            labelRouteNameOfCurrentRoute.Text = db.Routes.First(x => x.RouteNumber.ToString() == comboBox.Text).RouteName;
        }
        private void UpdateDataGridViewOfCurrentRoute()
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            var i = 0;
            var newColumn1 = new DataGridViewTextBoxColumn();
            dataGridView.Columns.Add(newColumn1);
            newColumn1.HeaderText = "BusNumber";

            var newColumn2 = new DataGridViewCheckBoxColumn();
            dataGridView.Columns.Add(newColumn2);
            newColumn2.HeaderText = "BusOnWay";

            var newColumn3 = new DataGridViewComboBoxColumn();
            dataGridView.Columns.Add(newColumn3);
            newColumn3.HeaderText = "Drivers";

            var busesOfCurrentRoute = db.Buses.Where(x => x.Route.RouteNumber.ToString() == comboBox.Text).ToList();
            foreach (var item in busesOfCurrentRoute)
            {
                dataGridView.Rows.Add();
                dataGridView[newColumn1.Index, i].Value = busesOfCurrentRoute.ElementAt(i).BusNumber;
                dataGridView[newColumn2.Index, i].Value = busesOfCurrentRoute.ElementAt(i).BusOnWay;
                i++;
            }
            var allDrivers = db.Drivers.Select(x => x.DriverFullName).ToList();
            foreach (var item in allDrivers)
            {
                newColumn3.Items.Add(item);
            }
        }
        private void AcceptChanges(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.RowCount - 1; i++)
            {
                var boolOfCheckBox = (bool)dataGridView[1, i].Value;
                if (boolOfCheckBox)
                {
                    var busName = dataGridView[0, i].Value.ToString();
                    if (dataGridView[2, i].Value != null)
                    {
                        var bus = db.Buses.First(x => x.BusNumber == busName);
                        bus.BusOnWay = true;
                        var driverName = dataGridView[2, i].Value.ToString();
                        bus.DriverOnWay = driverName;
                    }
                    else
                    {
                        MessageBox.Show($"Не выбран водитель для автобуса {busName}");
                    }
                }
            }
            //db.SaveChanges();
            MessageBox.Show("Изменения успешны!");
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelRouteNameOfCurrentRoute();
            UpdateDataGridViewOfCurrentRoute();
        }
    }
}
