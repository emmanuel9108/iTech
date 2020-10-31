namespace iTechERP
{
    partial class splash
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splash));
            this.CircleProgressBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.animated = true;
            this.CircleProgressBar.animationIterval = 5;
            this.CircleProgressBar.animationSpeed = 300;
            this.CircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressBar.BackgroundImage")));
            this.CircleProgressBar.Font = new System.Drawing.Font("Ubuntu", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.CircleProgressBar.LabelVisible = true;
            this.CircleProgressBar.LineProgressThickness = 8;
            this.CircleProgressBar.LineThickness = 5;
            this.CircleProgressBar.Location = new System.Drawing.Point(227, 420);
            this.CircleProgressBar.Margin = new System.Windows.Forms.Padding(5);
            this.CircleProgressBar.MaxValue = 100;
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(121)))), ((int)(((byte)(135)))));
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.Chartreuse;
            this.CircleProgressBar.Size = new System.Drawing.Size(162, 162);
            this.CircleProgressBar.TabIndex = 0;
            this.CircleProgressBar.Value = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::iTechERP.Properties.Resources.ite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(625, 625);
            this.Controls.Add(this.CircleProgressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressBar;
        private System.Windows.Forms.Timer timer1;
    }
}

