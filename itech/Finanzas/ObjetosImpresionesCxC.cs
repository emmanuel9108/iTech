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
    public partial class ObjetosImpresionesCxC : Form
    {
        public ObjetosImpresionesCxC()
        {
            InitializeComponent();
        }

        private void btnAbrirCxC_Click(object sender, EventArgs e)
        {
            if (rbResumido.Checked == true)
            {
                SaldoPorAntiguedadCxC cxp = new SaldoPorAntiguedadCxC();
                cxp.Show();
            }
            else
            {
                SaldoPorAntiguedadCxCDetallado cxpd = new SaldoPorAntiguedadCxCDetallado();
                cxpd.Show();
            }
        }
    }
}
