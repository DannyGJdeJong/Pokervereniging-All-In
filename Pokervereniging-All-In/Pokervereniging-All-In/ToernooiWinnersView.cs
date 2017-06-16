using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pokervereniging_All_In.Models;
using Pokervereniging_All_In.Database;

namespace Pokervereniging_All_In
{
    public partial class ToernooiWinnersView : Form
    {
        Toernooi toernooi;
        public ToernooiWinnersView(Toernooi t)
        {
            toernooi = t;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ToernooiWinnersView_Load(object sender, EventArgs e)
        {
            SortedPlayerController SC = new SortedPlayerController();
            List<Speler> Spelers = SC.GetSpelersAndDeelnames(toernooi.E_code).Keys.ToList();
            foreach(Speler s in Spelers)
            {
                comboBox1e.Items.Add(s);
                comboBox2e.Items.Add(s);
                comboBox3e.Items.Add(s);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            ToernooiController TC = new ToernooiController();
            Speler eerste = (Speler)comboBox1e.SelectedItem;
            Speler tweede = (Speler)comboBox2e.SelectedItem;
            Speler derde = (Speler)comboBox3e.SelectedItem;
            TC.SetWinners(toernooi.E_code, eerste, tweede, derde);
        }
    }
}
