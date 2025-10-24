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
        private List<string> terminos;
        private int indiceActual = 0;

        public Información()
        {
            InitializeComponent();
            InicializarTerminos();
            MostrarTerminoActual();
        }

        private void InicializarTerminos()
        {
            terminos = new List<string>
            {
                "INTERÉS SIMPLE",
                "INTERÉS COMPUESTO",
                "FACTORES DE PAGO ÚNICO",
                "FACTORES DE SERIES UNIFORMES"
            };
        }

        private void MostrarTerminoActual()
        {
            if (terminos.Count == 0) return;

            string termino = terminos[indiceActual];
            lblTituloTermino.Text = termino;
            txtDescripcion.Text = ObtenerDescripcion(termino);

            // Actualizar estado de botones
            Atras.Enabled = (indiceActual > 0);
            Adelante.Enabled = (indiceActual < terminos.Count - 1);

            // Actualizar contador
            lblContador.Text = $"{indiceActual + 1} / {terminos.Count}";
        }

        private string ObtenerDescripcion(string termino)
        {
            switch (termino)
            {
                case "INTERÉS SIMPLE":
                    return @"INTERÉS SIMPLE

                            Definición:
                            El interés simple es aquel que se calcula únicamente sobre el capital inicial durante todo el período de la inversión o préstamo.

                            Fórmula General:
                            I = P × i × n

                            Donde:
                            • I = Interés simple
                            • P = Capital inicial (Principal)
                            • i = Tasa de interés por período (en decimal)
                            • n = Número de períodos

                            Monto Total:
                            F = P + I = P × (1 + i × n)

                            Ejemplo:
                            Si P = $1,000, i = 5% anual, n = 3 años:
                            I = 1000 × 0.05 × 3 = $150
                            F = 1000 + 150 = $1,150";

                case "INTERÉS COMPUESTO":
                    return @"INTERÉS COMPUESTO

                            Definición:
                            El interés compuesto es aquel donde los intereses se acumulan al capital en cada período, generando 'interés sobre interés'.

                            Fórmula General:
                            F = P × (1 + i)ⁿ

                            Donde:
                            • F = Valor futuro
                            • P = Valor presente (Capital inicial)
                            • i = Tasa de interés por período (en decimal)
                            • n = Número de períodos

                            Ejemplo:
                            Si P = $1,000, i = 5% anual, n = 3 años:
                            F = 1000 × (1 + 0.05)³ = $1,157.63";

                case "FACTORES DE PAGO ÚNICO":
                    return @"FACTORES DE PAGO ÚNICO

                            Estos factores relacionan un pago único presente con un pago único futuro y viceversa.

                            1. FACTOR DE CAPITALIZACIÓN (F/P)
                               Fórmula: F = P × (F/P, i%, n)
                               Donde: (F/P, i%, n) = (1 + i)ⁿ
                               Usado: Para calcular el valor futuro de una inversión presente

                            2. FACTOR DE ACTUALIZACIÓN (P/F)
                               Fórmula: P = F × (P/F, i%, n)
                               Donde: (P/F, i%, n) = 1 / (1 + i)ⁿ
                               Usado: Para calcular el valor presente de un monto futuro

                            Notación Estándar:
                            • F/P: Encontrar F dado P
                            • P/F: Encontrar P dado F";

                case "FACTORES DE SERIES UNIFORMES":
                    return @"FACTORES DE SERIES UNIFORMES

                            Estos factores relacionan series de pagos uniformes con valores presentes o futuros.

                            1. FACTOR DE FONDO DE AMORTIZACIÓN (A/F)
                               Fórmula: A = F × (A/F, i%, n)
                               Donde: (A/F, i%, n) = i / [(1 + i)ⁿ - 1]
                               Usado: Calcular la anualidad para acumular un monto futuro

                            2. FACTOR DE CAPITALIZACIÓN DE SERIE UNIFORME (F/A)
                               Fórmula: F = A × (F/A, i%, n)
                               Donde: (F/A, i%, n) = [(1 + i)ⁿ - 1] / i
                               Usado: Calcular el valor futuro de una serie de pagos iguales

                            3. FACTOR DE RECUPERACIÓN DE CAPITAL (A/P)
                               Fórmula: A = P × (A/P, i%, n)
                               Donde: (A/P, i%, n) = [i × (1 + i)ⁿ] / [(1 + i)ⁿ - 1]
                               Usado: Calcular el pago periódico para un préstamo

                            4. FACTOR DE ACTUALIZACIÓN DE SERIE UNIFORME (P/A)
                               Fórmula: P = A × (P/A, i%, n)
                               Donde: (P/A, i%, n) = [(1 + i)ⁿ - 1] / [i × (1 + i)ⁿ]
                               Usado: Calcular el valor presente de una serie de pagos iguales

                            Notación Estándar:
                            • A/F: Encontrar A dado F
                            • F/A: Encontrar F dado A
                            • A/P: Encontrar A dado P
                            • P/A: Encontrar P dado A";

                default:
                    return "Descripción no disponible.";
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarTerminoActual();
            }
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            if (indiceActual < terminos.Count - 1)
            {
                indiceActual++;
                MostrarTerminoActual();
            }
        }

        private void Información_Load(object sender, EventArgs e)
        {
            this.Text = "Información - Conceptos Financieros";
        }
    }
}