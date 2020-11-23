using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace iTechERP.Compras
{
    public partial class Inventario_Consulta : Form
    {
        public Inventario_Consulta()
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
            Ordenes_Compra devoluciones_Compra = new Ordenes_Compra();
            this.Close();
            devoluciones_Compra.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Objetos_Impresiones.Compras.gpOrdenCorporativa gpDevolucionImpresion = new Objetos_Impresiones.Compras.gpOrdenCorporativa();
            gpDevolucionImpresion.Show();
        }

        private void richTextBox1_Enter(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "Proveedor")
            {
                richTextBox1.Text = "";
                richTextBox1.ForeColor = Color.White;
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Proveedor";
                richTextBox1.ForeColor = Color.DarkGray;
            }
        }
    }
}
