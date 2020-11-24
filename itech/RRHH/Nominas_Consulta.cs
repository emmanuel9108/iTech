using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iTechERP.RRHH
{
    public partial class Nominas_Consulta : Form
    {
        public Nominas_Consulta()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Nominas pantallaRRHH = new Nominas();
            this.Close();
            pantallaRRHH.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Objetos_Impresiones.RR.HH.Nomina nomina = new Objetos_Impresiones.RR.HH.Nomina();
            nomina.Show();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Número")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.White;
            }
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Número";
                richTextBox1.ForeColor = Color.DarkGray;                
            }
        }
    }
}
