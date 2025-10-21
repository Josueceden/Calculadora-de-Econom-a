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
            calc.Show();
            this.Hide();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Información info = new Información();
            info.Show();
            this.Hide();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
