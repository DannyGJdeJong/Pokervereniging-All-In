using System;
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
    public partial class ToernooiChangeView : Form
    {
        Toernooi toernooi;
        Event TEvent;
        public ToernooiChangeView(Toernooi t)
        {
            EventController EC = new EventController();
            toernooi = t;
            TEvent = EC.GetEvent(t.E_code);
            InitializeComponent();
            TxtMinDeelnemers.Text = t.Mindeelnemers.ToString();
            TxtInleggeld.Text = t.Inleggeld.ToString();
            dateTimePicker.Value = TEvent.Datum;
            LocatieController LC = new LocatieController();
            foreach(Locatie l in LC.GetLocaties())
            {
                comboBoxLocatie.Items.Add(l);
            }
            comboBoxLocatie.SelectedItem = TEvent.Locatie;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ToernooiController TC = new ToernooiController();
                Toernooi newToernooi = new Toernooi(toernooi.E_code, Convert.ToInt32(TxtMinDeelnemers.Text), Convert.ToInt32(TxtInleggeld.Text));
                Locatie selectedLocatie = (Locatie)comboBoxLocatie.SelectedItem;
                Event newEvent = new Event(toernooi.E_code, dateTimePicker.Value, selectedLocatie.L_code);
                TC.ChangeToernooi(newToernooi, newEvent);
            }
            catch
            {
                MessageBox.Show("Kan toernooi niet veranderen. check de waardes");
            }
        }
    }
}
