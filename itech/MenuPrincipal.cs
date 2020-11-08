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
                    currentButton.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitulo.BackColor = color;
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
                    previousBtn.Font = new System.Drawing.Font("Ubuntu", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            lblTitulo.Text = childForm.Text;
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
            Reset();
        }

        public void Reset()
        {
            DisableButton();
            lblTitulo.Text = "HOME";
            panelTitulo.BackColor = Color.FromArgb(0, 150, 136);
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
            Application.Exit();
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
    }
}
