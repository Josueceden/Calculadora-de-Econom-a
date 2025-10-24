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
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.FormClosed += (s, args) => this.Show(); // Mostrar menú cuando se cierre la calculadora
            calc.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Información info = new Información();
            info.FormClosed += (s, args) => this.Show(); // Mostrar menú cuando se cierre información
            info.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Confirmar antes de salir
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres salir?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Cerrar toda la aplicación
            }
        }

        private void Menú_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora Financiera - Menú Principal";
        }

        private void Menú_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Confirmacion de salida con la x
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "¿Estás seguro de que quieres salir?",
                    "Confirmar salida",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}