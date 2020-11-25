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
            //CircleProgressBar.Value = valor;
            //if (CircleProgressBar.Value == 100)
            //{
                
            //}

            if (this.Opacity < 1) this.Opacity += 0.05;
            CircleProgressBar.Value += 1;
            if(CircleProgressBar.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
            
        }

        private void splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                timer1.Enabled = false;
                Login lg = new Login();
                this.Hide();
                lg.Show();
            }
        }
    }
}
