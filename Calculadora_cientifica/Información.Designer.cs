namespace Calculadora_cientifica
{
    partial class Información
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.listBoxFormulas = new System.Windows.Forms.ListBox();
            this.listBoxCategorias = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.txtEjemplo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.panelNavegacion = new System.Windows.Forms.Panel();
            this.Adelante = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblTituloTermino = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.panelNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1200, 50);
            this.panelSuperior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Información - Conceptos Financieros";
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelLateral.Controls.Add(this.listBoxFormulas);
            this.panelLateral.Controls.Add(this.listBoxCategorias);
            this.panelLateral.Controls.Add(this.label3);
            this.panelLateral.Controls.Add(this.label2);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 50);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(280, 606);
            this.panelLateral.TabIndex = 1;
            // 
            // listBoxFormulas
            // 
            this.listBoxFormulas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFormulas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.listBoxFormulas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFormulas.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.listBoxFormulas.ForeColor = System.Drawing.Color.White;
            this.listBoxFormulas.FormattingEnabled = true;
            this.listBoxFormulas.ItemHeight = 17;
            this.listBoxFormulas.Location = new System.Drawing.Point(12, 240);
            this.listBoxFormulas.Name = "listBoxFormulas";
            this.listBoxFormulas.Size = new System.Drawing.Size(256, 357);
            this.listBoxFormulas.TabIndex = 3;
            this.listBoxFormulas.SelectedIndexChanged += new System.EventHandler(this.listBoxFormulas_SelectedIndexChanged);
            // 
            // listBoxCategorias
            // 
            this.listBoxCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.listBoxCategorias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxCategorias.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.listBoxCategorias.ForeColor = System.Drawing.Color.White;
            this.listBoxCategorias.FormattingEnabled = true;
            this.listBoxCategorias.ItemHeight = 17;
            this.listBoxCategorias.Location = new System.Drawing.Point(12, 50);
            this.listBoxCategorias.Name = "listBoxCategorias";
            this.listBoxCategorias.Size = new System.Drawing.Size(256, 153);
            this.listBoxCategorias.TabIndex = 2;
            this.listBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.listBoxCategorias_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fórmulas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "← Volver al Menú";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.White;
            this.panelContenido.Controls.Add(this.txtEjemplo);
            this.panelContenido.Controls.Add(this.label5);
            this.panelContenido.Controls.Add(this.lblEcuacion);
            this.panelContenido.Controls.Add(this.label4);
            this.panelContenido.Controls.Add(this.lblContador);
            this.panelContenido.Controls.Add(this.panelNavegacion);
            this.panelContenido.Controls.Add(this.txtDescripcion);
            this.panelContenido.Controls.Add(this.lblTituloTermino);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(280, 50);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(20);
            this.panelContenido.Size = new System.Drawing.Size(920, 606);
            this.panelContenido.TabIndex = 2;
            // 
            // txtEjemplo
            // 
            this.txtEjemplo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEjemplo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.txtEjemplo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEjemplo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.txtEjemplo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.txtEjemplo.Location = new System.Drawing.Point(23, 480);
            this.txtEjemplo.Multiline = true;
            this.txtEjemplo.Name = "txtEjemplo";
            this.txtEjemplo.ReadOnly = true;
            this.txtEjemplo.Size = new System.Drawing.Size(874, 56);
            this.txtEjemplo.TabIndex = 7;
            this.txtEjemplo.Text = "Ejemplo práctico...";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(20, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ejemplo:";
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Bold);
            this.lblEcuacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.lblEcuacion.Location = new System.Drawing.Point(100, 50);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(177, 91);
            this.lblEcuacion.TabIndex = 5;
            this.lblEcuacion.Text = "F = P × (1 + i)ⁿ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ecuación:";
            // 
            // lblContador
            // 
            this.lblContador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblContador.ForeColor = System.Drawing.Color.Gray;
            this.lblContador.Location = new System.Drawing.Point(807, 556);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(30, 15);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "1 / 4";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelNavegacion
            // 
            this.panelNavegacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelNavegacion.Controls.Add(this.Adelante);
            this.panelNavegacion.Controls.Add(this.Atras);
            this.panelNavegacion.Location = new System.Drawing.Point(23, 541);
            this.panelNavegacion.Name = "panelNavegacion";
            this.panelNavegacion.Size = new System.Drawing.Size(200, 40);
            this.panelNavegacion.TabIndex = 2;
            // 
            // Adelante
            // 
            this.Adelante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Adelante.FlatAppearance.BorderSize = 0;
            this.Adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adelante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Adelante.ForeColor = System.Drawing.Color.White;
            this.Adelante.Location = new System.Drawing.Point(103, 5);
            this.Adelante.Name = "Adelante";
            this.Adelante.Size = new System.Drawing.Size(90, 30);
            this.Adelante.TabIndex = 1;
            this.Adelante.Text = "Siguiente →";
            this.Adelante.UseVisualStyleBackColor = false;
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // Atras
            // 
            this.Atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Atras.FlatAppearance.BorderSize = 0;
            this.Atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atras.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Atras.ForeColor = System.Drawing.Color.White;
            this.Atras.Location = new System.Drawing.Point(7, 5);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(90, 30);
            this.Atras.TabIndex = 0;
            this.Atras.Text = "← Anterior";
            this.Atras.UseVisualStyleBackColor = false;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(23, 150);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(874, 300);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblTituloTermino
            // 
            this.lblTituloTermino.AutoSize = true;
            this.lblTituloTermino.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloTermino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblTituloTermino.Location = new System.Drawing.Point(18, 20);
            this.lblTituloTermino.Name = "lblTituloTermino";
            this.lblTituloTermino.Size = new System.Drawing.Size(169, 30);
            this.lblTituloTermino.TabIndex = 0;
            this.lblTituloTermino.Text = "Término Actual";
            // 
            // Información
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 656);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelSuperior);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximumSize = new System.Drawing.Size(1216, 695);
            this.MinimumSize = new System.Drawing.Size(1216, 695);
            this.Name = "Información";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Información_Load);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.panelNavegacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblTituloTermino;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Adelante;
        private System.Windows.Forms.Panel panelNavegacion;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.ListBox listBoxCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFormulas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.TextBox txtEjemplo;
        private System.Windows.Forms.Label label5;
    }
}