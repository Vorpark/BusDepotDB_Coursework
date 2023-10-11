using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class RouteEdit : Form
    {
        public Route Route { get; set; }
        BusDepotContext db;

        public RouteEdit()
        {
            InitializeComponent();
        }

        public RouteEdit(BusDepotContext db) : this()
        {
            this.db = db;
        }

        public RouteEdit(Route route, BusDepotContext db) : this(db)
        {
            Route = route;
            textBox.Text = route.RouteNumber.ToString();
        }

        private void Button_Click(object sender, EventArgs e) 
        {
            var route = Route ?? new Route();
            bool check = true;

            if (textBox.Text != "")
            {
                var number = Int32.Parse(textBox.Text);
                var routeNumber = db.Routes.FirstOrDefault(x => x.RouteNumber == number);
                if (routeNumber == null)
                {
                    route.RouteNumber = number;
                    if (textBox2.Text != "")
                    {
                        route.RouteName = textBox2.Text;
                    }
                    else
                    {
                        MessageBox.Show("Путь маршрута не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
                else
                {
                        MessageBox.Show("Данный маршрут уже зарегистрирован", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                }
            }
            else
            {
                MessageBox.Show("Номер маршрута не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }
            if (check == true)
            {
                Route = route;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
