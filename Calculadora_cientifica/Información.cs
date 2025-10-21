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
    public partial class Información : Form
    {
        public Información()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menú menu = new Menú(); 
            menu.Show();
            this.Hide();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            
        }

        private void Adelante_Click(object sender, EventArgs e)
        {

        }
    }
}
