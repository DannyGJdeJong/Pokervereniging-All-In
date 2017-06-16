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
            this.speler = speler;
        }
    }
}
