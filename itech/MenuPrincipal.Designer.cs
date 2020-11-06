namespace iTechERP
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblkIngresos = new System.Windows.Forms.LinkLabel();
            this.lblkVDFacturas = new System.Windows.Forms.LinkLabel();
            this.lblkOrdenesDeVentas = new System.Windows.Forms.LinkLabel();
            this.lblkClientes = new System.Windows.Forms.LinkLabel();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.lblSistema = new System.Windows.Forms.Label();
            this.lblkProductos = new System.Windows.Forms.LinkLabel();
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.lblkRolesUsuarios = new System.Windows.Forms.LinkLabel();
            this.lblkUsuarios = new System.Windows.Forms.LinkLabel();
            this.panelRecursosHumanos = new System.Windows.Forms.Panel();
            this.lblRecursosHumanos = new System.Windows.Forms.Label();
            this.lblkNominas = new System.Windows.Forms.LinkLabel();
            this.lblkEmpleados = new System.Windows.Forms.LinkLabel();
            this.lblkPosiciones = new System.Windows.Forms.LinkLabel();
            this.lblkDepartamentos = new System.Windows.Forms.LinkLabel();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.lblCompras = new System.Windows.Forms.Label();
            this.lblkInventario = new System.Windows.Forms.LinkLabel();
            this.lblkPagos = new System.Windows.Forms.LinkLabel();
            this.lblkProveedores = new System.Windows.Forms.LinkLabel();
            this.lblkDevoluciones = new System.Windows.Forms.LinkLabel();
            this.lblkEntradas = new System.Windows.Forms.LinkLabel();
            this.lblkGPFacturas = new System.Windows.Forms.LinkLabel();
            this.lblkOrdenesCompras = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerFechaHoraActual = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnCerrarFormHijo = new System.Windows.Forms.Button();
            this.btnSistema = new FontAwesome.Sharp.IconButton();
            this.btnSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnRecursosHumanos = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.btnFinanzas = new FontAwesome.Sharp.IconButton();
            this.panelFinanzas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblkCxC = new System.Windows.Forms.LinkLabel();
            this.lblkCxP = new System.Windows.Forms.LinkLabel();
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelSistema.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelRecursosHumanos.SuspendLayout();
            this.panelCompras.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFinanzas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnFinanzas);
            this.panelMenu.Controls.Add(this.btnSistema);
            this.panelMenu.Controls.Add(this.btnSeguridad);
            this.panelMenu.Controls.Add(this.btnRecursosHumanos);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 739);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.panelTitulo.Controls.Add(this.btnRestaurar);
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnCerrar);
            this.panelTitulo.Controls.Add(this.btnCerrarFormHijo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(220, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(957, 80);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Ubuntu", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(435, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.panelFinanzas);
            this.panelDesktop.Controls.Add(this.panelVentas);
            this.panelDesktop.Controls.Add(this.panelSistema);
            this.panelDesktop.Controls.Add(this.panelSeguridad);
            this.panelDesktop.Controls.Add(this.panelRecursosHumanos);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.panelCompras);
            this.panelDesktop.Controls.Add(this.panel1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(957, 659);
            this.panelDesktop.TabIndex = 2;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // panelVentas
            // 
            this.panelVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelVentas.BackColor = System.Drawing.Color.White;
            this.panelVentas.Controls.Add(this.lblVentas);
            this.panelVentas.Controls.Add(this.lblkIngresos);
            this.panelVentas.Controls.Add(this.lblkVDFacturas);
            this.panelVentas.Controls.Add(this.lblkOrdenesDeVentas);
            this.panelVentas.Controls.Add(this.lblkClientes);
            this.panelVentas.Location = new System.Drawing.Point(0, 0);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(10, 659);
            this.panelVentas.TabIndex = 8;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(81, 27);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(59, 20);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Ventas";
            // 
            // lblkIngresos
            // 
            this.lblkIngresos.AutoSize = true;
            this.lblkIngresos.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkIngresos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkIngresos.Location = new System.Drawing.Point(12, 203);
            this.lblkIngresos.Name = "lblkIngresos";
            this.lblkIngresos.Size = new System.Drawing.Size(124, 19);
            this.lblkIngresos.TabIndex = 3;
            this.lblkIngresos.TabStop = true;
            this.lblkIngresos.Text = "VD004 - Ingresos";
            // 
            // lblkVDFacturas
            // 
            this.lblkVDFacturas.AutoSize = true;
            this.lblkVDFacturas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkVDFacturas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkVDFacturas.Location = new System.Drawing.Point(12, 162);
            this.lblkVDFacturas.Name = "lblkVDFacturas";
            this.lblkVDFacturas.Size = new System.Drawing.Size(124, 19);
            this.lblkVDFacturas.TabIndex = 2;
            this.lblkVDFacturas.TabStop = true;
            this.lblkVDFacturas.Text = "VD003 - Facturas";
            // 
            // lblkOrdenesDeVentas
            // 
            this.lblkOrdenesDeVentas.AutoSize = true;
            this.lblkOrdenesDeVentas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkOrdenesDeVentas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkOrdenesDeVentas.Location = new System.Drawing.Point(12, 121);
            this.lblkOrdenesDeVentas.Name = "lblkOrdenesDeVentas";
            this.lblkOrdenesDeVentas.Size = new System.Drawing.Size(197, 19);
            this.lblkOrdenesDeVentas.TabIndex = 1;
            this.lblkOrdenesDeVentas.TabStop = true;
            this.lblkOrdenesDeVentas.Text = "VD002 - Ordenes de Ventas";
            // 
            // lblkClientes
            // 
            this.lblkClientes.AutoSize = true;
            this.lblkClientes.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkClientes.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkClientes.Location = new System.Drawing.Point(12, 80);
            this.lblkClientes.Name = "lblkClientes";
            this.lblkClientes.Size = new System.Drawing.Size(122, 19);
            this.lblkClientes.TabIndex = 0;
            this.lblkClientes.TabStop = true;
            this.lblkClientes.Text = "VD001 - Clientes";
            // 
            // panelSistema
            // 
            this.panelSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSistema.BackColor = System.Drawing.Color.White;
            this.panelSistema.Controls.Add(this.lblSistema);
            this.panelSistema.Controls.Add(this.lblkProductos);
            this.panelSistema.Location = new System.Drawing.Point(0, 0);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(10, 659);
            this.panelSistema.TabIndex = 10;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(70, 27);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(65, 20);
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = "Sistema";
            // 
            // lblkProductos
            // 
            this.lblkProductos.AutoSize = true;
            this.lblkProductos.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkProductos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkProductos.Location = new System.Drawing.Point(12, 80);
            this.lblkProductos.Name = "lblkProductos";
            this.lblkProductos.Size = new System.Drawing.Size(128, 19);
            this.lblkProductos.TabIndex = 0;
            this.lblkProductos.TabStop = true;
            this.lblkProductos.Text = "SI001 - Productos";
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSeguridad.BackColor = System.Drawing.Color.White;
            this.panelSeguridad.Controls.Add(this.lblSeguridad);
            this.panelSeguridad.Controls.Add(this.lblkRolesUsuarios);
            this.panelSeguridad.Controls.Add(this.lblkUsuarios);
            this.panelSeguridad.Location = new System.Drawing.Point(0, 0);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Size = new System.Drawing.Size(10, 659);
            this.panelSeguridad.TabIndex = 9;
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguridad.ForeColor = System.Drawing.Color.White;
            this.lblSeguridad.Location = new System.Drawing.Point(70, 27);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(81, 20);
            this.lblSeguridad.TabIndex = 4;
            this.lblSeguridad.Text = "Seguridad";
            // 
            // lblkRolesUsuarios
            // 
            this.lblkRolesUsuarios.AutoSize = true;
            this.lblkRolesUsuarios.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkRolesUsuarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkRolesUsuarios.Location = new System.Drawing.Point(12, 123);
            this.lblkRolesUsuarios.Name = "lblkRolesUsuarios";
            this.lblkRolesUsuarios.Size = new System.Drawing.Size(182, 19);
            this.lblkRolesUsuarios.TabIndex = 1;
            this.lblkRolesUsuarios.TabStop = true;
            this.lblkRolesUsuarios.Text = "SE002 - Roles de Usuarios";
            // 
            // lblkUsuarios
            // 
            this.lblkUsuarios.AutoSize = true;
            this.lblkUsuarios.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkUsuarios.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkUsuarios.Location = new System.Drawing.Point(12, 80);
            this.lblkUsuarios.Name = "lblkUsuarios";
            this.lblkUsuarios.Size = new System.Drawing.Size(121, 19);
            this.lblkUsuarios.TabIndex = 0;
            this.lblkUsuarios.TabStop = true;
            this.lblkUsuarios.Text = "SE001 - Usuarios";
            // 
            // panelRecursosHumanos
            // 
            this.panelRecursosHumanos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRecursosHumanos.BackColor = System.Drawing.Color.White;
            this.panelRecursosHumanos.Controls.Add(this.lblRecursosHumanos);
            this.panelRecursosHumanos.Controls.Add(this.lblkNominas);
            this.panelRecursosHumanos.Controls.Add(this.lblkEmpleados);
            this.panelRecursosHumanos.Controls.Add(this.lblkPosiciones);
            this.panelRecursosHumanos.Controls.Add(this.lblkDepartamentos);
            this.panelRecursosHumanos.Location = new System.Drawing.Point(0, 0);
            this.panelRecursosHumanos.Name = "panelRecursosHumanos";
            this.panelRecursosHumanos.Size = new System.Drawing.Size(10, 659);
            this.panelRecursosHumanos.TabIndex = 6;
            // 
            // lblRecursosHumanos
            // 
            this.lblRecursosHumanos.AutoSize = true;
            this.lblRecursosHumanos.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursosHumanos.ForeColor = System.Drawing.Color.White;
            this.lblRecursosHumanos.Location = new System.Drawing.Point(39, 25);
            this.lblRecursosHumanos.Name = "lblRecursosHumanos";
            this.lblRecursosHumanos.Size = new System.Drawing.Size(143, 20);
            this.lblRecursosHumanos.TabIndex = 5;
            this.lblRecursosHumanos.Text = "Recursos Humanos";
            // 
            // lblkNominas
            // 
            this.lblkNominas.AutoSize = true;
            this.lblkNominas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkNominas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkNominas.Location = new System.Drawing.Point(12, 209);
            this.lblkNominas.Name = "lblkNominas";
            this.lblkNominas.Size = new System.Drawing.Size(124, 19);
            this.lblkNominas.TabIndex = 3;
            this.lblkNominas.TabStop = true;
            this.lblkNominas.Text = "RH004 - Nóminas";
            // 
            // lblkEmpleados
            // 
            this.lblkEmpleados.AutoSize = true;
            this.lblkEmpleados.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkEmpleados.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkEmpleados.Location = new System.Drawing.Point(12, 166);
            this.lblkEmpleados.Name = "lblkEmpleados";
            this.lblkEmpleados.Size = new System.Drawing.Size(141, 19);
            this.lblkEmpleados.TabIndex = 2;
            this.lblkEmpleados.TabStop = true;
            this.lblkEmpleados.Text = "RH003 - Empleados";
            // 
            // lblkPosiciones
            // 
            this.lblkPosiciones.AutoSize = true;
            this.lblkPosiciones.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkPosiciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkPosiciones.Location = new System.Drawing.Point(12, 123);
            this.lblkPosiciones.Name = "lblkPosiciones";
            this.lblkPosiciones.Size = new System.Drawing.Size(137, 19);
            this.lblkPosiciones.TabIndex = 1;
            this.lblkPosiciones.TabStop = true;
            this.lblkPosiciones.Text = "RH002 - Posiciones";
            // 
            // lblkDepartamentos
            // 
            this.lblkDepartamentos.AutoSize = true;
            this.lblkDepartamentos.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkDepartamentos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkDepartamentos.Location = new System.Drawing.Point(12, 80);
            this.lblkDepartamentos.Name = "lblkDepartamentos";
            this.lblkDepartamentos.Size = new System.Drawing.Size(174, 19);
            this.lblkDepartamentos.TabIndex = 0;
            this.lblkDepartamentos.TabStop = true;
            this.lblkDepartamentos.Text = "RH001 - Departamentos";
            // 
            // panelCompras
            // 
            this.panelCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCompras.BackColor = System.Drawing.Color.White;
            this.panelCompras.Controls.Add(this.lblCompras);
            this.panelCompras.Controls.Add(this.lblkInventario);
            this.panelCompras.Controls.Add(this.lblkPagos);
            this.panelCompras.Controls.Add(this.lblkProveedores);
            this.panelCompras.Controls.Add(this.lblkDevoluciones);
            this.panelCompras.Controls.Add(this.lblkEntradas);
            this.panelCompras.Controls.Add(this.lblkGPFacturas);
            this.panelCompras.Controls.Add(this.lblkOrdenesCompras);
            this.panelCompras.Location = new System.Drawing.Point(0, 0);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(10, 659);
            this.panelCompras.TabIndex = 7;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(75, 27);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(70, 20);
            this.lblCompras.TabIndex = 7;
            this.lblCompras.Text = "Compras";
            // 
            // lblkInventario
            // 
            this.lblkInventario.AutoSize = true;
            this.lblkInventario.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkInventario.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkInventario.Location = new System.Drawing.Point(9, 311);
            this.lblkInventario.Name = "lblkInventario";
            this.lblkInventario.Size = new System.Drawing.Size(133, 19);
            this.lblkInventario.TabIndex = 6;
            this.lblkInventario.TabStop = true;
            this.lblkInventario.Text = "GP007 - Inventario";
            // 
            // lblkPagos
            // 
            this.lblkPagos.AutoSize = true;
            this.lblkPagos.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkPagos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkPagos.Location = new System.Drawing.Point(9, 274);
            this.lblkPagos.Name = "lblkPagos";
            this.lblkPagos.Size = new System.Drawing.Size(106, 19);
            this.lblkPagos.TabIndex = 5;
            this.lblkPagos.TabStop = true;
            this.lblkPagos.Text = "GP006 - Pagos";
            // 
            // lblkProveedores
            // 
            this.lblkProveedores.AutoSize = true;
            this.lblkProveedores.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkProveedores.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkProveedores.Location = new System.Drawing.Point(9, 237);
            this.lblkProveedores.Name = "lblkProveedores";
            this.lblkProveedores.Size = new System.Drawing.Size(153, 19);
            this.lblkProveedores.TabIndex = 4;
            this.lblkProveedores.TabStop = true;
            this.lblkProveedores.Text = "GP005 - Proveedores";
            // 
            // lblkDevoluciones
            // 
            this.lblkDevoluciones.AutoSize = true;
            this.lblkDevoluciones.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkDevoluciones.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkDevoluciones.Location = new System.Drawing.Point(9, 200);
            this.lblkDevoluciones.Name = "lblkDevoluciones";
            this.lblkDevoluciones.Size = new System.Drawing.Size(158, 19);
            this.lblkDevoluciones.TabIndex = 3;
            this.lblkDevoluciones.TabStop = true;
            this.lblkDevoluciones.Text = "GP004 - Devoluciones";
            // 
            // lblkEntradas
            // 
            this.lblkEntradas.AutoSize = true;
            this.lblkEntradas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkEntradas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkEntradas.Location = new System.Drawing.Point(9, 163);
            this.lblkEntradas.Name = "lblkEntradas";
            this.lblkEntradas.Size = new System.Drawing.Size(194, 19);
            this.lblkEntradas.TabIndex = 2;
            this.lblkEntradas.TabStop = true;
            this.lblkEntradas.Text = "GP003 - Entrada Mercancía";
            // 
            // lblkGPFacturas
            // 
            this.lblkGPFacturas.AutoSize = true;
            this.lblkGPFacturas.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkGPFacturas.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkGPFacturas.Location = new System.Drawing.Point(9, 126);
            this.lblkGPFacturas.Name = "lblkGPFacturas";
            this.lblkGPFacturas.Size = new System.Drawing.Size(123, 19);
            this.lblkGPFacturas.TabIndex = 1;
            this.lblkGPFacturas.TabStop = true;
            this.lblkGPFacturas.Text = "GP002 - Facturas";
            // 
            // lblkOrdenesCompras
            // 
            this.lblkOrdenesCompras.AutoSize = true;
            this.lblkOrdenesCompras.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkOrdenesCompras.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkOrdenesCompras.Location = new System.Drawing.Point(9, 89);
            this.lblkOrdenesCompras.Name = "lblkOrdenesCompras";
            this.lblkOrdenesCompras.Size = new System.Drawing.Size(211, 19);
            this.lblkOrdenesCompras.TabIndex = 0;
            this.lblkOrdenesCompras.TabStop = true;
            this.lblkOrdenesCompras.Text = "GP001 - Ordenes de Compras";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 628);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 31);
            this.panel1.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.lblFecha.Location = new System.Drawing.Point(821, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(68, 25);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(889, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(68, 25);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label2";
            // 
            // timerFechaHoraActual
            // 
            this.timerFechaHoraActual.Enabled = true;
            this.timerFechaHoraActual.Tick += new System.EventHandler(this.timerFechaHoraActual_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 262);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRestaurar.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnRestaurar.IconColor = System.Drawing.Color.Black;
            this.btnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRestaurar.IconSize = 32;
            this.btnRestaurar.Location = new System.Drawing.Point(895, 17);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Rotation = 0D;
            this.btnRestaurar.Size = new System.Drawing.Size(30, 30);
            this.btnRestaurar.TabIndex = 5;
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 32;
            this.btnMinimizar.Location = new System.Drawing.Point(865, 17);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizar.TabIndex = 4;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 32;
            this.btnCerrar.Location = new System.Drawing.Point(924, 17);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(30, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnCerrarFormHijo
            // 
            this.btnCerrarFormHijo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrarFormHijo.BackgroundImage")));
            this.btnCerrarFormHijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarFormHijo.FlatAppearance.BorderSize = 0;
            this.btnCerrarFormHijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarFormHijo.Location = new System.Drawing.Point(16, 26);
            this.btnCerrarFormHijo.Name = "btnCerrarFormHijo";
            this.btnCerrarFormHijo.Size = new System.Drawing.Size(33, 29);
            this.btnCerrarFormHijo.TabIndex = 0;
            this.btnCerrarFormHijo.UseVisualStyleBackColor = true;
            this.btnCerrarFormHijo.Click += new System.EventHandler(this.btnCerrarFormHijo_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSistema.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSistema.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSistema.IconColor = System.Drawing.Color.White;
            this.btnSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSistema.IconSize = 32;
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(0, 320);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSistema.Rotation = 0D;
            this.btnSistema.Size = new System.Drawing.Size(220, 60);
            this.btnSistema.TabIndex = 6;
            this.btnSistema.Text = "   Sistema";
            this.btnSistema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FlatAppearance.BorderSize = 0;
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSeguridad.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeguridad.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.btnSeguridad.IconColor = System.Drawing.Color.White;
            this.btnSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeguridad.IconSize = 32;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 260);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSeguridad.Rotation = 0D;
            this.btnSeguridad.Size = new System.Drawing.Size(220, 60);
            this.btnSeguridad.TabIndex = 5;
            this.btnSeguridad.Text = "   Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnRecursosHumanos
            // 
            this.btnRecursosHumanos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecursosHumanos.FlatAppearance.BorderSize = 0;
            this.btnRecursosHumanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursosHumanos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRecursosHumanos.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursosHumanos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecursosHumanos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRecursosHumanos.IconColor = System.Drawing.Color.White;
            this.btnRecursosHumanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecursosHumanos.IconSize = 32;
            this.btnRecursosHumanos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursosHumanos.Location = new System.Drawing.Point(0, 200);
            this.btnRecursosHumanos.Name = "btnRecursosHumanos";
            this.btnRecursosHumanos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRecursosHumanos.Rotation = 0D;
            this.btnRecursosHumanos.Size = new System.Drawing.Size(220, 60);
            this.btnRecursosHumanos.TabIndex = 3;
            this.btnRecursosHumanos.Text = "   Recursos Humanos";
            this.btnRecursosHumanos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursosHumanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecursosHumanos.UseVisualStyleBackColor = true;
            this.btnRecursosHumanos.Click += new System.EventHandler(this.btnRecursosHumanos_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnVentas.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 140);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(220, 60);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "   Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCompras.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 32;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 80);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCompras.Rotation = 0D;
            this.btnCompras.Size = new System.Drawing.Size(220, 60);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "   Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzas.FlatAppearance.BorderSize = 0;
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFinanzas.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinanzas.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnFinanzas.IconColor = System.Drawing.Color.White;
            this.btnFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinanzas.IconSize = 32;
            this.btnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.Location = new System.Drawing.Point(0, 380);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnFinanzas.Rotation = 0D;
            this.btnFinanzas.Size = new System.Drawing.Size(220, 60);
            this.btnFinanzas.TabIndex = 4;
            this.btnFinanzas.Text = "   Finanzas";
            this.btnFinanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // panelFinanzas
            // 
            this.panelFinanzas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFinanzas.BackColor = System.Drawing.Color.White;
            this.panelFinanzas.Controls.Add(this.label1);
            this.panelFinanzas.Controls.Add(this.lblkCxC);
            this.panelFinanzas.Controls.Add(this.lblkCxP);
            this.panelFinanzas.Location = new System.Drawing.Point(0, 0);
            this.panelFinanzas.Name = "panelFinanzas";
            this.panelFinanzas.Size = new System.Drawing.Size(220, 659);
            this.panelFinanzas.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finanzas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblkCxC
            // 
            this.lblkCxC.AutoSize = true;
            this.lblkCxC.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkCxC.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkCxC.Location = new System.Drawing.Point(12, 123);
            this.lblkCxC.Name = "lblkCxC";
            this.lblkCxC.Size = new System.Drawing.Size(84, 19);
            this.lblkCxC.TabIndex = 1;
            this.lblkCxC.TabStop = true;
            this.lblkCxC.Text = "FI002 - CxC";
            this.lblkCxC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkCxC_LinkClicked);
            // 
            // lblkCxP
            // 
            this.lblkCxP.AutoSize = true;
            this.lblkCxP.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkCxP.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.lblkCxP.Location = new System.Drawing.Point(12, 80);
            this.lblkCxP.Name = "lblkCxP";
            this.lblkCxP.Size = new System.Drawing.Size(83, 19);
            this.lblkCxP.TabIndex = 0;
            this.lblkCxP.TabStop = true;
            this.lblkCxP.Text = "FI001 - CxP";
            this.lblkCxP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkCxP_LinkClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 739);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            this.panelSistema.ResumeLayout(false);
            this.panelSistema.PerformLayout();
            this.panelSeguridad.ResumeLayout(false);
            this.panelSeguridad.PerformLayout();
            this.panelRecursosHumanos.ResumeLayout(false);
            this.panelRecursosHumanos.PerformLayout();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFinanzas.ResumeLayout(false);
            this.panelFinanzas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCerrarFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnCompras;
        private FontAwesome.Sharp.IconButton btnSistema;
        private FontAwesome.Sharp.IconButton btnSeguridad;
        private FontAwesome.Sharp.IconButton btnRecursosHumanos;
        private FontAwesome.Sharp.IconButton btnVentas;
        private FontAwesome.Sharp.IconButton btnRestaurar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panelRecursosHumanos;
        private System.Windows.Forms.LinkLabel lblkDepartamentos;
        private System.Windows.Forms.LinkLabel lblkNominas;
        private System.Windows.Forms.LinkLabel lblkEmpleados;
        private System.Windows.Forms.LinkLabel lblkPosiciones;
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.LinkLabel lblkDevoluciones;
        private System.Windows.Forms.LinkLabel lblkEntradas;
        private System.Windows.Forms.LinkLabel lblkGPFacturas;
        private System.Windows.Forms.LinkLabel lblkOrdenesCompras;
        private System.Windows.Forms.LinkLabel lblkInventario;
        private System.Windows.Forms.LinkLabel lblkPagos;
        private System.Windows.Forms.LinkLabel lblkProveedores;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.LinkLabel lblkIngresos;
        private System.Windows.Forms.LinkLabel lblkVDFacturas;
        private System.Windows.Forms.LinkLabel lblkOrdenesDeVentas;
        private System.Windows.Forms.LinkLabel lblkClientes;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.LinkLabel lblkProductos;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.LinkLabel lblkRolesUsuarios;
        private System.Windows.Forms.LinkLabel lblkUsuarios;
        private System.Windows.Forms.Label lblRecursosHumanos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerFechaHoraActual;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnFinanzas;
        private System.Windows.Forms.Panel panelFinanzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblkCxC;
        private System.Windows.Forms.LinkLabel lblkCxP;
    }
}