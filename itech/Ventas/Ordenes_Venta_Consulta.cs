using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iTechERP.Ventas
{
    public partial class Ordenes_Venta_Consulta : Form
    {
        public Ordenes_Venta_Consulta()
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
           Ordenes_V Ordenes_Ventas = new Ordenes_V();
            this.Close();
            Ordenes_Ventas.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Objetos_Impresiones.Ventas.vdDocOrden gpDevolucionImpresion = new Objetos_Impresiones.Ventas.vdDocOrden();
            gpDevolucionImpresion.Show();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Cliente")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.White;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Cliente";
                richTextBox1.ForeColor = Color.DarkGray;
            }
        }
    }
}
