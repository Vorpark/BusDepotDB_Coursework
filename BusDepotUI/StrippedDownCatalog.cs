﻿using BusDepotBL.Model;
using BusDepotUI.Editing_Forms;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows.Forms;

namespace BusDepotUI
{
    public partial class StrippedDownCatalog<T> : Form
        where T : class
    {
        BusDepotContext db;
        DbSet<T> set;
        public StrippedDownCatalog(DbSet<T> set, BusDepotContext db)
        {
            InitializeComponent();
            this.db = db;
            this.set = set;
            set.Load();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            var id = dataGridView.SelectedRows[0].Cells[0].Value;

            if (set.Find(id) is Bus bus)
            {
                var form = new BusEditTrack(bus);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                }
            }
        }
    }
}