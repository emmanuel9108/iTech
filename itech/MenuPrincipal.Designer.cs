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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnSistema = new FontAwesome.Sharp.IconButton();
            this.btnSeguridad = new FontAwesome.Sharp.IconButton();
            this.btnFinanzas = new FontAwesome.Sharp.IconButton();
            this.btnRecursosHumanos = new FontAwesome.Sharp.IconButton();
            this.btnVentas = new FontAwesome.Sharp.IconButton();
            this.btnCompras = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new FontAwesome.Sharp.IconButton();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnCerrarFormHijo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelRecursosHumanos = new System.Windows.Forms.Panel();
            this.btnDepartamentos = new System.Windows.Forms.Button();
            this.btnPosiciones = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnNominas = new System.Windows.Forms.Button();
            this.lblRecursosHumanos = new System.Windows.Forms.Label();
            this.panelFinanzas = new System.Windows.Forms.Panel();
            this.btnCxC = new System.Windows.Forms.Button();
            this.btnCxP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSistema = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.lblSistema = new System.Windows.Forms.Label();
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnRolesUsuarios = new System.Windows.Forms.Button();
            this.lblSeguridad = new System.Windows.Forms.Label();
            this.panelVentas = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnOrdenesVenta = new System.Windows.Forms.Button();
            this.btnFacturasVenta = new System.Windows.Forms.Button();
            this.btnIngresos = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.panelCompras = new System.Windows.Forms.Panel();
            this.btnOrdenesCompras = new System.Windows.Forms.Button();
            this.btnFacturasCompra = new System.Windows.Forms.Button();
            this.btnEntradaMercancia = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.lblCompras = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerFechaHoraActual = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelRecursosHumanos.SuspendLayout();
            this.panelFinanzas.SuspendLayout();
            this.panelSistema.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelVentas.SuspendLayout();
            this.panelCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnSistema);
            this.panelMenu.Controls.Add(this.btnSeguridad);
            this.panelMenu.Controls.Add(this.btnFinanzas);
            this.panelMenu.Controls.Add(this.btnRecursosHumanos);
            this.panelMenu.Controls.Add(this.btnVentas);
            this.panelMenu.Controls.Add(this.btnCompras);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 572);
            this.panelMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Prueba Impresion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnLogOut.IconColor = System.Drawing.Color.White;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 523);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnLogOut.Rotation = 0D;
            this.btnLogOut.Size = new System.Drawing.Size(206, 49);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "   Cerrar Sección";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSistema.FlatAppearance.BorderSize = 0;
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSistema.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnSistema.IconColor = System.Drawing.Color.White;
            this.btnSistema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSistema.IconSize = 32;
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(0, 326);
            this.btnSistema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSistema.Rotation = 0D;
            this.btnSistema.Size = new System.Drawing.Size(206, 49);
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
            this.btnSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeguridad.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.btnSeguridad.IconColor = System.Drawing.Color.White;
            this.btnSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeguridad.IconSize = 32;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 277);
            this.btnSeguridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSeguridad.Rotation = 0D;
            this.btnSeguridad.Size = new System.Drawing.Size(206, 49);
            this.btnSeguridad.TabIndex = 5;
            this.btnSeguridad.Text = "   Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFinanzas.FlatAppearance.BorderSize = 0;
            this.btnFinanzas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanzas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFinanzas.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.btnFinanzas.IconColor = System.Drawing.Color.White;
            this.btnFinanzas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinanzas.IconSize = 32;
            this.btnFinanzas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.Location = new System.Drawing.Point(0, 228);
            this.btnFinanzas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnFinanzas.Rotation = 0D;
            this.btnFinanzas.Size = new System.Drawing.Size(206, 49);
            this.btnFinanzas.TabIndex = 4;
            this.btnFinanzas.Text = "   Finanzas";
            this.btnFinanzas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinanzas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnRecursosHumanos
            // 
            this.btnRecursosHumanos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecursosHumanos.FlatAppearance.BorderSize = 0;
            this.btnRecursosHumanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursosHumanos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRecursosHumanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecursosHumanos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRecursosHumanos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnRecursosHumanos.IconColor = System.Drawing.Color.White;
            this.btnRecursosHumanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecursosHumanos.IconSize = 32;
            this.btnRecursosHumanos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecursosHumanos.Location = new System.Drawing.Point(0, 179);
            this.btnRecursosHumanos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecursosHumanos.Name = "btnRecursosHumanos";
            this.btnRecursosHumanos.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnRecursosHumanos.Rotation = 0D;
            this.btnRecursosHumanos.Size = new System.Drawing.Size(206, 49);
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
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnVentas.IconColor = System.Drawing.Color.White;
            this.btnVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentas.IconSize = 32;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 130);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnVentas.Rotation = 0D;
            this.btnVentas.Size = new System.Drawing.Size(206, 49);
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
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.btnCompras.IconColor = System.Drawing.Color.White;
            this.btnCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompras.IconSize = 32;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 81);
            this.btnCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCompras.Rotation = 0D;
            this.btnCompras.Size = new System.Drawing.Size(206, 49);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "   Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(206, 81);
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
            this.panelTitulo.Location = new System.Drawing.Point(206, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(764, 81);
            this.panelTitulo.TabIndex = 1;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
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
            this.btnRestaurar.Location = new System.Drawing.Point(700, 11);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Rotation = 0D;
            this.btnRestaurar.Size = new System.Drawing.Size(22, 24);
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
            this.btnMinimizar.Location = new System.Drawing.Point(666, 11);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(22, 24);
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
            this.btnCerrar.Location = new System.Drawing.Point(734, 11);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(22, 24);
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
            this.btnCerrarFormHijo.Location = new System.Drawing.Point(12, 21);
            this.btnCerrarFormHijo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrarFormHijo.Name = "btnCerrarFormHijo";
            this.btnCerrarFormHijo.Size = new System.Drawing.Size(25, 24);
            this.btnCerrarFormHijo.TabIndex = 0;
            this.btnCerrarFormHijo.UseVisualStyleBackColor = true;
            this.btnCerrarFormHijo.Click += new System.EventHandler(this.btnCerrarFormHijo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(325, 28);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(72, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.panelRecursosHumanos);
            this.panelDesktop.Controls.Add(this.panelFinanzas);
            this.panelDesktop.Controls.Add(this.panelSistema);
            this.panelDesktop.Controls.Add(this.panelSeguridad);
            this.panelDesktop.Controls.Add(this.panelVentas);
            this.panelDesktop.Controls.Add(this.panelCompras);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.panelFecha);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(206, 81);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(764, 491);
            this.panelDesktop.TabIndex = 2;
            // 
            // panelRecursosHumanos
            // 
            this.panelRecursosHumanos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRecursosHumanos.BackColor = System.Drawing.Color.White;
            this.panelRecursosHumanos.Controls.Add(this.btnDepartamentos);
            this.panelRecursosHumanos.Controls.Add(this.btnPosiciones);
            this.panelRecursosHumanos.Controls.Add(this.btnEmpleados);
            this.panelRecursosHumanos.Controls.Add(this.btnNominas);
            this.panelRecursosHumanos.Controls.Add(this.lblRecursosHumanos);
            this.panelRecursosHumanos.Location = new System.Drawing.Point(0, 0);
            this.panelRecursosHumanos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelRecursosHumanos.Name = "panelRecursosHumanos";
            this.panelRecursosHumanos.Size = new System.Drawing.Size(10, 853);
            this.panelRecursosHumanos.TabIndex = 6;
            // 
            // btnDepartamentos
            // 
            this.btnDepartamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnDepartamentos.FlatAppearance.BorderSize = 0;
            this.btnDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartamentos.ForeColor = System.Drawing.Color.Black;
            this.btnDepartamentos.Location = new System.Drawing.Point(39, 73);
            this.btnDepartamentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDepartamentos.Name = "btnDepartamentos";
            this.btnDepartamentos.Size = new System.Drawing.Size(143, 29);
            this.btnDepartamentos.TabIndex = 22;
            this.btnDepartamentos.Text = "RH001 - Departamentos";
            this.btnDepartamentos.UseVisualStyleBackColor = false;
            // 
            // btnPosiciones
            // 
            this.btnPosiciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnPosiciones.FlatAppearance.BorderSize = 0;
            this.btnPosiciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosiciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosiciones.ForeColor = System.Drawing.Color.Black;
            this.btnPosiciones.Location = new System.Drawing.Point(39, 115);
            this.btnPosiciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPosiciones.Name = "btnPosiciones";
            this.btnPosiciones.Size = new System.Drawing.Size(143, 29);
            this.btnPosiciones.TabIndex = 21;
            this.btnPosiciones.Text = "RH002 - Posiciones";
            this.btnPosiciones.UseVisualStyleBackColor = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnEmpleados.FlatAppearance.BorderSize = 0;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Black;
            this.btnEmpleados.Location = new System.Drawing.Point(39, 158);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(143, 29);
            this.btnEmpleados.TabIndex = 20;
            this.btnEmpleados.Text = "RH003 - Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // btnNominas
            // 
            this.btnNominas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnNominas.FlatAppearance.BorderSize = 0;
            this.btnNominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNominas.ForeColor = System.Drawing.Color.Black;
            this.btnNominas.Location = new System.Drawing.Point(39, 200);
            this.btnNominas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNominas.Name = "btnNominas";
            this.btnNominas.Size = new System.Drawing.Size(143, 29);
            this.btnNominas.TabIndex = 19;
            this.btnNominas.Text = "RH004 - Nomina";
            this.btnNominas.UseVisualStyleBackColor = false;
            // 
            // lblRecursosHumanos
            // 
            this.lblRecursosHumanos.AutoSize = true;
            this.lblRecursosHumanos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecursosHumanos.ForeColor = System.Drawing.Color.White;
            this.lblRecursosHumanos.Location = new System.Drawing.Point(52, 20);
            this.lblRecursosHumanos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecursosHumanos.Name = "lblRecursosHumanos";
            this.lblRecursosHumanos.Size = new System.Drawing.Size(132, 15);
            this.lblRecursosHumanos.TabIndex = 5;
            this.lblRecursosHumanos.Text = "Recursos Humanos";
            // 
            // panelFinanzas
            // 
            this.panelFinanzas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFinanzas.BackColor = System.Drawing.Color.White;
            this.panelFinanzas.Controls.Add(this.btnCxC);
            this.panelFinanzas.Controls.Add(this.btnCxP);
            this.panelFinanzas.Controls.Add(this.label1);
            this.panelFinanzas.Location = new System.Drawing.Point(0, 0);
            this.panelFinanzas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFinanzas.Name = "panelFinanzas";
            this.panelFinanzas.Size = new System.Drawing.Size(10, 853);
            this.panelFinanzas.TabIndex = 11;
            // 
            // btnCxC
            // 
            this.btnCxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnCxC.FlatAppearance.BorderSize = 0;
            this.btnCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxC.ForeColor = System.Drawing.Color.Black;
            this.btnCxC.Location = new System.Drawing.Point(39, 115);
            this.btnCxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCxC.Name = "btnCxC";
            this.btnCxC.Size = new System.Drawing.Size(143, 29);
            this.btnCxC.TabIndex = 7;
            this.btnCxC.Text = "FI002 - CxC";
            this.btnCxC.UseVisualStyleBackColor = false;
            this.btnCxC.Click += new System.EventHandler(this.btnCxC_Click);
            // 
            // btnCxP
            // 
            this.btnCxP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnCxP.FlatAppearance.BorderSize = 0;
            this.btnCxP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCxP.ForeColor = System.Drawing.Color.Black;
            this.btnCxP.Location = new System.Drawing.Point(39, 67);
            this.btnCxP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCxP.Name = "btnCxP";
            this.btnCxP.Size = new System.Drawing.Size(143, 29);
            this.btnCxP.TabIndex = 6;
            this.btnCxP.Text = "FI001 - CxP";
            this.btnCxP.UseVisualStyleBackColor = false;
            this.btnCxP.Click += new System.EventHandler(this.btnCxP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Finanzas";
            // 
            // panelSistema
            // 
            this.panelSistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSistema.BackColor = System.Drawing.Color.White;
            this.panelSistema.Controls.Add(this.btnProductos);
            this.panelSistema.Controls.Add(this.lblSistema);
            this.panelSistema.Location = new System.Drawing.Point(0, 0);
            this.panelSistema.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSistema.Name = "panelSistema";
            this.panelSistema.Size = new System.Drawing.Size(10, 853);
            this.panelSistema.TabIndex = 10;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.Black;
            this.btnProductos.Location = new System.Drawing.Point(39, 81);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(143, 29);
            this.btnProductos.TabIndex = 22;
            this.btnProductos.Text = "SI001 - Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            // 
            // lblSistema
            // 
            this.lblSistema.AutoSize = true;
            this.lblSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistema.ForeColor = System.Drawing.Color.White;
            this.lblSistema.Location = new System.Drawing.Point(83, 22);
            this.lblSistema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Size = new System.Drawing.Size(59, 15);
            this.lblSistema.TabIndex = 4;
            this.lblSistema.Text = "Sistema";
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSeguridad.BackColor = System.Drawing.Color.White;
            this.panelSeguridad.Controls.Add(this.btnUsuarios);
            this.panelSeguridad.Controls.Add(this.btnRolesUsuarios);
            this.panelSeguridad.Controls.Add(this.lblSeguridad);
            this.panelSeguridad.Location = new System.Drawing.Point(0, 0);
            this.panelSeguridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Size = new System.Drawing.Size(10, 853);
            this.panelSeguridad.TabIndex = 9;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnUsuarios.Location = new System.Drawing.Point(39, 66);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(143, 29);
            this.btnUsuarios.TabIndex = 22;
            this.btnUsuarios.Text = "SE001 - Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            // 
            // btnRolesUsuarios
            // 
            this.btnRolesUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnRolesUsuarios.FlatAppearance.BorderSize = 0;
            this.btnRolesUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRolesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolesUsuarios.ForeColor = System.Drawing.Color.Black;
            this.btnRolesUsuarios.Location = new System.Drawing.Point(39, 108);
            this.btnRolesUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRolesUsuarios.Name = "btnRolesUsuarios";
            this.btnRolesUsuarios.Size = new System.Drawing.Size(143, 29);
            this.btnRolesUsuarios.TabIndex = 21;
            this.btnRolesUsuarios.Text = "SE002 - Roles Usuarios";
            this.btnRolesUsuarios.UseVisualStyleBackColor = false;
            // 
            // lblSeguridad
            // 
            this.lblSeguridad.AutoSize = true;
            this.lblSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguridad.ForeColor = System.Drawing.Color.White;
            this.lblSeguridad.Location = new System.Drawing.Point(80, 22);
            this.lblSeguridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeguridad.Name = "lblSeguridad";
            this.lblSeguridad.Size = new System.Drawing.Size(73, 15);
            this.lblSeguridad.TabIndex = 4;
            this.lblSeguridad.Text = "Seguridad";
            // 
            // panelVentas
            // 
            this.panelVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelVentas.BackColor = System.Drawing.Color.White;
            this.panelVentas.Controls.Add(this.btnClientes);
            this.panelVentas.Controls.Add(this.btnOrdenesVenta);
            this.panelVentas.Controls.Add(this.btnFacturasVenta);
            this.panelVentas.Controls.Add(this.btnIngresos);
            this.panelVentas.Controls.Add(this.lblVentas);
            this.panelVentas.Location = new System.Drawing.Point(0, 0);
            this.panelVentas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelVentas.Name = "panelVentas";
            this.panelVentas.Size = new System.Drawing.Size(10, 853);
            this.panelVentas.TabIndex = 8;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Black;
            this.btnClientes.Location = new System.Drawing.Point(39, 65);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(143, 29);
            this.btnClientes.TabIndex = 18;
            this.btnClientes.Text = "VD001 - Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            // 
            // btnOrdenesVenta
            // 
            this.btnOrdenesVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnOrdenesVenta.FlatAppearance.BorderSize = 0;
            this.btnOrdenesVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenesVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesVenta.ForeColor = System.Drawing.Color.Black;
            this.btnOrdenesVenta.Location = new System.Drawing.Point(39, 107);
            this.btnOrdenesVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenesVenta.Name = "btnOrdenesVenta";
            this.btnOrdenesVenta.Size = new System.Drawing.Size(143, 29);
            this.btnOrdenesVenta.TabIndex = 17;
            this.btnOrdenesVenta.Text = "VD002 - Ordenes Venta";
            this.btnOrdenesVenta.UseVisualStyleBackColor = false;
            // 
            // btnFacturasVenta
            // 
            this.btnFacturasVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnFacturasVenta.FlatAppearance.BorderSize = 0;
            this.btnFacturasVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturasVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturasVenta.ForeColor = System.Drawing.Color.Black;
            this.btnFacturasVenta.Location = new System.Drawing.Point(39, 150);
            this.btnFacturasVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturasVenta.Name = "btnFacturasVenta";
            this.btnFacturasVenta.Size = new System.Drawing.Size(143, 29);
            this.btnFacturasVenta.TabIndex = 16;
            this.btnFacturasVenta.Text = "VD003 - Factura Venta";
            this.btnFacturasVenta.UseVisualStyleBackColor = false;
            // 
            // btnIngresos
            // 
            this.btnIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnIngresos.FlatAppearance.BorderSize = 0;
            this.btnIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresos.ForeColor = System.Drawing.Color.Black;
            this.btnIngresos.Location = new System.Drawing.Point(39, 192);
            this.btnIngresos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresos.Name = "btnIngresos";
            this.btnIngresos.Size = new System.Drawing.Size(143, 29);
            this.btnIngresos.TabIndex = 15;
            this.btnIngresos.Text = "VD004 - Ingresos";
            this.btnIngresos.UseVisualStyleBackColor = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.White;
            this.lblVentas.Location = new System.Drawing.Point(89, 22);
            this.lblVentas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(50, 15);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Ventas";
            // 
            // panelCompras
            // 
            this.panelCompras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelCompras.BackColor = System.Drawing.Color.White;
            this.panelCompras.Controls.Add(this.btnOrdenesCompras);
            this.panelCompras.Controls.Add(this.btnFacturasCompra);
            this.panelCompras.Controls.Add(this.btnEntradaMercancia);
            this.panelCompras.Controls.Add(this.btnDevoluciones);
            this.panelCompras.Controls.Add(this.btnProveedores);
            this.panelCompras.Controls.Add(this.btnPagos);
            this.panelCompras.Controls.Add(this.btnInventario);
            this.panelCompras.Controls.Add(this.lblCompras);
            this.panelCompras.Location = new System.Drawing.Point(0, 0);
            this.panelCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCompras.Name = "panelCompras";
            this.panelCompras.Size = new System.Drawing.Size(10, 853);
            this.panelCompras.TabIndex = 7;
            // 
            // btnOrdenesCompras
            // 
            this.btnOrdenesCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnOrdenesCompras.FlatAppearance.BorderSize = 0;
            this.btnOrdenesCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenesCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenesCompras.ForeColor = System.Drawing.Color.Black;
            this.btnOrdenesCompras.Location = new System.Drawing.Point(39, 58);
            this.btnOrdenesCompras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrdenesCompras.Name = "btnOrdenesCompras";
            this.btnOrdenesCompras.Size = new System.Drawing.Size(143, 29);
            this.btnOrdenesCompras.TabIndex = 14;
            this.btnOrdenesCompras.Text = "GP001 - Ordenes Compra";
            this.btnOrdenesCompras.UseVisualStyleBackColor = false;
            // 
            // btnFacturasCompra
            // 
            this.btnFacturasCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnFacturasCompra.FlatAppearance.BorderSize = 0;
            this.btnFacturasCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturasCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturasCompra.ForeColor = System.Drawing.Color.Black;
            this.btnFacturasCompra.Location = new System.Drawing.Point(39, 98);
            this.btnFacturasCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturasCompra.Name = "btnFacturasCompra";
            this.btnFacturasCompra.Size = new System.Drawing.Size(143, 29);
            this.btnFacturasCompra.TabIndex = 13;
            this.btnFacturasCompra.Text = "GP002 - Facturas";
            this.btnFacturasCompra.UseVisualStyleBackColor = false;
            // 
            // btnEntradaMercancia
            // 
            this.btnEntradaMercancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnEntradaMercancia.FlatAppearance.BorderSize = 0;
            this.btnEntradaMercancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntradaMercancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntradaMercancia.ForeColor = System.Drawing.Color.Black;
            this.btnEntradaMercancia.Location = new System.Drawing.Point(39, 138);
            this.btnEntradaMercancia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntradaMercancia.Name = "btnEntradaMercancia";
            this.btnEntradaMercancia.Size = new System.Drawing.Size(143, 29);
            this.btnEntradaMercancia.TabIndex = 12;
            this.btnEntradaMercancia.Text = "GP003 - Entrada Merc.";
            this.btnEntradaMercancia.UseVisualStyleBackColor = false;
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnDevoluciones.FlatAppearance.BorderSize = 0;
            this.btnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevoluciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.ForeColor = System.Drawing.Color.Black;
            this.btnDevoluciones.Location = new System.Drawing.Point(39, 178);
            this.btnDevoluciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(143, 29);
            this.btnDevoluciones.TabIndex = 11;
            this.btnDevoluciones.Text = "GP004 - Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.ForeColor = System.Drawing.Color.Black;
            this.btnProveedores.Location = new System.Drawing.Point(39, 218);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(143, 29);
            this.btnProveedores.TabIndex = 10;
            this.btnProveedores.Text = "GP005 - Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnPagos
            // 
            this.btnPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagos.ForeColor = System.Drawing.Color.Black;
            this.btnPagos.Location = new System.Drawing.Point(39, 258);
            this.btnPagos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(143, 29);
            this.btnPagos.TabIndex = 9;
            this.btnPagos.Text = "GP006 - Pagos";
            this.btnPagos.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(245)))));
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.Color.Black;
            this.btnInventario.Location = new System.Drawing.Point(39, 297);
            this.btnInventario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(143, 29);
            this.btnInventario.TabIndex = 8;
            this.btnInventario.Text = "GP007 - Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;
            // 
            // lblCompras
            // 
            this.lblCompras.AutoSize = true;
            this.lblCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompras.ForeColor = System.Drawing.Color.White;
            this.lblCompras.Location = new System.Drawing.Point(84, 22);
            this.lblCompras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompras.Name = "lblCompras";
            this.lblCompras.Size = new System.Drawing.Size(64, 15);
            this.lblCompras.TabIndex = 7;
            this.lblCompras.Text = "Compras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFecha
            // 
            this.panelFecha.Controls.Add(this.lblFecha);
            this.panelFecha.Controls.Add(this.lblHora);
            this.panelFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFecha.Location = new System.Drawing.Point(0, 466);
            this.panelFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(764, 25);
            this.panelFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFecha.Location = new System.Drawing.Point(662, 0);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "label1";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(713, 0);
            this.lblHora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label2";
            // 
            // timerFechaHoraActual
            // 
            this.timerFechaHoraActual.Enabled = true;
            this.timerFechaHoraActual.Tick += new System.EventHandler(this.timerFechaHoraActual_Tick);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 572);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(716, 413);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelRecursosHumanos.ResumeLayout(false);
            this.panelRecursosHumanos.PerformLayout();
            this.panelFinanzas.ResumeLayout(false);
            this.panelFinanzas.PerformLayout();
            this.panelSistema.ResumeLayout(false);
            this.panelSistema.PerformLayout();
            this.panelSeguridad.ResumeLayout(false);
            this.panelSeguridad.PerformLayout();
            this.panelVentas.ResumeLayout(false);
            this.panelVentas.PerformLayout();
            this.panelCompras.ResumeLayout(false);
            this.panelCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
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
        private System.Windows.Forms.Panel panelCompras;
        private System.Windows.Forms.Panel panelVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblCompras;
        private System.Windows.Forms.Panel panelSistema;
        private System.Windows.Forms.Label lblSistema;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Label lblSeguridad;
        private System.Windows.Forms.Label lblRecursosHumanos;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer timerFechaHoraActual;
        private System.Windows.Forms.Panel panelFecha;
        private FontAwesome.Sharp.IconButton btnFinanzas;
        private System.Windows.Forms.Panel panelFinanzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCxP;
        private System.Windows.Forms.Button btnCxC;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnRolesUsuarios;
        private System.Windows.Forms.Button btnDepartamentos;
        private System.Windows.Forms.Button btnPosiciones;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnNominas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnOrdenesVenta;
        private System.Windows.Forms.Button btnFacturasVenta;
        private System.Windows.Forms.Button btnIngresos;
        private System.Windows.Forms.Button btnOrdenesCompras;
        private System.Windows.Forms.Button btnFacturasCompra;
        private System.Windows.Forms.Button btnEntradaMercancia;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnInventario;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private System.Windows.Forms.Button button1;
    }
}