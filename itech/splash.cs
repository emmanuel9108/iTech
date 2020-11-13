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
    public partial class splash : Form
    {
        int valor = 0;
        public splash()
        {
            InitializeComponent();
            CircleProgressBar.Enabled = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            valor += 1;
            CircleProgressBar.Value = valor;
            if (CircleProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }
    }
}
