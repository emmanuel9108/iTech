﻿namespace iTechERP
{
    partial class ObjetosImpresionesCxC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDetallado = new System.Windows.Forms.RadioButton();
            this.rbResumido = new System.Windows.Forms.RadioButton();
            this.btnAbrirCxC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.rbDetallado);
            this.groupBox1.Controls.Add(this.rbResumido);
            this.groupBox1.Font = new System.Drawing.Font("Ubuntu", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(412, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Objetos de Impresiones - CxC";
            // 
            // rbDetallado
            // 
            this.rbDetallado.AutoSize = true;
            this.rbDetallado.Location = new System.Drawing.Point(12, 88);
            this.rbDetallado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDetallado.Name = "rbDetallado";
            this.rbDetallado.Size = new System.Drawing.Size(362, 28);
            this.rbDetallado.TabIndex = 2;
            this.rbDetallado.TabStop = true;
            this.rbDetallado.Text = "Saldo por Antiguedad (CxC) - Detallado";
            this.rbDetallado.UseVisualStyleBackColor = true;
            // 
            // rbResumido
            // 
            this.rbResumido.AutoSize = true;
            this.rbResumido.Location = new System.Drawing.Point(12, 46);
            this.rbResumido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbResumido.Name = "rbResumido";
            this.rbResumido.Size = new System.Drawing.Size(361, 28);
            this.rbResumido.TabIndex = 1;
            this.rbResumido.TabStop = true;
            this.rbResumido.Text = "Saldo por Antiguedad (CxC) - Resumido";
            this.rbResumido.UseVisualStyleBackColor = true;
            // 
            // btnAbrirCxC
            // 
            this.btnAbrirCxC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirCxC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAbrirCxC.FlatAppearance.BorderSize = 0;
            this.btnAbrirCxC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCxC.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCxC.Location = new System.Drawing.Point(84, 277);
            this.btnAbrirCxC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbrirCxC.Name = "btnAbrirCxC";
            this.btnAbrirCxC.Size = new System.Drawing.Size(260, 31);
            this.btnAbrirCxC.TabIndex = 3;
            this.btnAbrirCxC.Text = "Abrir";
            this.btnAbrirCxC.UseVisualStyleBackColor = false;
            this.btnAbrirCxC.Click += new System.EventHandler(this.btnAbrirCxC_Click);
            // 
            // ObjetosImpresionesCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 336);
            this.Controls.Add(this.btnAbrirCxC);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ObjetosImpresionesCxC";
            this.Text = "ObjetosImpresionesCxC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDetallado;
        private System.Windows.Forms.RadioButton rbResumido;
        private System.Windows.Forms.Button btnAbrirCxC;
    }
}