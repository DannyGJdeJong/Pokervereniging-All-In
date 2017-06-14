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
        int Temp_Ecode = 0;
        int Temp_Pcode = 0;
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
                CBLocatie.Items.Add(locatie.L_code);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakeEvent();
            Masterclass temp_masterclass = new Masterclass();
            foreach(BekendeSpeler speler in BekendeSpelerDB.GetBekendeSpeler())
            {
                if(speler.Roepnaam == CBAdd.Text)
                {
                    Temp_Pcode = speler.P_Code;
                    break;
                }
            }
            temp_masterclass.Bekende_speler = Temp_Pcode;
            temp_masterclass.E_code = Temp_Ecode;
            temp_masterclass.Minimale_rating = int.Parse(TxtRating.Text);
            MasterDB.Insertmasterclass(temp_masterclass);
        }

        private void MakeEvent()
        {
            Event EventValues = new Event();
            EventValues.Datum = DtPicker.Value;
            EventValues.L_code = CBLocatie.SelectedIndex;
            EventController MasterclassEvent = new EventController();
            MasterclassEvent.InsertEvent(EventValues);
            foreach (Event e in MasterclassEvent.GetEvents())
            {
               Temp_Ecode = Math.Max(e.E_code, Temp_Ecode);
            }


        }
    }


    }
