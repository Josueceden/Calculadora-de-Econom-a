namespace Calculadora_cientifica
{
    partial class Menú
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
            this.Calc = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calc
            // 
            this.Calc.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calc.Location = new System.Drawing.Point(48, 46);
            this.Calc.Name = "Calc";
            this.Calc.Size = new System.Drawing.Size(158, 40);
            this.Calc.TabIndex = 0;
            this.Calc.Text = "Caluladora";
            this.Calc.UseVisualStyleBackColor = true;
            this.Calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // Info
            // 
            this.Info.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Info.Location = new System.Drawing.Point(48, 157);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(158, 40);
            this.Info.TabIndex = 1;
            this.Info.Text = "Información";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.Exit.Location = new System.Drawing.Point(48, 271);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(158, 40);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Salida";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 355);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.Calc);
            this.Name = "Menú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Calc;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Exit;
    }
}

