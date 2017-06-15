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
    public partial class ToernooiView : Form
    {
        Toernooi toernooi;
        public ToernooiView(Toernooi toernooi)
        {
            this.toernooi = toernooi;
            InitializeComponent();
        }

        private void ToernooiView_Activated(object sender, EventArgs e)
        {
            LocatieController locatieController = new LocatieController();
            foreach (Locatie locatie in locatieController.GetLocaties())
            {
                cbbLocatie.Items.Add(locatie.Straat);
            }

            txtInleggeld.Text = toernooi.Inleggeld.ToString();
            txtMinDeelnemers.Text = toernooi.Mindeelnemers.ToString();
            cbbLocatie.Text = toernooi.Locatie.Straat;
        }
    }
}
