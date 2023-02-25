using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusModelAdd : Form
    {
        public BusModel BusModel { get; set; }
        BusDepotContext db;
        public BusModelAdd()
        {
            InitializeComponent();
        }
        public BusModelAdd(BusDepotContext db) : this()
        {
            this.db = db;
        }
        public BusModelAdd(BusModel busModel, BusDepotContext db) : this(db)
        {
            BusModel= busModel;
            textBox1.Text = busModel.BusName;
        }
        private void button_Click(object sender, EventArgs e)
        {
            var busModel = BusModel ?? new BusModel();
            bool check = true;

            if (textBox1.Text != "")
            {
                var busModelName = db.BusModels.FirstOrDefault(x => x.BusName == textBox1.Text);
                if (busModelName == null)
                {
                    busModel.BusName = textBox1.Text;
                }
                else
                {
                    MessageBox.Show("Данная модель уже зарегистрирована", "Ошибка!", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else
            {
                MessageBox.Show("Название модели не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (check == true)
            {
                BusModel = busModel;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
