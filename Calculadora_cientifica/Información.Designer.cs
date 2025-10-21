namespace Calculadora_cientifica
{
    partial class Información
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
            this.label1 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Label();
            this.Cerrar = new System.Windows.Forms.Label();
            this.Text1 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.Label();
            this.NoPag = new System.Windows.Forms.Label();
            this.Atras = new System.Windows.Forms.Button();
            this.Adelante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 27;
            // 
            // Volver
            // 
            this.Volver.AutoSize = true;
            this.Volver.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Volver.Location = new System.Drawing.Point(28, 9);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(13, 18);
            this.Volver.TabIndex = 29;
            this.Volver.Text = "<";
            this.Volver.Click += new System.EventHandler(this.label2_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Cerrar.Location = new System.Drawing.Point(12, 9);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(16, 18);
            this.Cerrar.TabIndex = 28;
            this.Cerrar.Text = "x";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Text1.Location = new System.Drawing.Point(28, 64);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(0, 18);
            this.Text1.TabIndex = 30;
            // 
            // Text2
            // 
            this.Text2.AutoSize = true;
            this.Text2.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Text2.Location = new System.Drawing.Point(364, 64);
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(0, 18);
            this.Text2.TabIndex = 31;
            // 
            // NoPag
            // 
            this.NoPag.AutoSize = true;
            this.NoPag.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.NoPag.Location = new System.Drawing.Point(577, 9);
            this.NoPag.Name = "NoPag";
            this.NoPag.Size = new System.Drawing.Size(24, 18);
            this.NoPag.TabIndex = 32;
            this.NoPag.Text = "1/?";
            // 
            // Atras
            // 
            this.Atras.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atras.Location = new System.Drawing.Point(240, 263);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(59, 42);
            this.Atras.TabIndex = 33;
            this.Atras.Text = "↩";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // Adelante
            // 
            this.Adelante.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adelante.Location = new System.Drawing.Point(305, 263);
            this.Adelante.Name = "Adelante";
            this.Adelante.Size = new System.Drawing.Size(59, 42);
            this.Adelante.TabIndex = 34;
            this.Adelante.Text = "↪";
            this.Adelante.UseVisualStyleBackColor = true;
            this.Adelante.Click += new System.EventHandler(this.Adelante_Click);
            // 
            // Información
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 330);
            this.Controls.Add(this.Adelante);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.NoPag);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.label1);
            this.Name = "Información";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Volver;
        private System.Windows.Forms.Label Cerrar;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label Text2;
        private System.Windows.Forms.Label NoPag;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Button Adelante;
    }
}