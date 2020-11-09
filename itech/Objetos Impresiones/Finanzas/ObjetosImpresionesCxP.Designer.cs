namespace iTechERP
{
    partial class ObjetosImpresionesCxP
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
            this.btnAbrirCxP = new System.Windows.Forms.Button();
            this.rbResumido = new System.Windows.Forms.RadioButton();
            this.rbDetallado = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirCxP
            // 
            this.btnAbrirCxP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirCxP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAbrirCxP.FlatAppearance.BorderSize = 0;
            this.btnAbrirCxP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCxP.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCxP.Location = new System.Drawing.Point(32, 256);
            this.btnAbrirCxP.Name = "btnAbrirCxP";
            this.btnAbrirCxP.Size = new System.Drawing.Size(346, 38);
            this.btnAbrirCxP.TabIndex = 2;
            this.btnAbrirCxP.Text = "Abrir";
            this.btnAbrirCxP.UseVisualStyleBackColor = false;
            this.btnAbrirCxP.Click += new System.EventHandler(this.btnAbrirCxP_Click);
            // 
            // rbResumido
            // 
            this.rbResumido.AutoSize = true;
            this.rbResumido.Location = new System.Drawing.Point(16, 57);
            this.rbResumido.Name = "rbResumido";
            this.rbResumido.Size = new System.Drawing.Size(297, 23);
            this.rbResumido.TabIndex = 1;
            this.rbResumido.TabStop = true;
            this.rbResumido.Text = "Saldo por Antiguedad (CxP) - Resumido";
            this.rbResumido.UseVisualStyleBackColor = true;
            // 
            // rbDetallado
            // 
            this.rbDetallado.AutoSize = true;
            this.rbDetallado.Location = new System.Drawing.Point(16, 108);
            this.rbDetallado.Name = "rbDetallado";
            this.rbDetallado.Size = new System.Drawing.Size(298, 23);
            this.rbDetallado.TabIndex = 2;
            this.rbDetallado.TabStop = true;
            this.rbDetallado.Text = "Saldo por Antiguedad (CxP) - Detallado";
            this.rbDetallado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbDetallado);
            this.groupBox1.Controls.Add(this.rbResumido);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetos de Impresiones - CxP";
            // 
            // ObjetosImpresionesCxP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 333);
            this.Controls.Add(this.btnAbrirCxP);
            this.Controls.Add(this.groupBox1);
            this.Name = "ObjetosImpresionesCxP";
            this.Text = "ObjetosImpresionesCxP";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAbrirCxP;
        private System.Windows.Forms.RadioButton rbResumido;
        private System.Windows.Forms.RadioButton rbDetallado;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}