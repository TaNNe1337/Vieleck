using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vieleck
{
    public partial class frm_start : Form
    {
        
        public frm_start()
        {
            InitializeComponent();
        }

        private void cmd_berechnen_Click(object sender, EventArgs e)
        {
            Vieleck vieleck = new Vieleck();
            vieleck.Seitenanzahl = Convert.ToDouble(tb_seitenanzahl.Text);
            vieleck.Seitenlaenge = Convert.ToDouble(tB_seitenlaenge.Text);
            vieleck.berechneFlaecheninhalt(); 
            lbl_ausgabe.Text = vieleck.Flaecheninhalt.ToString();
        }
    }
}
