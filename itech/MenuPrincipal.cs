using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using iTechERP.Objetos_Impresiones.Compras;
using iTechERP.Objetos_Impresiones.Ventas;
using iTechERP.Objetos_Impresiones.RR.HH;

namespace iTechERP
{
    public partial class MenuPrincipal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public MenuPrincipal()
        {
            InitializeComponent();
            random = new Random();
            btnCerrarFormHijo.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            int index = random.Next(Temas.ColorList.Count);
            while (tempIndex == index)
            {
               index = random.Next(Temas.ColorList.Count);
            }
            tempIndex = index;
            string color = Temas.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                  //  panelTitulo.BackColor = color;
                    panelLogo.BackColor = Temas.ChangeColorBrightness(color, -0.3);
                    Temas.PrimaryColor = color;
                    Temas.SecondaryColor = Temas.ChangeColorBrightness(color, 0.3);
                    btnCerrarFormHijo.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button) || (previousBtn.GetType() == typeof(IconButton)))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           // lblTitulo.Text = childForm.Text;
        }


        public void btnCerrarFormHijo_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelSeguridad.Width = 10;
                panelSistema.Width = 10;
                panelFinanzas.Width = 10;
                panelVentas.BackColor = Color.White;
                panelCompras.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
                panelFinanzas.BackColor = Color.White;
            panelFecha.BringToFront();
            Reset();
        }

        public void Reset()
        {
            DisableButton();
            lblTitulo.Text = "iTech ERP";
            panelTitulo.BackColor = Color.FromArgb(89, 136, 255);
            panelLogo.BackColor = Color.FromArgb(39, 39, 39);
            currentButton = null;
            btnCerrarFormHijo.Visible = false;
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ResetPanels(string panel)
        {
            if (panel == "Compras")
            {
                panelCompras.Width = 220;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelFinanzas.Width = 10;
                panelSeguridad.Width = 10;
                panelSistema.Width = 10;
                panelCompras.BringToFront();
                

                panelVentas.BackColor = Color.White;
                panelCompras.BackColor = Color.FromArgb(51, 51, 76);
                panelFinanzas.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
            }
            else if (panel == "Ventas")
            {
                panelCompras.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelSeguridad.Width = 10;
                panelFinanzas.Width = 10;
                panelSistema.Width = 10;
                panelVentas.Width = 220;
                panelVentas.BringToFront();

                panelCompras.BackColor = Color.White;
                panelVentas.BackColor = Color.FromArgb(51, 51, 76);
                panelRecursosHumanos.BackColor = Color.White;
                panelFinanzas.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
            }
            else if (panel == "Recursos Humanos")
            {
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 220;
                panelSeguridad.Width = 10;
                panelFinanzas.Width = 10;
                panelSistema.Width = 10;
                panelRecursosHumanos.BringToFront();

                panelCompras.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.FromArgb(51, 51, 76);
                panelVentas.BackColor = Color.White;
                panelFinanzas.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
            }
            else if (panel == "Seguridad")
            {
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelFinanzas.Width = 10;
                panelSeguridad.Width = 220;
                panelSistema.Width = 10;
                panelSeguridad.BringToFront();

                panelCompras.BackColor = Color.White;
                panelSeguridad.BackColor = Color.FromArgb(51, 51, 76);
                panelFinanzas.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelVentas.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
            }
            else if (panel == "Sistema")
            {
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelFinanzas.Width = 10;
                panelSistema.Width = 220;
                panelSeguridad.Width = 10;
                panelSistema.BringToFront();

                panelCompras.BackColor = Color.White;
                panelSistema.BackColor = Color.FromArgb(51, 51, 76);
                panelFinanzas.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelVentas.BackColor = Color.White;
            }
            else if (panel == "Finanzas")
            {
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelFinanzas.Width = 220;
                panelSistema.Width = 10;
                panelSeguridad.Width = 10;
                panelFinanzas.BringToFront();

                panelCompras.BackColor = Color.White;
                panelFinanzas.BackColor = Color.FromArgb(51, 51, 76);
                panelSistema.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelVentas.BackColor = Color.White;
            }
            else if (panel == "Todos")
            {
                panelCompras.Width = 10;
                panelVentas.Width = 10;
                panelRecursosHumanos.Width = 10;
                panelSeguridad.Width = 10;
                panelFinanzas.Width = 10;
                panelSistema.Width = 10;
                panelFecha.BringToFront();

                panelCompras.BackColor = Color.White;
                panelVentas.BackColor = Color.White;
                panelRecursosHumanos.BackColor = Color.White;
                panelSeguridad.BackColor = Color.White;
                panelFinanzas.BackColor = Color.White;
                panelSistema.BackColor = Color.White;
            }
        }



        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnCompras_Click(object sender, EventArgs e)
        {
            if (panelCompras.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnOrdenesCompras.BackColor = Color.FromArgb(255, 252, 245);
                btnOrdenesCompras.ForeColor = Color.Black;
                btnPagos.BackColor = Color.FromArgb(255, 252, 245);
                btnPagos.ForeColor = Color.Black;
                btnProveedores.BackColor = Color.FromArgb(255, 252, 245);
                btnProveedores.ForeColor = Color.Black;
                btnEntradaMercancia.BackColor = Color.FromArgb(255, 252, 245);
                btnEntradaMercancia.ForeColor = Color.Black;
                btnDevoluciones.BackColor = Color.FromArgb(255, 252, 245);
                btnDevoluciones.ForeColor = Color.Black;
                btnInventario.BackColor = Color.FromArgb(255, 252, 245);
                btnInventario.ForeColor = Color.Black;
                btnFacturasCompra.BackColor = Color.FromArgb(255, 252, 245);
                btnFacturasCompra.ForeColor = Color.Black;
                ResetPanels("Compras");
                ActivateButton(sender);
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            if (panelVentas.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnFacturasVenta.BackColor = Color.FromArgb(255, 252, 245);
                btnFacturasVenta.ForeColor = Color.Black;
                btnClientes.BackColor = Color.FromArgb(255, 252, 245);
                btnClientes.ForeColor = Color.Black;
                btnIngresos.BackColor = Color.FromArgb(255, 252, 245);
                btnIngresos.ForeColor = Color.Black;
                btnOrdenesVenta.BackColor = Color.FromArgb(255, 252, 245);
                btnOrdenesVenta.ForeColor = Color.Black;
                ResetPanels("Ventas");
                ActivateButton(sender);
            }
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            if (panelSistema.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnProductos.BackColor = Color.FromArgb(255, 252, 245);
                btnProductos.ForeColor = Color.Black;
                btnPaises.BackColor = Color.FromArgb(255, 252, 245);
                btnPaises.ForeColor = Color.Black;
                btnProvincias.BackColor = Color.FromArgb(255, 252, 245);
                btnProvincias.ForeColor = Color.Black;
                btnCiudades.BackColor = Color.FromArgb(255, 252, 245);
                btnCiudades.ForeColor = Color.Black;
                btnSectores.BackColor = Color.FromArgb(255, 252, 245);
                btnSectores.ForeColor = Color.Black;
                ResetPanels("Sistema");
                ActivateButton(sender);
            }
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            if (panelSeguridad.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnUsuarios.BackColor = Color.FromArgb(255, 252, 245);
                btnUsuarios.ForeColor = Color.Black;
                btnRolesUsuarios.BackColor = Color.FromArgb(255, 252, 245);
                btnRolesUsuarios.ForeColor = Color.Black;
                btnRolesAccesos.BackColor = Color.FromArgb(255, 252, 245);
                btnRolesAccesos.ForeColor = Color.Black;
                ResetPanels("Seguridad");
                ActivateButton(sender);
            }
        }

        private void btnRecursosHumanos_Click(object sender, EventArgs e)
        {
            if (panelRecursosHumanos.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnDepartamentos.BackColor = Color.FromArgb(255, 252, 245);
                btnDepartamentos.ForeColor = Color.Black;
                btnPosiciones.BackColor = Color.FromArgb(255, 252, 245);
                btnPosiciones.ForeColor = Color.Black;
                btnEmpleados.BackColor = Color.FromArgb(255, 252, 245);
                btnEmpleados.ForeColor = Color.Black;
                btnNominas.BackColor = Color.FromArgb(255, 252, 245);
                btnNominas.ForeColor = Color.Black;
                ResetPanels("Recursos Humanos");
                ActivateButton(sender);
            }
        }

        private void timerFechaHoraActual_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            if (panelFinanzas.Width == 220)
            {
                ResetPanels("Todos");
            }
            else
            {
                btnCxC.BackColor = Color.FromArgb(255, 252, 245);
                btnCxC.ForeColor = Color.Black;
                btnCxP.BackColor = Color.FromArgb(255, 252, 245);
                btnCxP.ForeColor = Color.Black;
                btnMonedas.BackColor = Color.FromArgb(255, 252, 245);
                btnMonedas.ForeColor = Color.Black;
                ResetPanels("Finanzas");
                ActivateButton(sender);
            }
        }
        private void btnCxP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ObjetosImpresionesCxP(), sender);
        }

        private void btnCxC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ObjetosImpresionesCxC(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new gpFacturaCorporativa(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea cerrar sección?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }

        private void btnFacturasCompra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Facturas_Compra_consulta(), sender);
        }

        private void btnOrdenesCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Ordenes_Compra_Consulta(), sender);
        }

        private void panelCompras_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Devoluciones_Compra_Consulta(), sender);
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Pagos_Consulta(), sender);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Proveedores_consulta(), sender);
        }

        private void btnEntradaMercancia_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Entradas_Consulta(), sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ventas.Cliente_consulta(), sender);
        }

        private void btnOrdenesVenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ventas.Ordenes_Venta_Consulta(), sender);
        }

        private void btnFacturasVenta_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ventas.Facturas_Ventas_consulta(), sender);
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ventas.Ingresos_Consulta(), sender);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Compras.Inventario_Consulta(), sender);
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RRHH.Departamentos_Consulta(), sender);
        }

        private void btnPosiciones_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RRHH.Posiciones_Consulta(), sender);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RRHH.Empleados_Consulta(), sender);
        }

        private void btnNominas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RRHH.Nominas_Consulta(), sender);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Productos_Consulta(), sender);
        }

        private void btnPaises_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Paises_Consulta(), sender);
        }

        private void btnProvincias_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Provincias_Consulta(), sender);
        }

        private void btnCiudades_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Ciudades_Consulta(), sender);
        }

        private void btnSectores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Sistema.Sectores_Consulta(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seguridad.Usuarios_Consulta(), sender);
        }

        private void btnRolesUsuarios_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seguridad.Roles_Consulta(), sender);
        }

        private void btnRolesAccesos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Seguridad.RolesAccesos_Consulta(), sender);
        }

        private void btnMonedas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Finanzas.Monedas_Consulta(), sender);
        }
        int valor = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            valor += 1;
            if (this.Opacity < 1) this.Opacity += 0.05;
            valor += 1;
            if (valor == 100)
            {
                timer1.Stop();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
