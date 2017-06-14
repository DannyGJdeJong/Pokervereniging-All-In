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
    public partial class MasterclassAddView : Form
    {
        BekendeSpelerController BekendeSpelerDB = new BekendeSpelerController();
        LocatieController LocatieDB = new LocatieController();
        MasterclassController MasterDB = new MasterclassController();
        EventController MasterclassEvent = new EventController();
        
        public MasterclassAddView()
        {
            InitializeComponent();
        }

        private void AddView_Load(object sender, EventArgs e)
        {
            foreach (BekendeSpeler speler in BekendeSpelerDB.GetBekendeSpeler())
            {
                CBAdd.Items.Add(speler.Roepnaam);
            }
            foreach (Locatie locatie in LocatieDB.GetLocaties())
            {
                CBLocatie.Items.Add(locatie.Adres);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeEvent();
            if(BSubmit.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void MakeEvent()
        {
            Event EventValues = new Event();
            EventValues.Datum = DtPicker.Value;
            EventValues.L_code = LocatieDB.GetLCode(CBLocatie.Text); ;
            MasterclassEvent.InsertEvent(EventValues);
            int Temp_Ecode = MasterclassEvent.GetEventID(MasterclassEvent);
            MakeMasterclass(Temp_Ecode);
        }
        private void MakeMasterclass(int Temp_Ecode)
        {
            Masterclass temp_masterclass = new Masterclass();
            temp_masterclass.Bekende_Speler.P_Code = BekendeSpelerDB.GetPCode(CBAdd.Text);
            temp_masterclass.E_code = Temp_Ecode;
            if(string.IsNullOrEmpty(TxtRating.Text))
            {
                throw new ArgumentException("Het rating veld moet ingevuld worden");
            }
            else
            {
                temp_masterclass.Minimale_rating = int.Parse(TxtRating.Text);
            }
            MasterDB.Insertmasterclass(temp_masterclass);
        }
    }
}
