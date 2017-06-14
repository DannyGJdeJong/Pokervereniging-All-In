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

namespace Pokervereniging_All_In.Database
{
    public partial class MasterclassView : Form
    {
        MasterclassController masterDB = new MasterclassController();
        EventController EventDB = new EventController();

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
            foreach (Masterclass value in masterDB.GetMasterclasses())
            {
                ListViewItem item = new ListViewItem(value.Datum.ToShortDateString());
                item.SubItems.Add(value.Minimale_rating.ToString());
                item.SubItems.Add(value.Bekende_Speler.Roepnaam);
                item.SubItems.Add(value.locatie.Adres);
                MasterView.Items.Add(item);
            }
        }
    }
}
