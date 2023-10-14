using BusDepotBL.Model;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                dataGridView[newColumn3.Index, i].Value = busesOfCurrentRoute.ElementAt(i).DriverOnWay;
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
                if (dataGridView[0, i].Value != null)
                {
                    var boolOfCheckBox = (bool)dataGridView[1, i].Value;
                    var busName = dataGridView[0, i].Value.ToString();
                    var bus = db.Buses.First(x => x.BusNumber == busName);
                    if (boolOfCheckBox)
                    {
                        if (dataGridView[2, i].Value != "")
                        {
                            var driverName = dataGridView[2, i].Value.ToString();
                            var checkDriver = db.Buses.FirstOrDefault(b => b.DriverOnWay.ToString() == driverName);
                            if (checkDriver == null || bus.DriverOnWay == driverName)
                            {
                                bus.BusOnWay = true;
                                bus.DriverOnWay = driverName;
                                db.SaveChanges();
                            }
                            else
                            {
                                bus.BusOnWay = false;
                                bus.DriverOnWay = "";
                                db.SaveChanges();
                                MessageBox.Show($"{driverName} - данный водитель уже находится в пути на другом транспорте", "Ошибка!", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Не выбран водитель для автобуса {busName}", "Ошибка!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        bus.BusOnWay = false;
                        bus.DriverOnWay = "";
                        db.SaveChanges();
                    }
                }
            }
            UpdateDataGridViewOfCurrentRoute();
            MessageBox.Show("Изменения применены!", "Успех!", MessageBoxButtons.OK);
        }

        private void comboBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelRouteNameOfCurrentRoute();
            UpdateDataGridViewOfCurrentRoute();
        }
    }
}
