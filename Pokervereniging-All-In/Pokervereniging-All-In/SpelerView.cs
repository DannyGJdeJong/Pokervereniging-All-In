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
    public partial class SpelerView : Form
    {
        public SpelerView()
        {
            InitializeComponent();
            SpelerController spelerCont = new SpelerController();
            foreach (Speler speler in spelerCont.GetSpelers())
            {
                ListViewItem item = new ListViewItem(speler.Naam);
                item.SubItems.Add(speler.Adres);
                item.SubItems.Add(speler.Emailadres);
                lstToernooi.Items.Add(item);
            }
        }


    }
}
