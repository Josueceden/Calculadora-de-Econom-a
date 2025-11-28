using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_cientifica
{
    public partial class Calculadora : Form
    {
        private bool mostrarFormulas = false;
        private const int AnchoNormal = 350;
        private const int AnchoConFormulas = 1280;
        private Label lblTeoria;
        private Label lblEjemplo;

        private class FormulaFinanciera
        {
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public string DescripcionTeorica { get; set; }
            public string EjemploPractico { get; set; }
            public string EcuacionVisual { get; set; }
            public Dictionary<string, string> Variables { get; set; }
            public Func<Dictionary<string, double>, double> LogicaCalculo { get; set; }
        }

        private List<FormulaFinanciera> baseDeDatosFormulas;
        private FormulaFinanciera formulaSeleccionadaActual;

        public Calculadora()
        {
            InitializeComponent();
            InicializarBaseDeDatosFormulas();
            OcultarPanelFormulas();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            this.Text = "Calculadora Financiera";
            this.MaximumSize = new Size(0, 0);
            this.MinimumSize = new Size(AnchoNormal, 600);
            this.Size = new Size(AnchoNormal, 600);

            CrearLabelsDinamicos();

            this.CenterToScreen();
        }

        private void CrearLabelsDinamicos()
        {
            lblTeoria = new Label();
            lblTeoria.AutoSize = false;
            lblTeoria.Size = new Size(480, 40);
            lblTeoria.Location = new Point(10, 65);
            lblTeoria.Font = new Font("Segoe UI", 8.5F, FontStyle.Italic);
            lblTeoria.ForeColor = Color.DarkSlateGray;
            lblTeoria.TextAlign = ContentAlignment.TopLeft;
            panelCalculadoraFormula.Controls.Add(lblTeoria);

            lblEjemplo = new Label();
            lblEjemplo.AutoSize = false;
            lblEjemplo.Size = new Size(480, 50);
            lblEjemplo.Location = new Point(10, 105);
            lblEjemplo.Font = new Font("Segoe UI", 8F, FontStyle.Regular);
            lblEjemplo.ForeColor = Color.FromArgb(44, 62, 80);
            lblEjemplo.TextAlign = ContentAlignment.TopLeft;
            panelCalculadoraFormula.Controls.Add(lblEjemplo);

            flowLayoutPanelCampos.Location = new Point(13, 160);
            flowLayoutPanelCampos.Size = new Size(481, 180);
        }

        private void InicializarBaseDeDatosFormulas()
        {
            baseDeDatosFormulas = new List<FormulaFinanciera>();

            // INTERÉS SIMPLE Y COMPUESTO
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés Simple y Compuesto",
                Nombre = "Interés Simple",
                DescripcionTeorica = "Interés calculado solamente sobre el capital inicial durante cada periodo.",
                EjemploPractico = "Ejemplo: Préstamo $1000 al 5% anual por 3 años → Capital: 1000, Tasa: 0.05, Años: 3",
                EcuacionVisual = "I = P × i × N",
                Variables = new Dictionary<string, string> {
                    { "P", "Capital Principal" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["P"] * vars["i"] * vars["N"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés Simple y Compuesto",
                Nombre = "Valor Futuro (Interés Simple)",
                DescripcionTeorica = "Valor futuro de una inversión calculada con interés simple.",
                EjemploPractico = "Ejemplo: Inviertes $1000 al 8% simple por 4 años → VP: 1000, Tasa: 0.08, Años: 4",
                EcuacionVisual = "F = P × (1 + i × N)",
                Variables = new Dictionary<string, string> {
                    { "P", "Valor Presente" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["P"] * (1 + vars["i"] * vars["N"])
            });

            // FACTORES DE SERIE UNIFORME
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Factores de Serie Uniforme",
                Nombre = "Valor Futuro de Anualidad (F/A)",
                DescripcionTeorica = "Valor futuro de una serie de pagos uniformes al final de cada periodo.",
                EjemploPractico = "Ejemplo: Ahorras $5000 anuales al 6% por 5 años → A: 5000, Tasa: 0.06, Años: 5",
                EcuacionVisual = "F = A × [(1+i)ⁿ - 1]/i",
                Variables = new Dictionary<string, string> {
                    { "A", "Anualidad" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["A"] * (Math.Pow(1 + vars["i"], vars["N"]) - 1) / vars["i"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Factores de Serie Uniforme",
                Nombre = "Valor Presente de Anualidad (P/A)",
                DescripcionTeorica = "Valor presente de una serie de pagos uniformes al final de cada periodo.",
                EjemploPractico = "Ejemplo: Recibirás $3000 anuales por 10 años al 8% → A: 3000, Tasa: 0.08, Años: 10",
                EcuacionVisual = "P = A × [1 - (1+i)⁻ⁿ]/i",
                Variables = new Dictionary<string, string> {
                    { "A", "Anualidad" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["A"] * (1 - Math.Pow(1 + vars["i"], -vars["N"])) / vars["i"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Factores de Serie Uniforme",
                Nombre = "Fondo de Amortización (A/F)",
                DescripcionTeorica = "Anualidad necesaria para acumular un valor futuro específico.",
                EjemploPractico = "Ejemplo: Necesitas $50,000 en 8 años al 7% → F: 50000, Tasa: 0.07, Años: 8",
                EcuacionVisual = "A = F × i/[(1+i)ⁿ - 1]",
                Variables = new Dictionary<string, string> {
                    { "F", "Valor Futuro" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["F"] * vars["i"] / (Math.Pow(1 + vars["i"], vars["N"]) - 1)
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Factores de Serie Uniforme",
                Nombre = "Recuperación de Capital (A/P)",
                DescripcionTeorica = "Pago anual uniforme equivalente a un valor presente.",
                EjemploPractico = "Ejemplo: Préstamo $25,000 al 12% por 6 años → P: 25000, Tasa: 0.12, Años: 6",
                EcuacionVisual = "A = P × [i(1+i)ⁿ]/[(1+i)ⁿ - 1]",
                Variables = new Dictionary<string, string> {
                    { "P", "Valor Presente" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) =>
                {
                    double factor = (vars["i"] * Math.Pow(1 + vars["i"], vars["N"])) / (Math.Pow(1 + vars["i"], vars["N"]) - 1);
                    return vars["P"] * factor;
                }
            });

            // INGRESOS Y CAPACIDAD
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Ingresos y Capacidad",
                Nombre = "Ingreso Total",
                DescripcionTeorica = "El valor total de las ventas antes de deducir costos. Fundamental para medir el tamaño de la operación.",
                EjemploPractico = "Ejemplo: Vendes 100 productos a $15 cada uno → Precio: 15, Cantidad: 100",
                EcuacionVisual = "IT = Precio × Cantidad",
                Variables = new Dictionary<string, string> {
                    { "P", "Precio Unitario" },
                    { "Q", "Cantidad Vendida" }
                },
                LogicaCalculo = (vars) => vars["P"] * vars["Q"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Ingresos y Capacidad",
                Nombre = "Ingreso Neto",
                DescripcionTeorica = "Lo que queda del ingreso bruto después de restar gastos, devoluciones o descuentos.",
                EjemploPractico = "Ejemplo: Ingresos $5000, gastos $1200 → Ing. Bruto: 5000, Gastos: 1200",
                EcuacionVisual = "IN = Ingreso Bruto - Gastos",
                Variables = new Dictionary<string, string> {
                    { "IB", "Ingreso Bruto" },
                    { "G", "Gastos Totales" }
                },
                LogicaCalculo = (vars) => vars["IB"] - vars["G"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Ingresos y Capacidad",
                Nombre = "Utilización",
                DescripcionTeorica = "Porcentaje de uso de la capacidad instalada teórica de diseño.",
                EjemploPractico = "Ejemplo: Produces 800 unidades vs capacidad máxima 1000 → Cap. Real: 800, Cap. Diseño: 1000",
                EcuacionVisual = "U = (Cap. Real / Cap. Diseño) × 100",
                Variables = new Dictionary<string, string> {
                    { "CR", "Capacidad Real" },
                    { "CD", "Capacidad de Diseño" }
                },
                LogicaCalculo = (vars) => (vars["CR"] / vars["CD"]) * 100
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Ingresos y Capacidad",
                Nombre = "Eficiencia",
                DescripcionTeorica = "Mide el rendimiento respecto a la capacidad efectiva (lo que realmente se espera producir).",
                EjemploPractico = "Ejemplo: Produces 750 unidades vs objetivo 900 → Cap. Real: 750, Cap. Efectiva: 900",
                EcuacionVisual = "E = (Cap. Real / Cap. Efectiva) × 100",
                Variables = new Dictionary<string, string> {
                    { "CR", "Capacidad Real" },
                    { "CE", "Capacidad Efectiva" }
                },
                LogicaCalculo = (vars) => (vars["CR"] / vars["CE"]) * 100
            });

            // PUNTO DE EQUILIBRIO Y MÁRGENES
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Punto de Equilibrio y Margenes",
                Nombre = "Punto de Equilibrio (Unidades)",
                DescripcionTeorica = "Cantidad de unidades a vender para cubrir todos los costos (beneficio 0).",
                EjemploPractico = "Ejemplo: Costos fijos $2000, precio venta $50, costo variable $30 → CF: 2000, PVU: 50, CVU: 30",
                EcuacionVisual = "PE = CF / (PVU - CVU)",
                Variables = new Dictionary<string, string> {
                    { "CF", "Costos Fijos Totales" },
                    { "PVU", "Precio Venta Unitario" },
                    { "CVU", "Costo Var. Unitario" }
                },
                LogicaCalculo = (vars) => vars["CF"] / (vars["PVU"] - vars["CVU"])
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Punto de Equilibrio y Margenes",
                Nombre = "Margen de Beneficio Neto",
                DescripcionTeorica = "Porcentaje de ganancia real sobre los ingresos totales.",
                EjemploPractico = "Ejemplo: Ganaste $1500 con ventas de $5000 → Beneficio: 1500, Ingresos: 5000",
                EcuacionVisual = "Margen % = (Beneficio / Ingresos) × 100",
                Variables = new Dictionary<string, string> {
                    { "BN", "Beneficio Neto" },
                    { "IT", "Ingresos Totales" }
                },
                LogicaCalculo = (vars) => (vars["BN"] / vars["IT"]) * 100
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Punto de Equilibrio y Margenes",
                Nombre = "Precio de Venta (Mark-up)",
                DescripcionTeorica = "Cálculo del precio basado en el costo y un margen de ganancia deseado.",
                EjemploPractico = "Ejemplo: Costo $80, quieres 25% margen → CostoU: 80, Margen: 0.25",
                EcuacionVisual = "P = CostoU × (1 + Margen)",
                Variables = new Dictionary<string, string> {
                    { "CU", "Costo Unitario" },
                    { "Mgn", "Margen (decimal, ej 0.2)" }
                },
                LogicaCalculo = (vars) => vars["CU"] * (1 + vars["Mgn"])
            });

            // COSTOS Y VARIACIONES
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Costos y Variaciones",
                Nombre = "Costo Fijo Unitario",
                DescripcionTeorica = "Reparto de costos fijos entre las unidades producidas. Disminuye a mayor producción.",
                EjemploPractico = "Ejemplo: Costos fijos $5000, produces 1000 unidades → CFT: 5000, Unidades: 1000",
                EcuacionVisual = "CFu = CF Total / Unidades",
                Variables = new Dictionary<string, string> {
                    { "CFT", "Costo Fijo Total" },
                    { "Q", "Unidades Producidas" }
                },
                LogicaCalculo = (vars) => vars["CFT"] / vars["Q"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Costos y Variaciones",
                Nombre = "Variación Total",
                DescripcionTeorica = "Diferencia neta entre lo que costó realmente y lo que debió costar (Estándar).",
                EjemploPractico = "Ejemplo: Costo real $4500 vs estándar $4000 → C. Real: 4500, C. Estándar: 4000",
                EcuacionVisual = "VT = Costo Real - Costo Estándar",
                Variables = new Dictionary<string, string> {
                    { "CTr", "Costo Total Real" },
                    { "CTe", "Costo Total Estándar" }
                },
                LogicaCalculo = (vars) => vars["CTr"] - vars["CTe"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Costos y Variaciones",
                Nombre = "Variación Precio",
                DescripcionTeorica = "Cuánto de la variación se debe a cambios en el precio de los insumos.",
                EjemploPractico = "Ejemplo: Precio real $12 vs estándar $10, usaste 200 unidades → P.Real: 12, P.Std: 10, Cantidad: 200",
                EcuacionVisual = "VP = (P.Real - P.Std) × Cant.Real",
                Variables = new Dictionary<string, string> {
                    { "PR", "Precio Real" },
                    { "PS", "Precio Estándar" },
                    { "QR", "Cantidad Real Consumida" }
                },
                LogicaCalculo = (vars) => (vars["PR"] - vars["PS"]) * vars["QR"]
            });

            // INTERÉS Y CAPITALIZACIÓN
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés y Capitalización",
                Nombre = "Valor Futuro (Compuesto)",
                DescripcionTeorica = "Valor de un capital proyectado en el tiempo con interés compuesto.",
                EjemploPractico = "Ejemplo: Inviertes $1000 al 5% anual por 3 años → VP: 1000, Tasa: 0.05, Períodos: 3",
                EcuacionVisual = "VF = VP × (1 + i)^n",
                Variables = new Dictionary<string, string> {
                    { "VP", "Valor Presente" },
                    { "i", "Tasa Interés (decimal)" },
                    { "n", "Número Períodos" }
                },
                LogicaCalculo = (vars) => vars["VP"] * Math.Pow(1 + vars["i"], vars["n"])
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés y Capitalización",
                Nombre = "Tasa Efectiva Anual",
                DescripcionTeorica = "Tasa real ganada en un año considerando la capitalización intra-anual.",
                EjemploPractico = "Ejemplo: Tasa nominal 12% con capitalización mensual → Tasa Nominal: 0.12, Capitalizaciones: 12",
                EcuacionVisual = "TEA = ((1 + j/m)^m) - 1",
                Variables = new Dictionary<string, string> {
                    { "j", "Tasa Nominal Anual (decimal)" },
                    { "m", "Capitalizaciones por año" }
                },
                LogicaCalculo = (vars) => (Math.Pow(1 + (vars["j"] / vars["m"]), vars["m"]) - 1) * 100
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés y Capitalización",
                Nombre = "Interés Continuo",
                DescripcionTeorica = "Tasa equivalente cuando la capitalización ocurre en cada instante infinitesimal.",
                EjemploPractico = "Ejemplo: Tasa instantánea del 8% → Tasa Instantánea: 0.08",
                EcuacionVisual = "i = (e^r) - 1",
                Variables = new Dictionary<string, string> {
                    { "r", "Tasa Instantánea (decimal)" }
                },
                LogicaCalculo = (vars) => (Math.Exp(vars["r"]) - 1) * 100
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Interés y Capitalización",
                Nombre = "Valor Presente (P/F)",
                DescripcionTeorica = "Valor presente de una cantidad futura descontada a una tasa específica.",
                EjemploPractico = "Ejemplo: Necesitas $20,000 en 5 años al 6% → VF: 20000, Tasa: 0.06, Años: 5",
                EcuacionVisual = "P = F × (1+i)⁻ⁿ",
                Variables = new Dictionary<string, string> {
                    { "F", "Valor Futuro" },
                    { "i", "Tasa Interés (decimal)" },
                    { "N", "Número de Periodos" }
                },
                LogicaCalculo = (vars) => vars["F"] * Math.Pow(1 + vars["i"], -vars["N"])
            });

            // MODELOS PARAMÉTRICOS
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Modelos Paramétricos",
                Nombre = "Estimación Lineal Simple",
                DescripcionTeorica = "Estimación de costo basada en una única variable (ej. m2 construcción).",
                EjemploPractico = "Ejemplo: Costo base $5000 + $200 por m2, construyes 120m2 → Costo Base: 5000, Factor: 200, Variable: 120",
                EcuacionVisual = "Costo = a + b × X",
                Variables = new Dictionary<string, string> {
                    { "a", "Costo Base (Fijo)" },
                    { "b", "Factor Variable" },
                    { "X", "Variable (ej. Área)" }
                },
                LogicaCalculo = (vars) => vars["a"] + (vars["b"] * vars["X"])
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Modelos Paramétricos",
                Nombre = "Costo por Índices",
                DescripcionTeorica = "Ajuste del costo histórico a valor presente usando índices de inflación.",
                EjemploPractico = "Ejemplo: Costo histórico $8000, índice de inflación 1.05 → Costo Base: 8000, Índice: 1.05",
                EcuacionVisual = "C.Real = C.Base × (Indice/100)",
                Variables = new Dictionary<string, string> {
                    { "CB", "Costo Base Histórico" },
                    { "Ind", "Índice Inflación (ej. 1.05)" }
                },
                LogicaCalculo = (vars) => vars["CB"] * vars["Ind"]
            });

            // EVALUACIÓN DE PROYECTOS
            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Evaluación de Proyectos",
                Nombre = "Valor Presente Neto (VPN)",
                DescripcionTeorica = "Valor presente de todos los flujos de efectivo de un proyecto. VPN > 0 indica proyecto rentable.",
                EjemploPractico = "Ejemplo: Inversión $10,000, flujos $3000 anuales por 5 años, TMAR 10% → Inversion: 10000, FlujoAnual: 3000, TMAR: 0.10, Años: 5",
                EcuacionVisual = "VPN = -P + A(P/A,i,N)",
                Variables = new Dictionary<string, string> {
                    { "P", "Inversión Inicial" },
                    { "A", "Flujo Anual Neto" },
                    { "i", "TMAR (decimal)" },
                    { "N", "Vida del Proyecto (años)" }
                },
                LogicaCalculo = (vars) =>
                {
                    double pvAnnuity = vars["A"] * (1 - Math.Pow(1 + vars["i"], -vars["N"])) / vars["i"];
                    return -vars["P"] + pvAnnuity;
                }
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Evaluación de Proyectos",
                Nombre = "Periodo de Recuperación Simple",
                DescripcionTeorica = "Tiempo necesario para recuperar la inversión inicial con flujos constantes.",
                EjemploPractico = "Ejemplo: Inversión $15,000, flujo anual $4,000 → Inversion: 15000, FlujoAnual: 4000",
                EcuacionVisual = "PRI = Inversión / Flujo Anual",
                Variables = new Dictionary<string, string> {
                    { "P", "Inversión Inicial" },
                    { "A", "Flujo Anual Neto" }
                },
                LogicaCalculo = (vars) => vars["P"] / vars["A"]
            });

            baseDeDatosFormulas.Add(new FormulaFinanciera
            {
                Categoria = "Evaluación de Proyectos",
                Nombre = "Relación Beneficio/Costo",
                DescripcionTeorica = "Ratio que compara el valor presente de beneficios vs costos. B/C > 1 indica proyecto favorable.",
                EjemploPractico = "Ejemplo: VP beneficios $50,000, VP costos $40,000 → VP_Beneficios: 50000, VP_Costos: 40000",
                EcuacionVisual = "B/C = VP Beneficios / VP Costos",
                Variables = new Dictionary<string, string> {
                    { "VPB", "VP Beneficios" },
                    { "VPC", "VP Costos" }
                },
                LogicaCalculo = (vars) => vars["VPB"] / vars["VPC"]
            });
        }

        private void Par_der_Click(object sender, EventArgs e) { Pantalla.Text += "("; }
        private void Par_izq_Click(object sender, EventArgs e) { Pantalla.Text += ")"; }
        private void Porc_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Pantalla.Text, out double num))
            {
                Pantalla.Text = (num / 100).ToString();
            }
        }
        private void Raiz_Click(object sender, EventArgs e)
        {

            if (double.TryParse(Pantalla.Text, out double num) && num >= 0)
            {
                Pantalla.Text = Math.Sqrt(num).ToString();
            }
            else
            {
                Pantalla.Text = "ERROR";
            }
        }

        private void one_Click(object sender, EventArgs e) { Pantalla.Text += "1"; }
        private void two_Click(object sender, EventArgs e) { Pantalla.Text += "2"; }
        private void three_Click(object sender, EventArgs e) { Pantalla.Text += "3"; }
        private void Four_Click(object sender, EventArgs e) { Pantalla.Text += "4"; }
        private void Five_Click(object sender, EventArgs e) { Pantalla.Text += "5"; }
        private void Six_Click(object sender, EventArgs e) { Pantalla.Text += "6"; }
        private void Seven_Click(object sender, EventArgs e) { Pantalla.Text += "7"; }
        private void Eight_Click(object sender, EventArgs e) { Pantalla.Text += "8"; }
        private void nine_Click(object sender, EventArgs e) { Pantalla.Text += "9"; }
        private void Zero_Click(object sender, EventArgs e) { Pantalla.Text += "0"; }
        private void punto_Click(object sender, EventArgs e) { Pantalla.Text += "."; }

        private void By_Click(object sender, EventArgs e) { Pantalla.Text += "*"; }
        private void Divide_Click(object sender, EventArgs e) { Pantalla.Text += "/"; }
        private void plus_Click(object sender, EventArgs e) { Pantalla.Text += "+"; }
        private void Rest_Click(object sender, EventArgs e) { Pantalla.Text += "-"; }

        private void Sign_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length > 0 && Pantalla.Text != "0" && Pantalla.Text != "ERROR")
            {
                Pantalla.Text = Pantalla.Text.StartsWith("-") ? Pantalla.Text.Substring(1) : "-" + Pantalla.Text;
            }
        }

        private void Potencia_Click(object sender, EventArgs e)
        {
            OperacionSimple(val => Math.Pow(val, 2));
        }

        private void Inverso_Click(object sender, EventArgs e)
        {
            OperacionSimple(val => val != 0 ? 1 / val : double.NaN);
        }

        private void Recipro_Click(object sender, EventArgs e)
        {
            OperacionSimple(val => val != 0 ? 1 / val : double.NaN);
        }

        private void Expo_Click(object sender, EventArgs e)
        {
            // Botón de potencia simple - solo agrega el símbolo ^
            Pantalla.Text += "^";
        }

        private void Logarit_Click(object sender, EventArgs e)
        {
            OperacionSimple(val => val > 0 ? Math.Log10(val) : double.NaN);
        }

        private void Facto_Click(object sender, EventArgs e)
        {
            string texto = Pantalla.Text.Replace(",", ".");
            if (!double.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out double num))
            {
                Pantalla.Text = "ERROR";
                return;
            }

            if (num < 0 || num != Math.Floor(num))
            {
                Pantalla.Text = "ERROR";
                return;
            }

            if (num > 170)
            {
                Pantalla.Text = "∞";
                return;
            }

            long fact = 1;
            for (int i = 1; i <= (int)num; i++)
            {

                if (fact > long.MaxValue / i)
                {
                    Pantalla.Text = "∞";
                    return;
                }
                fact *= i;
            }

            Pantalla.Text = fact.ToString();
        }

        private void OperacionSimple(Func<double, double> op)
        {
            if (double.TryParse(Pantalla.Text, out double num))
            {
                double res = op(num);
                Pantalla.Text = double.IsNaN(res) ? "ERROR" : res.ToString();
            }
        }

        private object EvaluarExpresion(string expresion)
        {
            expresion = expresion.Replace(",", ".");
            // Reemplazar ^ por Math.Pow
            expresion = System.Text.RegularExpressions.Regex.Replace(
                expresion,
                @"(\d+(?:\.\d+)?)\s*\^\s*(\d+(?:\.\d+)?)",
                "Math.Pow($1,$2)"
            );

            string code = @"
        using System;
        public static class Evaluador
        {
            public static double Eval()
            {
                return " + expresion + @";
            }
        }";

            var provider = new Microsoft.CSharp.CSharpCodeProvider();
            var parameters = new System.CodeDom.Compiler.CompilerParameters();
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.GenerateInMemory = true;

            var results = provider.CompileAssemblyFromSource(parameters, code);

            if (results.Errors.HasErrors)
            {
                throw new Exception("Error en la expresión");
            }

            var assembly = results.CompiledAssembly;
            var type = assembly.GetType("Evaluador");
            var method = type.GetMethod("Eval");
            return method.Invoke(null, null);
        }
        private void Equal_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = EvaluarExpresion(Pantalla.Text);
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
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }

        private void Calculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
            {
                e.Handled = true;
                Pantalla.Text += ".";
                Pantalla.SelectionStart = Pantalla.Text.Length;
            }
        }

        private void Pantalla_TextChanged(object sender, EventArgs e)
        {
            Pantalla.SelectionStart = Pantalla.Text.Length;
            Pantalla.ScrollToCaret();
        }

        private void btnFormulas_Click(object sender, EventArgs e)
        {
            mostrarFormulas = !mostrarFormulas;

            if (mostrarFormulas)
            {
                this.Size = new Size(AnchoConFormulas, 550);
                MostrarPanelFormulas();
                btnFormulas.Text = "← CALC";
                btnFormulas.BackColor = Color.FromArgb(149, 165, 166);
            }
            else
            {
                OcultarPanelFormulas();
                btnFormulas.Text = "FÓRM";
                btnFormulas.BackColor = Color.FromArgb(155, 89, 182);
            }
        }

        private void MostrarPanelFormulas()
        {
            panelFormulas.Visible = true;
            panelFormulas.BringToFront();
            CargarCategorias();
            AgregarBotonSaberMas();
        }

        private void OcultarPanelFormulas()
        {
            panelFormulas.Visible = false;
            panelCalculadoraFormula.Visible = false;
            if (this.Width > AnchoNormal) this.Size = new Size(AnchoNormal, 550);
        }

        private void CargarCategorias()
        {
            var categorias = baseDeDatosFormulas.Select(f => f.Categoria).Distinct().ToArray();
            cmbCategoria.DataSource = categorias;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedItem == null) return;

            string cat = cmbCategoria.SelectedItem.ToString();
            var formulasFiltradas = baseDeDatosFormulas.Where(f => f.Categoria == cat).Select(f => f.Nombre).ToList();

            lstFormulas.Items.Clear();
            foreach (var nombre in formulasFiltradas) lstFormulas.Items.Add(nombre);
        }

        private void lstFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFormulas.SelectedItem != null)
            {
                string nombreFormula = lstFormulas.SelectedItem.ToString();
                formulaSeleccionadaActual = baseDeDatosFormulas.FirstOrDefault(f => f.Nombre == nombreFormula);

                if (formulaSeleccionadaActual != null)
                {
                    PrepararUIFormula(formulaSeleccionadaActual);
                }
            }
        }

        private void PrepararUIFormula(FormulaFinanciera formula)
        {
            panelCalculadoraFormula.Visible = true;

            lblFormula.Text = formula.Nombre + "  |  " + formula.EcuacionVisual;
            if (lblTeoria != null)
            {
                lblTeoria.Text = formula.DescripcionTeorica;
                lblEjemplo.Text = formula.EjemploPractico;
            }

            LimpiarCamposFormula();
            flowLayoutPanelCampos.Controls.Clear();

            foreach (var variable in formula.Variables)
            {
                CrearInputVariable(variable.Value, variable.Key);
            }
        }

        private void CrearInputVariable(string etiqueta, string idVariable)
        {
            Panel pnl = new Panel { Width = 440, Height = 60, Margin = new Padding(3) };

            Label lbl = new Label
            {
                Text = etiqueta + ":",
                Location = new Point(5, 5),
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            TextBox txt = new TextBox
            {
                Name = "txt_" + idVariable,
                Location = new Point(5, 25),
                Width = 200,
                Font = new Font("Segoe UI", 10F)
            };

            txt.KeyPress += (s, e) => {
                bool isDigit = char.IsDigit(e.KeyChar);
                bool isControl = char.IsControl(e.KeyChar);
                bool isDecimal = e.KeyChar == '.' || e.KeyChar == ',';
                bool isNegative = e.KeyChar == '-' && txt.Text.Length == 0;

                if (!(isDigit || isControl || isDecimal || isNegative))
                    e.Handled = true;

                if ((e.KeyChar == '.' || e.KeyChar == ',') && (txt.Text.Contains('.') || txt.Text.Contains(',')))
                    e.Handled = true;
            };

            pnl.Controls.Add(lbl);
            pnl.Controls.Add(txt);

            flowLayoutPanelCampos.Controls.Add(pnl);
        }

        private void btnCalcularFormula_Click(object sender, EventArgs e)
        {
            if (formulaSeleccionadaActual == null) return;

            try
            {
                var valores = new Dictionary<string, double>();
                var errores = new List<string>();

                foreach (Control pnl in flowLayoutPanelCampos.Controls)
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox txt && txt.Name.StartsWith("txt_"))
                        {
                            string idVar = txt.Name.Replace("txt_", "");
                            string texto = txt.Text.Trim();

                            if (string.IsNullOrEmpty(texto))
                            {
                                errores.Add($"El campo '{idVar}' está vacío");
                                continue;
                            }

                            texto = texto.Replace(",", ".");

                            if (double.TryParse(texto, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                            {
                                valores[idVar] = valor;
                            }
                            else
                            {
                                errores.Add($"Valor inválido en '{idVar}': {txt.Text}");
                            }
                        }
                    }
                }

                if (errores.Any())
                {
                    MessageBox.Show($"Errores encontrados:\n{string.Join("\n", errores)}",
                                  "Error de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (valores.Count != formulaSeleccionadaActual.Variables.Count)
                {
                    MessageBox.Show("Faltan valores requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                double resultado = formulaSeleccionadaActual.LogicaCalculo(valores);

                if (double.IsInfinity(resultado))
                    txtResultadoFormula.Text = "Infinito";
                else if (double.IsNaN(resultado))
                    txtResultadoFormula.Text = "Indefinido";
                else if (double.IsPositiveInfinity(resultado))
                    txtResultadoFormula.Text = "+∞";
                else if (double.IsNegativeInfinity(resultado))
                    txtResultadoFormula.Text = "-∞";
                else
                {

                    if (formulaSeleccionadaActual.Nombre.Contains("%") ||
                        formulaSeleccionadaActual.Nombre.Contains("Tasa") ||
                        formulaSeleccionadaActual.Nombre.Contains("Margen"))
                    {
                        txtResultadoFormula.Text = resultado.ToString("N2") + "%";
                    }
                    else
                    {
                        txtResultadoFormula.Text = resultado.ToString("N4");
                    }
                    Pantalla.Text = resultado.ToString();
                }
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: División por cero", "Error Matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultadoFormula.Text = "Indefinido";
            }
            catch (OverflowException)
            {
                MessageBox.Show("Error: Número demasiado grande", "Error Matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultadoFormula.Text = "Infinito";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtResultadoFormula.Text = "Error";
            }
        }

        private void btnLimpiarFormula_Click(object sender, EventArgs e)
        {
            LimpiarCamposFormula();
        }

        private void LimpiarCamposFormula()
        {
            foreach (Control pnl in flowLayoutPanelCampos.Controls)
            {
                foreach (Control ctrl in pnl.Controls)
                {
                    if (ctrl is TextBox txt) txt.Text = "";
                }
            }
            txtResultadoFormula.Text = "";
        }

        private void AgregarBotonSaberMas()
        {
            Button btnSaberMas = new Button();
            btnSaberMas.Text = "Saber Más";
            btnSaberMas.BackColor = Color.FromArgb(52, 152, 219);
            btnSaberMas.FlatStyle = FlatStyle.Flat;
            btnSaberMas.FlatAppearance.BorderSize = 0;
            btnSaberMas.ForeColor = Color.White;
            btnSaberMas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaberMas.Size = new Size(90, 30);
            btnSaberMas.Location = new Point(842, 5);
            btnSaberMas.Click += (s, e) =>
            {
                Información infoForm = new Información();
                infoForm.ShowDialog();
            };

            panelFormulas.Controls.Add(btnSaberMas);
            btnSaberMas.BringToFront();
        }
    }
}