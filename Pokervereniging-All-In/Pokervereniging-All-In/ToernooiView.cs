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
            DeelnameController deelnameController = new DeelnameController();
            if (deelnameController.GetDeelnames(toernooi.E_code).Count != 0)
            {
                DrawTafels();
            }


            
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
            numTafels.Maximum = toernooi.Locatie.Aantal_tafels;           
        }

        private void DrawTafels()
        {
            for (int i = 0; i < toernooi.Locatie.Aantal_tafels; i++)
            {
                PictureBox picTafel = new PictureBox();
                picTafel.Image = Image.FromFile("../../PokerTafel.png");
                picTafel.InitialImage = null;
                picTafel.Name = "picTafel";
                picTafel.Size = new System.Drawing.Size(240, 135);
                picTafel.Location = new System.Drawing.Point((picTafel.Size.Width + 12) * (i % 2) + 12, (picTafel.Size.Height + 12) * (i / 2) + 12);
                picTafel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                picTafel.TabIndex = 12;
                picTafel.TabStop = false;
                this.Controls.Add(picTafel);
                picTafel.Show();
            }
        }

        private void btnTafelindeling_Click(object sender, EventArgs e)
        {
            DeelnameController DC = new DeelnameController();
            DC.InsertDeelnames(toernooi.E_code, Convert.ToInt32(numTafels.Value));
        }

        private void BtnKiesWinnaars_Click(object sender, EventArgs e)
        {
            ToernooiWinnersView toernooiWinnersView = new ToernooiWinnersView(toernooi);
            toernooiWinnersView.Show();
        }

        private void BtnChangeToernooi_Click(object sender, EventArgs e)
        {
            ToernooiChangeView toernooiChangeView = new ToernooiChangeView(toernooi);
            toernooiChangeView.Show();         
        }

        private void numTafels_ValueChanged(object sender, EventArgs e)
        {
            decimal ammount = toernooi.Locatie.Aantal_tafels / numTafels.Value;
            if (decimal.Truncate(ammount) != ammount)
            {
                label3.Text = this.label3.Text = "tafel(s) geeft " + Math.Floor(ammount) + " (of " + Math.Ceiling(ammount) + " spelers per tafel";
            }
            else
            {
                label3.Text = this.label3.Text = "tafel(s) geeft " + ammount + " spelers per tafel";
            }
        }
    }
}
