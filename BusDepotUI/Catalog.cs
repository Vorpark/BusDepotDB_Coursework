using BusDepotBL.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        BusDepotContext db;
        public Catalog(List<T> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            dataGridView.DataSource = set;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
