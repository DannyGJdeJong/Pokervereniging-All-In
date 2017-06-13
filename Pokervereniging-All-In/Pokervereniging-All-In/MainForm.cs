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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGetSpelers_Click(object sender, EventArgs e)
        {
            SpelerController spelerCont = new SpelerController();
            foreach (Speler speler in spelerCont.GetSpelers())
            {
                lstSpelers.Items.Add(speler);
            }
        }
    }
}
