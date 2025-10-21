using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_cientifica
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Par_der_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "(";
        }

        private void Par_izq_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ")";
        }

        private void Porc_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "%";
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "√";
        }

        private void one_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "6";
        }

        private void By_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "*";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "/";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "+";
        }

        private void Rest_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "-";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            Pantalla.Text += "0";
        }

        private void punto_Click(object sender, EventArgs e)
        {
            Pantalla.Text += ".";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            String Calcular = Pantalla.Text;
            Calcular = Calcular.Replace(",", ".");//Esto evita que cuando
            try
            {
                
                DataTable proceso = new DataTable();
                var resultado = proceso.Compute(Calcular, null);//Aquí se realiza la operación que se guardo en la variable Calcular, que es lo que aparece en la Pantalla
                Pantalla.Text = resultado.ToString();
            }
            catch 
            {
                Pantalla.Text = "ERROR";
            }
        }

        private void Del_Total_Click(object sender, EventArgs e)
        {
            Pantalla.Text = string.Empty;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0) 
            {
                String op_actual = Pantalla.Text;
                Pantalla.Text = op_actual.Substring(0, op_actual.Length - 1);
            }
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') 
            {
                e.Handled = true;
                Pantalla.Text = ".";
                Pantalla.SelectionStart = Pantalla.Text.Length;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menú menu = new Menú();
            menu.Show();
            this.Hide();
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
