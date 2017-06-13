﻿using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokervereniging_All_In.Database
{
    public partial class MasterclassView : Form
    {
        MasterclassController masterDB = new MasterclassController();

        public MasterclassView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasterclassAddView addview = new MasterclassAddView();
            addview.Show();
        }

        private void MasterclassView_Load(object sender, EventArgs e)
        {
        }

        private void MasterclassView_Activated(object sender, EventArgs e)
        {
            MasterView.Items.Clear();
            foreach (Masterclass test in masterDB.GetMasterclasses())
            {
                ListViewItem item = new ListViewItem(test.E_code.ToString());
                item.SubItems.Add(test.Minimale_rating.ToString());
                item.SubItems.Add(test.Bekende_speler.ToString());
                MasterView.Items.Add(item);
            }
        }
    }
}
