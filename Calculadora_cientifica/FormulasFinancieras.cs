/*using System;
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
    public partial class FormulasFinancieras : Form
    {
        public FormulasFinancieras()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void CargarCategorias()
        {
            // Categorías basadas en el PDF
            string[] categorias = {
                "Ingresos y Capacidad",
                "Punto de Equilibrio y Margenes",
                "Costos y Variaciones",
                "Interés y Capitalización",
                "Modelos Paramétricos"
            };

            cmbCategoria.DataSource = categorias;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarFormulas();
        }

        private void CargarFormulas()
        {
            string categoria = cmbCategoria.SelectedItem.ToString();
            lstFormulas.Items.Clear();

            switch (categoria)
            {
                case "Ingresos y Capacidad":
                    lstFormulas.Items.Add("Ingreso Total = Precio unitario × Cantidad vendida");
                    lstFormulas.Items.Add("Ingreso Neto = Ingreso Bruto - Gastos");
                    lstFormulas.Items.Add("Ingreso Operacional = Ingreso Bruto - Gastos (actividad)");
                    lstFormulas.Items.Add("Utilización = Capacidad Real / Capacidad de diseño");
                    lstFormulas.Items.Add("Eficiencia = Capacidad Real / Capacidad efectiva");
                    break;

                case "Punto de Equilibrio y Margenes":
                    lstFormulas.Items.Add("Punto de Equilibrio = CF / (PVU - CVU)");
                    lstFormulas.Items.Add("Margen Beneficio Neto = (Beneficio Neto / Ingresos Totales) × 100");
                    lstFormulas.Items.Add("Precio de Venta = CU × (1 + Mgn)");
                    break;

                case "Costos y Variaciones":
                    lstFormulas.Items.Add("Costo Fijo Unitario = Costo Fijo Total / Unidades Producidas");
                    lstFormulas.Items.Add("Costo Variable Unitario = CV Total / Unidades Producidas");
                    lstFormulas.Items.Add("Costo Estándar = Unidades reales × Cantidad estándar × Precio estándar");
                    lstFormulas.Items.Add("Variación Total = CTr - CTe");
                    lstFormulas.Items.Add("Variación Precio = (P real - P estándar) × Cantidad real");
                    lstFormulas.Items.Add("Variación Cantidad = (C. real - C. estándar) × Precio estándar");
                    break;

                case "Interés y Capitalización":
                    lstFormulas.Items.Add("Tasa Efectiva Anual = (1 + i_nominal/m)^m - 1");
                    lstFormulas.Items.Add("Capitalización Continua: i = e^r - 1");
                    lstFormulas.Items.Add("Valor Futuro: F = P(1 + i)^n");
                    lstFormulas.Items.Add("Valor Futuro Continuo: C_t = C_0 × e^(δt)");
                    lstFormulas.Items.Add("Tasa Periódica: i = TNA / M");
                    break;

                case "Modelos Paramétricos":
                    lstFormulas.Items.Add("Lineal Simple: Costo = a + b × (área)");
                    lstFormulas.Items.Add("Múltiple Lineal: Costo = a + b₁×(área) + b₂×(pisos) + b₃×(material)");
                    lstFormulas.Items.Add("No Lineal: Costo = a × (peso)^b");
                    lstFormulas.Items.Add("Basado en Índices: Costo real = Costo base × (Índice inflación)");
                    break;
            }
        }

        private void lstFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFormulas.SelectedItem != null)
            {
                MostrarCalculadoraFormula(lstFormulas.SelectedItem.ToString());
            }
        }

        private void MostrarCalculadoraFormula(string formula)
        {
            panelCalculadora.Visible = true;
            lblFormula.Text = formula;
            LimpiarCampos();

            // Configurar campos según la fórmula seleccionada
            ConfigurarCamposFormula(formula);
        }

        private void ConfigurarCamposFormula(string formula)
        {
            // Limpiar campos dinámicos
            flowLayoutPanel.Controls.Clear();

            if (formula.Contains("Ingreso Total"))
            {
                AgregarCampo("Precio unitario", "precio");
                AgregarCampo("Cantidad vendida", "cantidad");
            }
            else if (formula.Contains("Ingreso Neto"))
            {
                AgregarCampo("Ingreso Bruto", "ingresoBruto");
                AgregarCampo("Gastos", "gastos");
            }
            else if (formula.Contains("Punto de Equilibrio"))
            {
                AgregarCampo("Costos Fijos (CF)", "cf");
                AgregarCampo("Precio Venta Unitario (PVU)", "pvu");
                AgregarCampo("Costo Variable Unitario (CVU)", "cvu");
            }
            else if (formula.Contains("Margen Beneficio Neto"))
            {
                AgregarCampo("Beneficio Neto", "beneficioNeto");
                AgregarCampo("Ingresos Totales", "ingresosTotales");
            }
            else if (formula.Contains("Tasa Efectiva Anual"))
            {
                AgregarCampo("Tasa Nominal (i)", "tasaNominal");
                AgregarCampo("Períodos por año (m)", "periodos");
            }
            else if (formula.Contains("Valor Futuro"))
            {
                AgregarCampo("Valor Presente (P)", "valorPresente");
                AgregarCampo("Tasa de interés (i)", "tasaInteres");
                AgregarCampo("Períodos (n)", "periodos");
            }
            // Agregar más configuraciones según sea necesario
        }

        private void AgregarCampo(string label, string name)
        {
            Panel panel = new Panel { Width = 250, Height = 60, Margin = new Padding(5) };

            Label lbl = new Label
            {
                Text = label,
                Width = 200,
                Location = new Point(0, 5)
            };

            TextBox txt = new TextBox
            {
                Name = name,
                Width = 200,
                Location = new Point(0, 30)
            };

            panel.Controls.Add(lbl);
            panel.Controls.Add(txt);
            flowLayoutPanel.Controls.Add(panel);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double resultado = CalcularFormula();
                txtResultado.Text = resultado.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en el cálculo: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalcularFormula()
        {
            string formula = lblFormula.Text;

            if (formula.Contains("Ingreso Total"))
            {
                double precio = ObtenerValor("precio");
                double cantidad = ObtenerValor("cantidad");
                return precio * cantidad;
            }
            else if (formula.Contains("Ingreso Neto"))
            {
                double ingresoBruto = ObtenerValor("ingresoBruto");
                double gastos = ObtenerValor("gastos");
                return ingresoBruto - gastos;
            }
            else if (formula.Contains("Punto de Equilibrio"))
            {
                double cf = ObtenerValor("cf");
                double pvu = ObtenerValor("pvu");
                double cvu = ObtenerValor("cvu");
                return cf / (pvu - cvu);
            }
            else if (formula.Contains("Margen Beneficio Neto"))
            {
                double beneficioNeto = ObtenerValor("beneficioNeto");
                double ingresosTotales = ObtenerValor("ingresosTotales");
                return (beneficioNeto / ingresosTotales) * 100;
            }
            else if (formula.Contains("Tasa Efectiva Anual"))
            {
                double i_nominal = ObtenerValor("tasaNominal") / 100;
                double m = ObtenerValor("periodos");
                return Math.Pow(1 + i_nominal / m, m) - 1;
            }
            else if (formula.Contains("Valor Futuro") && !formula.Contains("Continua"))
            {
                double P = ObtenerValor("valorPresente");
                double i = ObtenerValor("tasaInteres") / 100;
                double n = ObtenerValor("periodos");
                return P * Math.Pow(1 + i, n);
            }

            throw new Exception("Fórmula no implementada");
        }

        private double ObtenerValor(string nombreCampo)
        {
            foreach (Control panel in flowLayoutPanel.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox txt && txt.Name == nombreCampo)
                    {
                        return double.Parse(txt.Text);
                    }
                }
            }
            throw new Exception($"Campo {nombreCampo} no encontrado");
        }

        private void LimpiarCampos()
        {
            foreach (Control panel in flowLayoutPanel.Controls)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is TextBox txt)
                    {
                        txt.Text = "";
                    }
                }
            }
            txtResultado.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormulasFinancieras_Load(object sender, EventArgs e)
        {
            this.Text = "Fórmulas Financieras";
        }
    }
}*/