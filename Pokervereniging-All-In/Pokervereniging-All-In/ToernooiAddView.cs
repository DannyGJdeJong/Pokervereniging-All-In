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
    public partial class ToernooiAddView : Form
    {
        public ToernooiAddView()
        {
            InitializeComponent();
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                EventController eventController = new EventController();
                Locatie l = (Locatie)comboBoxLocatie.SelectedItem;
                Event temp_event = new Event(0, dateTimePicker1.Value, l.L_code);
                eventController.InsertEvent(temp_event);

                Toernooi toernooi = new Toernooi(eventController.GetEventID(eventController), Convert.ToInt32(TxtInleggeld.Text), Convert.ToInt32(TxtInleggeld.Text));
                ToernooiController toernooiController = new ToernooiController();
                toernooiController.InsertToernooi(toernooi);
            }
            catch
            {
                MessageBox.Show("Kan toernooi niet toevoegen check de waardes");
            }
        }

        private void ToernooiAddView_Load(object sender, EventArgs e)
        {
            LocatieController LC = new LocatieController();
            List<Locatie> Locaties = LC.GetLocaties();
            foreach(Locatie l in Locaties)
            {
                comboBoxLocatie.Items.Add(l);
            }           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
