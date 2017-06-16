using Pokervereniging_All_In.Database;
using Pokervereniging_All_In.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokervereniging_All_In
{
    public partial class ToernooiOverview : Form
    {
        ToernooiController toernooiController;
        List<Toernooi> toernooiList;

        public ToernooiOverview()
        {
            InitializeComponent();
        }

        private void ToernooiOverview_Activated(object sender, EventArgs e)
        {
            toernooiController = new ToernooiController();
            toernooiList = new List<Toernooi>();
            refreshView();
        }

        private void refreshView()
        {
            toernooiList = toernooiController.GetToernooien();
            lstToernooi.Items.Clear();
            foreach (Toernooi toernooi in toernooiList)
            {
                ListViewItem item = new ListViewItem(toernooi.Datum.ToShortDateString());
                item.SubItems.Add(toernooi.Inleggeld.ToString());
                item.SubItems.Add(toernooi.Mindeelnemers.ToString());
                item.SubItems.Add(toernooi.Locatie == null ? "" : toernooi.Locatie.Plaats);
                item.SubItems.Add(toernooi.ToString());
                lstToernooi.Items.Add(item);
            }
        }

        private void lstToernooi_DoubleClick(object sender, EventArgs e)
        {
            ToernooiView toernooiView = new ToernooiView(toernooiList[lstToernooi.SelectedIndices[0]]);
            toernooiView.Show();
        }

        private void BtnAddToernooi_Click(object sender, EventArgs e)
        {
            ToernooiAddView TAddView = new ToernooiAddView();
            TAddView.Show();
        }
    }
}
