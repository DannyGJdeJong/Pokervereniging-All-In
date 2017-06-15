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
    public partial class MasterclassUpdateView : Form
    {
        BekendeSpelerController BekendeSpelerDB = new BekendeSpelerController();
        LocatieController LocatieDB = new LocatieController();
        MasterclassController MasterDB = new MasterclassController();
        EventController EventDB = new EventController();
        public MasterclassUpdateView()
        {
            InitializeComponent();
            
        }

        private void MasterclassUpdateView_Load(object sender, EventArgs e)
        {
            foreach (BekendeSpeler speler in BekendeSpelerDB.GetBekendeSpeler())
            {
                CBUpdateSpeler.Items.Add(speler.Roepnaam);
            }
            foreach (Locatie locatie in LocatieDB.GetLocaties())
            {
                CBUpdateLocatie.Items.Add(locatie.Straat);
            }
        }

        private void BSubmit_Click(object sender, EventArgs e)
        {
            UpdateEvent();
            if (BSubmit.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }
        private void UpdateEvent()
        {

                Event EventValues = new Event();
                EventValues.Datum = DateTime.Parse(DtUpdatePicker.Text);
                EventValues.L_code = LocatieDB.GetLCode(CBUpdateLocatie.Text);
                EventValues.E_code = int.Parse(TxtUpdateEcode.Text);
                EventDB.UpdateEvent(EventValues);
                UpdateMasterclass();
        }
        private void UpdateMasterclass()
        {
            Masterclass temp_masterclass = new Masterclass();
            temp_masterclass.Minimale_rating = int.Parse(TxtUpdateRating.Text);
            temp_masterclass.Bekende_Speler.P_Code = BekendeSpelerDB.GetPCode(CBUpdateSpeler.Text);
            temp_masterclass.E_code = int.Parse(TxtUpdateEcode.Text);
            MasterDB.Updatemasterclass(temp_masterclass);
        }
    }
}
