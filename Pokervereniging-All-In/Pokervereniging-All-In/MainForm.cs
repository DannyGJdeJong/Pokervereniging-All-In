﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokervereniging_All_In.Database;
using Pokervereniging_All_In.Models;

namespace Pokervereniging_All_In
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnToernooi_Click(object sender, EventArgs e)
        {
            ToernooiOverview toernooiOverview = new ToernooiOverview();
            toernooiOverview.Show();
        }

        private void btnMasterclass_Click(object sender, EventArgs e)
        {
            MasterclassView masterClassView = new MasterclassView();
            masterClassView.Show();
        }

        private void btnSpeler_Click(object sender, EventArgs e)
        {
            SpelerView spelerView = new SpelerView();
            spelerView.Show();
        }
    }
}
