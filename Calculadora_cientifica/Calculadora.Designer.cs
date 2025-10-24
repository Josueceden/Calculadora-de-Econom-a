namespace Calculadora_cientifica
{
    partial class Calculadora
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.Equal = new System.Windows.Forms.Button();
            this.Punto = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Rest = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.By = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Del_Total = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.panelOperators = new System.Windows.Forms.Panel();
            this.opcion = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Porc = new System.Windows.Forms.Button();
            this.Par_izq = new System.Windows.Forms.Button();
            this.Par_der = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.Volver = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelOperators.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.panelButtons);
            this.panelMain.Controls.Add(this.panelOperators);
            this.panelMain.Controls.Add(this.panelDisplay);
            this.panelMain.Controls.Add(this.panelHeader);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(350, 507);
            this.panelMain.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.White;
            this.panelButtons.Controls.Add(this.Equal);
            this.panelButtons.Controls.Add(this.Punto);
            this.panelButtons.Controls.Add(this.Zero);
            this.panelButtons.Controls.Add(this.Rest);
            this.panelButtons.Controls.Add(this.By);
            this.panelButtons.Controls.Add(this.plus);
            this.panelButtons.Controls.Add(this.nine);
            this.panelButtons.Controls.Add(this.Eight);
            this.panelButtons.Controls.Add(this.Seven);
            this.panelButtons.Controls.Add(this.Divide);
            this.panelButtons.Controls.Add(this.Six);
            this.panelButtons.Controls.Add(this.Five);
            this.panelButtons.Controls.Add(this.Four);
            this.panelButtons.Controls.Add(this.Del_Total);
            this.panelButtons.Controls.Add(this.Delete);
            this.panelButtons.Controls.Add(this.three);
            this.panelButtons.Controls.Add(this.two);
            this.panelButtons.Controls.Add(this.one);
            this.panelButtons.Location = new System.Drawing.Point(20, 220);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(310, 268);
            this.panelButtons.TabIndex = 3;
            // 
            // Equal
            // 
            this.Equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.Equal.FlatAppearance.BorderSize = 0;
            this.Equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Equal.ForeColor = System.Drawing.Color.White;
            this.Equal.Location = new System.Drawing.Point(162, 212);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(138, 45);
            this.Equal.TabIndex = 20;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = false;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Punto
            // 
            this.Punto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Punto.FlatAppearance.BorderSize = 0;
            this.Punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Punto.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Punto.ForeColor = System.Drawing.Color.White;
            this.Punto.Location = new System.Drawing.Point(86, 212);
            this.Punto.Name = "Punto";
            this.Punto.Size = new System.Drawing.Size(70, 45);
            this.Punto.TabIndex = 17;
            this.Punto.Text = ".";
            this.Punto.UseVisualStyleBackColor = false;
            this.Punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // Zero
            // 
            this.Zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Zero.FlatAppearance.BorderSize = 0;
            this.Zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zero.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Zero.ForeColor = System.Drawing.Color.White;
            this.Zero.Location = new System.Drawing.Point(10, 212);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(70, 45);
            this.Zero.TabIndex = 16;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = false;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Rest.FlatAppearance.BorderSize = 0;
            this.Rest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rest.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Rest.ForeColor = System.Drawing.Color.White;
            this.Rest.Location = new System.Drawing.Point(240, 160);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(60, 45);
            this.Rest.TabIndex = 15;
            this.Rest.Text = "-";
            this.Rest.UseVisualStyleBackColor = false;
            this.Rest.Click += new System.EventHandler(this.Rest_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.plus.ForeColor = System.Drawing.Color.White;
            this.plus.Location = new System.Drawing.Point(240, 112);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(60, 44);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.nine.ForeColor = System.Drawing.Color.White;
            this.nine.Location = new System.Drawing.Point(162, 161);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 44);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Eight.FlatAppearance.BorderSize = 0;
            this.Eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Eight.ForeColor = System.Drawing.Color.White;
            this.Eight.Location = new System.Drawing.Point(86, 161);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(70, 45);
            this.Eight.TabIndex = 12;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = false;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Seven
            // 
            this.Seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Seven.FlatAppearance.BorderSize = 0;
            this.Seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Seven.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Seven.ForeColor = System.Drawing.Color.White;
            this.Seven.Location = new System.Drawing.Point(10, 161);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(70, 45);
            this.Seven.TabIndex = 11;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = false;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Divide
            // 
            this.Divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.Divide.FlatAppearance.BorderSize = 0;
            this.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divide.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Divide.ForeColor = System.Drawing.Color.White;
            this.Divide.Location = new System.Drawing.Point(240, 61);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(60, 45);
            this.Divide.TabIndex = 10;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = false;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // By
            // 
            this.By.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.By.FlatAppearance.BorderSize = 0;
            this.By.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.By.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.By.ForeColor = System.Drawing.Color.White;
            this.By.Location = new System.Drawing.Point(240, 10);
            this.By.Name = "By";
            this.By.Size = new System.Drawing.Size(60, 45);
            this.By.TabIndex = 9;
            this.By.Text = "×";
            this.By.UseVisualStyleBackColor = false;
            this.By.Click += new System.EventHandler(this.By_Click);
            // 
            // Six
            // 
            this.Six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Six.FlatAppearance.BorderSize = 0;
            this.Six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Six.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Six.ForeColor = System.Drawing.Color.White;
            this.Six.Location = new System.Drawing.Point(162, 111);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(70, 45);
            this.Six.TabIndex = 8;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = false;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Five
            // 
            this.Five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Five.FlatAppearance.BorderSize = 0;
            this.Five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Five.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Five.ForeColor = System.Drawing.Color.White;
            this.Five.Location = new System.Drawing.Point(86, 111);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(70, 45);
            this.Five.TabIndex = 7;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = false;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Four
            // 
            this.Four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Four.FlatAppearance.BorderSize = 0;
            this.Four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Four.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Four.ForeColor = System.Drawing.Color.White;
            this.Four.Location = new System.Drawing.Point(10, 112);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(70, 44);
            this.Four.TabIndex = 6;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = false;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Del_Total
            // 
            this.Del_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Del_Total.FlatAppearance.BorderSize = 0;
            this.Del_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Del_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Del_Total.ForeColor = System.Drawing.Color.White;
            this.Del_Total.Location = new System.Drawing.Point(162, 10);
            this.Del_Total.Name = "Del_Total";
            this.Del_Total.Size = new System.Drawing.Size(70, 45);
            this.Del_Total.TabIndex = 5;
            this.Del_Total.Text = "AC";
            this.Del_Total.UseVisualStyleBackColor = false;
            this.Del_Total.Click += new System.EventHandler(this.Del_Total_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(86, 10);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(70, 45);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "DEL";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.three.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.three.ForeColor = System.Drawing.Color.White;
            this.three.Location = new System.Drawing.Point(162, 61);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 45);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.two.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.two.ForeColor = System.Drawing.Color.White;
            this.two.Location = new System.Drawing.Point(86, 61);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 45);
            this.two.TabIndex = 2;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.one.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.one.ForeColor = System.Drawing.Color.White;
            this.one.Location = new System.Drawing.Point(10, 61);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 45);
            this.one.TabIndex = 1;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // panelOperators
            // 
            this.panelOperators.BackColor = System.Drawing.Color.White;
            this.panelOperators.Controls.Add(this.opcion);
            this.panelOperators.Controls.Add(this.Raiz);
            this.panelOperators.Controls.Add(this.Porc);
            this.panelOperators.Controls.Add(this.Par_izq);
            this.panelOperators.Controls.Add(this.Par_der);
            this.panelOperators.Location = new System.Drawing.Point(20, 150);
            this.panelOperators.Name = "panelOperators";
            this.panelOperators.Size = new System.Drawing.Size(310, 60);
            this.panelOperators.TabIndex = 2;
            // 
            // opcion
            // 
            this.opcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.opcion.FlatAppearance.BorderSize = 0;
            this.opcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.opcion.ForeColor = System.Drawing.Color.White;
            this.opcion.Location = new System.Drawing.Point(250, 10);
            this.opcion.Name = "opcion";
            this.opcion.Size = new System.Drawing.Size(50, 40);
            this.opcion.TabIndex = 25;
            this.opcion.Text = "OPC";
            this.opcion.UseVisualStyleBackColor = false;
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Raiz.FlatAppearance.BorderSize = 0;
            this.Raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Raiz.ForeColor = System.Drawing.Color.White;
            this.Raiz.Location = new System.Drawing.Point(190, 10);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(50, 40);
            this.Raiz.TabIndex = 24;
            this.Raiz.Text = "√";
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Porc
            // 
            this.Porc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Porc.FlatAppearance.BorderSize = 0;
            this.Porc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Porc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Porc.ForeColor = System.Drawing.Color.White;
            this.Porc.Location = new System.Drawing.Point(130, 10);
            this.Porc.Name = "Porc";
            this.Porc.Size = new System.Drawing.Size(50, 40);
            this.Porc.TabIndex = 23;
            this.Porc.Text = "%";
            this.Porc.UseVisualStyleBackColor = false;
            this.Porc.Click += new System.EventHandler(this.Porc_Click);
            // 
            // Par_izq
            // 
            this.Par_izq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Par_izq.FlatAppearance.BorderSize = 0;
            this.Par_izq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Par_izq.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Par_izq.ForeColor = System.Drawing.Color.White;
            this.Par_izq.Location = new System.Drawing.Point(70, 10);
            this.Par_izq.Name = "Par_izq";
            this.Par_izq.Size = new System.Drawing.Size(50, 40);
            this.Par_izq.TabIndex = 22;
            this.Par_izq.Text = ")";
            this.Par_izq.UseVisualStyleBackColor = false;
            this.Par_izq.Click += new System.EventHandler(this.Par_izq_Click);
            // 
            // Par_der
            // 
            this.Par_der.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.Par_der.FlatAppearance.BorderSize = 0;
            this.Par_der.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Par_der.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Par_der.ForeColor = System.Drawing.Color.White;
            this.Par_der.Location = new System.Drawing.Point(10, 10);
            this.Par_der.Name = "Par_der";
            this.Par_der.Size = new System.Drawing.Size(50, 40);
            this.Par_der.TabIndex = 21;
            this.Par_der.Text = "(";
            this.Par_der.UseVisualStyleBackColor = false;
            this.Par_der.Click += new System.EventHandler(this.Par_der_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelDisplay.Controls.Add(this.Pantalla);
            this.panelDisplay.Location = new System.Drawing.Point(20, 70);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Padding = new System.Windows.Forms.Padding(10);
            this.panelDisplay.Size = new System.Drawing.Size(310, 70);
            this.panelDisplay.TabIndex = 1;
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Pantalla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pantalla.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.Pantalla.ForeColor = System.Drawing.Color.White;
            this.Pantalla.Location = new System.Drawing.Point(10, 10);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.ReadOnly = true;
            this.Pantalla.Size = new System.Drawing.Size(290, 50);
            this.Pantalla.TabIndex = 0;
            this.Pantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pantalla.TextChanged += new System.EventHandler(this.Pantalla_TextChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panelHeader.Controls.Add(this.Volver);
            this.panelHeader.Controls.Add(this.Cerrar);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(350, 60);
            this.panelHeader.TabIndex = 0;
            // 
            // Volver
            // 
            this.Volver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Volver.FlatAppearance.BorderSize = 0;
            this.Volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Volver.ForeColor = System.Drawing.Color.White;
            this.Volver.Location = new System.Drawing.Point(260, 15);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(35, 30);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "←";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Cerrar.ForeColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(300, 15);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(35, 30);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "X";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(15, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Calculadora Financiera";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 507);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximumSize = new System.Drawing.Size(366, 546);
            this.MinimumSize = new System.Drawing.Size(366, 546);
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Financiera";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculadora_KeyPress);
            this.panelMain.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelOperators.ResumeLayout(false);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Panel panelOperators;
        private System.Windows.Forms.Button opcion;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Porc;
        private System.Windows.Forms.Button Par_izq;
        private System.Windows.Forms.Button Par_der;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Punto;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Rest;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button By;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Del_Total;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Cerrar;
    }
}