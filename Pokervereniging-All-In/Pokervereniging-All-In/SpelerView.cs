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
        List<Speler> spelerList = new List<Speler>();

        public SpelerView()
        {
            InitializeComponent();
            SpelerController spelerCont = new SpelerController();
            spelerList = spelerCont.GetSpelers();
            foreach (Speler speler in spelerList)
            {
                ListViewItem item = new ListViewItem(speler.Naam);
                item.SubItems.Add(speler.Adres);
                item.SubItems.Add(speler.Emailadres);
                lstSpeler.Items.Add(item);
            }
            SpelerDialog spelerDialog = new SpelerDialog(spelerList[lstSpeler.SelectedIndices[0]]);
            spelerDialog.Show();
        }


    }
}
