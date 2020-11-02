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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrarFormHijo = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.btnRRHH = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSistema);
            this.panelMenu.Controls.Add(this.btnSeguridad);
            this.panelMenu.Controls.Add(this.btnRRHH);
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
            this.panelTitulo.Controls.Add(this.btnMinimizar);
            this.panelTitulo.Controls.Add(this.btnMaximizar);
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
            this.lblTitulo.Location = new System.Drawing.Point(437, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(82, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "HOME";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.White;
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(957, 659);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(927, -5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(899, -5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 36);
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.UseVisualStyleBackColor = true;
            this.btnMaximizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Open Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(871, -5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 36);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
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
            this.btnSistema.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSistema.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSistema.Image = ((System.Drawing.Image)(resources.GetObject("btnSistema.Image")));
            this.btnSistema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSistema.Location = new System.Drawing.Point(0, 320);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSistema.Size = new System.Drawing.Size(220, 60);
            this.btnSistema.TabIndex = 5;
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
            this.btnSeguridad.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeguridad.Image = ((System.Drawing.Image)(resources.GetObject("btnSeguridad.Image")));
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 260);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(220, 60);
            this.btnSeguridad.TabIndex = 4;
            this.btnSeguridad.Text = "   Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // btnRRHH
            // 
            this.btnRRHH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRRHH.FlatAppearance.BorderSize = 0;
            this.btnRRHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRRHH.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRRHH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRRHH.Image = ((System.Drawing.Image)(resources.GetObject("btnRRHH.Image")));
            this.btnRRHH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRRHH.Location = new System.Drawing.Point(0, 200);
            this.btnRRHH.Name = "btnRRHH";
            this.btnRRHH.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnRRHH.Size = new System.Drawing.Size(220, 60);
            this.btnRRHH.TabIndex = 3;
            this.btnRRHH.Text = "   RR. HH";
            this.btnRRHH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRRHH.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRRHH.UseVisualStyleBackColor = true;
            this.btnRRHH.Click += new System.EventHandler(this.btnRRHH_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 140);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
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
            this.btnCompras.Font = new System.Drawing.Font("Ubuntu", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Location = new System.Drawing.Point(0, 80);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(220, 60);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.Text = "   Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 739);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 500);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPrincipal_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSistema;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Button btnRRHH;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnCerrarFormHijo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}