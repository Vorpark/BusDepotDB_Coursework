using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class Catalog<T> : Form
        where T : class
    {
        public Catalog(List<T> set)
        {
            InitializeComponent();
            dataGridView.DataSource = set;
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}
