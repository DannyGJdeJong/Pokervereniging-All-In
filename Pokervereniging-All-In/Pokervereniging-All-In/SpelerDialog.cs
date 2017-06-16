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
    public partial class SpelerDialog : Form
    {
        Speler speler;
        public SpelerDialog(Speler speler)
        {
            InitializeComponent();
            Text = speler.Naam;
            this.speler = speler;
            txtVoorletters.Text = speler.Voorletters;
            txtRoepnaam.Text = speler.Roepnaam;
            txtTussenvoegsels.Text = speler.Tussenvoegsels;
            txtAchternaam.Text = speler.Achternaam;
            cbbGeslacht.Text = speler.Geslacht.ToString();
            txtPostcode.Text = speler.Postcode;
            txtStraat.Text = speler.Straat;
            numHuisnummer.Value = speler.Huisnummer;
            txtWoonplaats.Text = speler.Woonplaats;
            txtEmailadres.Text = speler.Emailadres;
            txtIBAN.Text = speler.IBANnummer;
            numRating.Value = speler.Rating;
            chkStaatOpBlacklist.Checked = speler.StaatOpBlacklist;
        }

        public SpelerDialog()
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Submit()
        {
            speler.Voorletters = txtVoorletters.Text;
            speler.Roepnaam = txtRoepnaam.Text;
            speler.Tussenvoegsels = txtTussenvoegsels.Text;
            speler.Achternaam = txtAchternaam.Text;
            speler.Geslacht = cbbGeslacht.Text[0];
            speler.Postcode = txtPostcode.Text;
            speler.Straat = txtStraat.Text;
            speler.Huisnummer = Convert.ToInt32(numHuisnummer.Value);
            speler.Woonplaats = txtWoonplaats.Text;
            speler.Emailadres = txtEmailadres.Text;
            speler.IBANnummer = txtIBAN.Text;
            speler.Rating = Convert.ToInt32(numRating.Value);
            speler.StaatOpBlacklist = chkStaatOpBlacklist.Checked;

            SpelerController spelerController = new SpelerController();
            spelerController.UpdateSpeler(speler);
        }
    }
}
