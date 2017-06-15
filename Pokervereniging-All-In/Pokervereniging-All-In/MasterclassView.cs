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
            ShowMasterclass();
        }

        private void BtUpdate_Click(object sender, EventArgs e)
        {
            UpdateMasterclass();
        }
        public void ShowMasterclass()
        {
            MasterView.Items.Clear();
            foreach (Masterclass value in masterDB.GetMasterclasses())
            {
                ListViewItem item = new ListViewItem(value.Datum.ToShortDateString());
                item.SubItems.Add(value.Minimale_rating.ToString());
                item.SubItems.Add(value.Bekende_Speler.Roepnaam);
                item.SubItems.Add(value.Locatie.Straat);
                item.SubItems.Add(value.E_code.ToString());
                MasterView.Items.Add(item);
                
            }
        }
        private void UpdateMasterclass()
        {
            if(MasterView.SelectedItems.Count > 0){
                MasterclassUpdateView UpdateView = new MasterclassUpdateView();

                ListViewItem item = MasterView.SelectedItems[0];
                string datum = item.SubItems[0].Text;
                string minimale_rating = item.SubItems[1].Text;
                string bekende_speler = item.SubItems[2].Text;
                string locatie = item.SubItems[3].Text;
                string e_code = item.SubItems[4].Text;

                UpdateView.TxtUpdateEcode.Text = e_code;
                UpdateView.TxtUpdateRating.Text = minimale_rating;
                UpdateView.DtUpdatePicker.Text = datum;
                UpdateView.CBUpdateLocatie.Text = locatie;
                UpdateView.CBUpdateSpeler.Text = bekende_speler;

                UpdateView.Show();
            }
            else{
                MessageBox.Show("Select a masterclass to update");
            }
        }
    }
}
