using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTechERP
{
    public partial class ObjetosImpresionesCxP : Form
    {
        public ObjetosImpresionesCxP()
        {
            InitializeComponent();
        }

        private void btnAbrirCxP_Click(object sender, EventArgs e)
        {
            if (rbResumido.Checked == true)
            {
                SaldoPorAntiguedadCXP cxp = new SaldoPorAntiguedadCXP();
                cxp.Show();
            }
            else
            {
                SaldoPorAntiguedadCxPDetallado cxpd = new SaldoPorAntiguedadCxPDetallado();
                cxpd.Show();
            }
        }
    }
}
