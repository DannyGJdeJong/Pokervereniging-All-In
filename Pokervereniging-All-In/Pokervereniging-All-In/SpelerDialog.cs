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
    }
}
