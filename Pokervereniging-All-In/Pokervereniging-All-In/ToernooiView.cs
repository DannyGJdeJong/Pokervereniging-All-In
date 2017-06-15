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
    public partial class ToernooiView : Form
    {
        public ToernooiView()
        {
            InitializeComponent();
        }

        private void ToernooiView_Activated(object sender, EventArgs e)
        {
            ToernooiController toernooiController = new ToernooiController();
            lstToernooi.Items.Clear();
            foreach (Toernooi toernooi in toernooiController.GetToernooien())
            {
                ListViewItem item = new ListViewItem(toernooi.Datum.ToShortDateString());
                item.SubItems.Add(toernooi.Inleggeld.ToString());
                item.SubItems.Add(toernooi.Mindeelnemers.ToString());
                item.SubItems.Add(toernooi.ToString());
                lstToernooi.Items.Add(item);
            }
        }
    }
}
