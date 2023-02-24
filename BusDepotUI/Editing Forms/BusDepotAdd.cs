using BusDepotBL.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BusDepotUI.Editing_Forms
{
    public partial class BusDepotAdd : Form
    {
        public BusDepot BusDepot { get; set; }
        BusDepotContext db;
        bool editBool = false;
        public BusDepotAdd()
        {
            InitializeComponent();
        }
        public BusDepotAdd(BusDepotContext db) : this()
        {
            this.db = db;
        }
        public BusDepotAdd(BusDepot busDepot, BusDepotContext db) : this(db)
        {
            BusDepot = busDepot;
            editBool= true;
            textBox1.Text = busDepot.BusDepotAddress;
        }
        private void button_Click(object sender, EventArgs e) 
        {
            var busDepot = BusDepot ?? new BusDepot();
            bool check = true;

            if (textBox1.Text != "")
            {
                var busDepotAddress = db.BusDepots.FirstOrDefault(x => x.BusDepotAddress == textBox1.Text);
                if (busDepotAddress == null)
                {
                    busDepot.BusDepotAddress = textBox1.Text;
                }
                else
                {
                    if (editBool == true)
                    {
                        busDepot.BusDepotAddress = textBox1.Text;
                    }
                    else
                    {
                        MessageBox.Show("Данный адрес уже зарегистрирован", "Ошибка!", MessageBoxButtons.OK);
                        check = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Адрес не может быть пустым", "Ошибка!", MessageBoxButtons.OK);
                check = false;
            }

            if (check == true)
            {
                BusDepot = busDepot;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
