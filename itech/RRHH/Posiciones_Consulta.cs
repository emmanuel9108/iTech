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
    public partial class Posiciones_Consulta : Form
    {
        public Posiciones_Consulta()
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
            Posiciones pantallaRRHH = new Posiciones();
            this.Close();
            pantallaRRHH.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Objetos_Impresiones.Compras.gpDevolucionImpresion gpDevolucionImpresion = new Objetos_Impresiones.Compras.gpDevolucionImpresion();
            gpDevolucionImpresion.Show();
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Posición")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.White;
            }
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Posición";
                richTextBox1.ForeColor = Color.DarkGray;                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
