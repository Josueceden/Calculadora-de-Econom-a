namespace Calculadora_cientifica
{
    partial class Calculadora
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
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Del_Total = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.By = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.opcion = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Porc = new System.Windows.Forms.Button();
            this.Par_izq = new System.Windows.Forms.Button();
            this.Par_der = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Pantalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pantalla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pantalla.Location = new System.Drawing.Point(21, 36);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(274, 94);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextChanged += new System.EventHandler(this.Pantalla_TextChanged);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.one.Location = new System.Drawing.Point(21, 185);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 36);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.two.Location = new System.Drawing.Point(77, 185);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 36);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.three.Location = new System.Drawing.Point(133, 185);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 36);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Delete.Location = new System.Drawing.Point(189, 185);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(50, 36);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "DEL";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Del_Total
            // 
            this.Del_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Del_Total.Location = new System.Drawing.Point(245, 185);
            this.Del_Total.Name = "Del_Total";
            this.Del_Total.Size = new System.Drawing.Size(50, 36);
            this.Del_Total.TabIndex = 5;
            this.Del_Total.Text = "AC";
            this.Del_Total.UseVisualStyleBackColor = true;
            this.Del_Total.Click += new System.EventHandler(this.Del_Total_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Divide.Location = new System.Drawing.Point(245, 227);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(50, 36);
            this.Divide.TabIndex = 10;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // By
            // 
            this.By.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.By.Location = new System.Drawing.Point(189, 227);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(50, 36);
            this.By.TabIndex = 9;
            this.By.Text = "*";
            this.By.UseVisualStyleBackColor = true;
            this.By.Click += new System.EventHandler(this.By_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Six.Location = new System.Drawing.Point(133, 227);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(50, 36);
            this.Six.TabIndex = 8;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Five.Location = new System.Drawing.Point(77, 227);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(50, 36);
            this.Five.TabIndex = 7;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Four.Location = new System.Drawing.Point(21, 227);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(50, 36);
            this.Four.TabIndex = 6;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Rest
            // 
            this.Rest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rest.Location = new System.Drawing.Point(245, 269);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(50, 36);
            this.Rest.TabIndex = 15;
            this.Rest.Text = "-";
            this.Rest.UseVisualStyleBackColor = true;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plus.Location = new System.Drawing.Point(189, 269);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 36);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nine.Location = new System.Drawing.Point(133, 269);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 36);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Eight.Location = new System.Drawing.Point(77, 269);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(50, 36);
            this.Eight.TabIndex = 12;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Seven.Location = new System.Drawing.Point(21, 269);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(50, 36);
            this.Seven.TabIndex = 11;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Equal.Location = new System.Drawing.Point(133, 311);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(162, 36);
            this.Equal.TabIndex = 20;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Punto
            // 
            this.Punto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Punto.Location = new System.Drawing.Point(77, 311);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(50, 36);
            this.Punto.TabIndex = 17;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = true;
            this.Punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Zero.Location = new System.Drawing.Point(21, 311);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(50, 36);
            this.Zero.TabIndex = 16;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // opcion
            // 
            this.opcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.opcion.Location = new System.Drawing.Point(245, 143);
            this.opcion.Name = "opcion";
            this.opcion.Size = new System.Drawing.Size(50, 36);
            this.opcion.TabIndex = 25;
            this.opcion.Text = "OPC";
            this.opcion.UseVisualStyleBackColor = true;
            // 
            // Raiz
            // 
            this.Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Raiz.Location = new System.Drawing.Point(189, 143);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(50, 36);
            this.Raiz.TabIndex = 24;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = true;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Porc
            // 
            this.Porc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Porc.Location = new System.Drawing.Point(133, 143);
            this.Porc.Name = "Porc";
            this.Porc.Size = new System.Drawing.Size(50, 36);
            this.Porc.TabIndex = 23;
            this.Porc.Text = "%";
            this.Porc.UseVisualStyleBackColor = true;
            this.Porc.Click += new System.EventHandler(this.Porc_Click);
            // 
            // Par_izq
            // 
            this.Par_izq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Par_izq.Location = new System.Drawing.Point(77, 143);
            this.Par_izq.Name = "Par_izq";
            this.Par_izq.Size = new System.Drawing.Size(50, 36);
            this.Par_izq.TabIndex = 22;
            this.Par_izq.Text = ")";
            this.Par_izq.UseVisualStyleBackColor = true;
            this.Par_izq.Click += new System.EventHandler(this.Par_izq_Click);
            // 
            // Par_der
            // 
            this.Par_der.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Par_der.Location = new System.Drawing.Point(21, 143);
            this.Par_der.Name = "Par_der";
            this.Par_der.Size = new System.Drawing.Size(50, 36);
            this.Par_der.TabIndex = 21;
            this.Par_der.Text = "(";
            this.Par_der.UseVisualStyleBackColor = true;
            this.Par_der.Click += new System.EventHandler(this.Par_der_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cerrar.Location = new System.Drawing.Point(2, 9);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(16, 20);
            this.Cerrar.TabIndex = 26;
            this.Cerrar.Text = "x";
            this.Cerrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // Volver
            // 
            this.Volver.AutoSize = true;
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Volver.Location = new System.Drawing.Point(18, 9);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(18, 20);
            this.Volver.TabIndex = 27;
            this.Volver.Text = "<";
            this.Volver.Click += new System.EventHandler(this.label2_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 393);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.opcion);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Porc);
            this.Controls.Add(this.Par_izq);
            this.Controls.Add(this.Par_der);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Punto);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Rest);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.By);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Del_Total);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.Pantalla);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Del_Total;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button By;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button opcion;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Porc;
        private System.Windows.Forms.Button Par_izq;
        private System.Windows.Forms.Button Par_der;
        private System.Windows.Forms.Label Cerrar;
        private System.Windows.Forms.Label Volver;
    }
}