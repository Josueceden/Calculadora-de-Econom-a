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
        private Dictionary<string, List<FormulaInfo>> formulasPorCategoria;
        private string categoriaActual = "";
        private int indiceFormulaActual = 0;

        public Información()
        {
            InitializeComponent();
            InicializarBaseDeDatosFormulas();
            CargarCategorias();
            MostrarInformacionActual();
        }

        private void InicializarBaseDeDatosFormulas()
        {
            formulasPorCategoria = new Dictionary<string, List<FormulaInfo>>();

            // INTERÉS SIMPLE Y COMPUESTO
            formulasPorCategoria.Add("Interés Simple y Compuesto", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Interés Simple",
                    Ecuacion = "I = P × i × N",
                    Descripcion = @"DEFINICIÓN:
                    El interés simple es aquel que se calcula únicamente sobre el capital inicial durante todo el período de la inversión o préstamo. Los intereses no se capitalizan.

                    NOTACIÓN ESTÁNDAR:
                    • I = Interés simple
                    • P = Capital inicial (Principal)
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    FÓRMULAS DERIVADAS:
                    • Interés: I = P × i × N
                    • Valor Futuro: F = P × (1 + i × N)
                    • Valor Presente: P = F / (1 + i × N)

                    EJEMPLO DETALLADO:
                    Si solicitas un préstamo de $1,000 al 5% anual por 3 años:
                    I = 1000 × 0.05 × 3 = $150
                    F = 1000 × (1 + 0.05 × 3) = $1,150

                    APLICACIONES:
                    • Préstamos a corto plazo
                    • Inversiones de baja complejidad
                    • Cálculos financieros básicos",
                    Ejemplo = "Préstamo: $1,000 | Tasa: 5% anual | Tiempo: 3 años\nInterés = $150 | Total a pagar = $1,150"
                },
                new FormulaInfo
                {
                    Nombre = "Valor Futuro (Interés Simple)",
                    Ecuacion = "F = P × (1 + i × N)",
                    Descripcion = @"DEFINICIÓN:
                    El valor futuro de una inversión calculada con interés simple representa la cantidad total que se tendrá al final del período, incluyendo el capital inicial más los intereses generados.

                    NOTACIÓN ESTÁNDAR:
                    • F = Valor futuro
                    • P = Valor presente (Capital inicial)
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    CARACTERÍSTICAS:
                    • Los intereses no se reinvierten
                    • El crecimiento es lineal
                    • Ideal para períodos cortos

                    EJEMPLO DETALLADO:
                    Inversión inicial: $2,000
                    Tasa de interés: 8% anual
                    Plazo: 4 años

                    Cálculo:
                    F = 2000 × (1 + 0.08 × 4)
                    F = 2000 × (1 + 0.32)
                    F = 2000 × 1.32 = $2,640

                    APLICACIONES:
                    • Certificados de depósito
                    • Inversiones conservadoras
                    • Préstamos personales",
                    Ejemplo = "Inversión: $2,000 | Tasa: 8% anual | Tiempo: 4 años\nValor Futuro = $2,640"
                }
            });

            // FACTORES DE SERIE UNIFORME
            formulasPorCategoria.Add("Factores de Serie Uniforme", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Valor Futuro de Anualidad (F/A)",
                    Ecuacion = "F = A × [(1 + i)ᴺ - 1] / i",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el valor futuro de una serie de pagos uniformes (anualidades) realizados al final de cada período.

                    NOTACIÓN ESTÁNDAR:
                    • F = Valor futuro de la anualidad
                    • A = Monto de la anualidad (pago periódico)
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (F/A, i%, N) = [(1 + i)ᴺ - 1] / i

                    FÓRMULA COMPLETA:
                    F = A × (F/A, i%, N)

                    EJEMPLO DETALLADO:
                    Ahorras $5,000 anuales al 6% de interés por 5 años:

                    Factor (F/A, 6%, 5):
                    = [(1 + 0.06)⁵ - 1] / 0.06
                    = [1.338225 - 1] / 0.06
                    = 0.338225 / 0.06 = 5.637093

                    F = 5000 × 5.637093 = $28,185.47

                    APLICACIONES:
                    • Planes de ahorro sistemático
                    • Fondos de pensiones
                    • Metas de ahorro a largo plazo",
                    Ejemplo = "Ahorro anual: $5,000 | Tasa: 6% | 5 años\nValor Futuro = $28,185.47"
                },
                new FormulaInfo
                {
                    Nombre = "Valor Presente de Anualidad (P/A)",
                    Ecuacion = "P = A × [1 - (1 + i)⁻ᴺ] / i",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el valor presente de una serie de pagos uniformes futuros, descontados a la tasa de interés apropiada.

                    NOTACIÓN ESTÁNDAR:
                    • P = Valor presente de la anualidad
                    • A = Monto de la anualidad (pago periódico)
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (P/A, i%, N) = [1 - (1 + i)⁻ᴺ] / i

                    FÓRMULA COMPLETA:
                    P = A × (P/A, i%, N)

                    EJEMPLO DETALLADO:
                    Recibirás $3,000 anuales por 10 años al 8% de interés:

                    Factor (P/A, 8%, 10):
                    = [1 - (1 + 0.08)⁻¹⁰] / 0.08
                    = [1 - 1/(1.08)¹⁰] / 0.08
                    = [1 - 1/2.158925] / 0.08
                    = [1 - 0.463193] / 0.08
                    = 0.536807 / 0.08 = 6.710088

                    P = 3000 × 6.710088 = $20,130.26

                    APLICACIONES:
                    • Valuación de pensiones
                    • Análisis de préstamos
                    • Evaluación de inversiones con flujos constantes",
                    Ejemplo = "Ingreso anual: $3,000 | Tasa: 8% | 10 años\nValor Presente = $20,130.26"
                },
                new FormulaInfo
                {
                    Nombre = "Fondo de Amortización (A/F)",
                    Ecuacion = "A = F × i / [(1 + i)ᴺ - 1]",
                    Descripcion = @"DEFINICIÓN:
                    Determina el depósito periódico uniforme necesario para acumular un monto futuro específico.

                    NOTACIÓN ESTÁNDAR:
                    • A = Anualidad (depósito periódico)
                    • F = Valor futuro deseado
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (A/F, i%, N) = i / [(1 + i)ᴺ - 1]

                    FÓRMULA COMPLETA:
                    A = F × (A/F, i%, N)

                    EJEMPLO DETALLADO:
                    Necesitas acumular $50,000 en 8 años al 7% de interés:

                    Factor (A/F, 7%, 8):
                    = 0.07 / [(1 + 0.07)⁸ - 1]
                    = 0.07 / [1.718186 - 1]
                    = 0.07 / 0.718186 = 0.097468

                    A = 50000 × 0.097468 = $4,873.40

                    APLICACIONES:
                    • Fondos para educación universitaria
                    • Ahorro para enganche de vivienda
                    • Planes de jubilación",
                    Ejemplo = "Meta: $50,000 | Tasa: 7% | 8 años\nAhorro anual = $4,873.40"
                },
                new FormulaInfo
                {
                    Nombre = "Recuperación de Capital (A/P)",
                    Ecuacion = "A = P × [i(1 + i)ᴺ] / [(1 + i)ᴺ - 1]",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el pago periódico uniforme necesario para amortizar un préstamo, incluyendo intereses y capital.

                    NOTACIÓN ESTÁNDAR:
                    • A = Anualidad (pago periódico)
                    • P = Valor presente (monto del préstamo)
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (A/P, i%, N) = [i(1 + i)ᴺ] / [(1 + i)ᴺ - 1]

                    FÓRMULA COMPLETA:
                    A = P × (A/P, i%, N)

                    EJEMPLO DETALLADO:
                    Préstamo de $25,000 al 12% anual por 6 años:

                    Factor (A/P, 12%, 6):
                    = [0.12 × (1.12)⁶] / [(1.12)⁶ - 1]
                    = [0.12 × 1.973823] / [1.973823 - 1]
                    = 0.236859 / 0.973823 = 0.243228

                    A = 25000 × 0.243228 = $6,080.70

                    APLICACIONES:
                    • Cálculo de cuotas de préstamos
                    • Arrendamiento financiero
                    • Amortización de deudas",
                    Ejemplo = "Préstamo: $25,000 | Tasa: 12% | 6 años\nCuota anual = $6,080.70"
                }
            });

            // INGRESOS Y CAPACIDAD
            formulasPorCategoria.Add("Ingresos y Capacidad", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Ingreso Total",
                    Ecuacion = "IT = Precio × Cantidad",
                    Descripcion = @"DEFINICIÓN:
                    El ingreso total representa el valor monetario total recibido por la venta de bienes o servicios antes de deducir cualquier costo.

                    NOTACIÓN ESTÁNDAR:
                    • IT = Ingreso Total
                    • Precio = Precio unitario de venta
                    • Cantidad = Número de unidades vendidas

                    CARACTERÍSTICAS:
                    • Medida fundamental del tamaño de operación
                    • Base para calcular otros indicadores financieros
                    • No considera costos ni gastos

                    EJEMPLO DETALLADO:
                    Vendes 100 productos a $15 cada uno:
                    IT = 15 × 100 = $1,500

                    APLICACIONES:
                    • Análisis de ventas
                    • Proyecciones de ingresos
                    • Cálculo de punto de equilibrio",
                    Ejemplo = "Precio: $15 | Cantidad: 100\nIngreso Total = $1,500"
                },
                new FormulaInfo
                {
                    Nombre = "Ingreso Neto",
                    Ecuacion = "IN = Ingreso Bruto - Gastos",
                    Descripcion = @"DEFINICIÓN:
                    El ingreso neto es la cantidad que queda después de deducir todos los gastos, devoluciones, descuentos y costos del ingreso bruto.

                    NOTACIÓN ESTÁNDAR:
                    • IN = Ingreso Neto
                    • IB = Ingreso Bruto
                    • G = Gastos Totales

                    DIFERENCIAS CLAVE:
                    • Ingreso Bruto: Total de ventas sin deducciones
                    • Ingreso Neto: Lo que realmente gana la empresa

                    EJEMPLO DETALLADO:
                    Ingresos brutos: $5,000
                    Gastos totales: $1,200
                    IN = 5000 - 1200 = $3,800

                    APLICACIONES:
                    • Cálculo de utilidades
                    • Análisis de rentabilidad
                    • Estados financieros",
                    Ejemplo = "Ingreso Bruto: $5,000 | Gastos: $1,200\nIngreso Neto = $3,800"
                },
                new FormulaInfo
                {
                    Nombre = "Utilización",
                    Ecuacion = "U = (Cap. Real / Cap. Diseño) × 100",
                    Descripcion = @"DEFINICIÓN:
                    La utilización mide el porcentaje de uso de la capacidad máxima teórica de diseño de una instalación o equipo.

                    NOTACIÓN ESTÁNDAR:
                    • U = Utilización (%)
                    • Cap. Real = Capacidad Real utilizada
                    • Cap. Diseño = Capacidad Máxima de Diseño

                    INTERPRETACIÓN:
                    • 100%: Uso máximo teórico
                    • <100%: Capacidad subutilizada
                    • >100%: Sobrecarga (puede ser insostenible)

                    EJEMPLO DETALLADO:
                    Produces 800 unidades
                    Capacidad máxima de diseño: 1,000 unidades
                    U = (800 / 1000) × 100 = 80%

                    APLICACIONES:
                    • Gestión de capacidad
                    • Planificación de producción
                    • Análisis de eficiencia operativa",
                    Ejemplo = "Cap. Real: 800 | Cap. Diseño: 1,000\nUtilización = 80%"
                },
                new FormulaInfo
                {
                    Nombre = "Eficiencia",
                    Ecuacion = "E = (Cap. Real / Cap. Efectiva) × 100",
                    Descripcion = @"DEFINICIÓN:
                    La eficiencia mide el rendimiento real comparado con lo que realmente se espera producir (capacidad efectiva), considerando limitaciones prácticas.

                    NOTACIÓN ESTÁNDAR:
                    • E = Eficiencia (%)
                    • Cap. Real = Capacidad Real lograda
                    • Cap. Efectiva = Capacidad Efectiva esperada

                    DIFERENCIA CON UTILIZACIÓN:
                    • Utilización: vs. capacidad teórica máxima
                    • Eficiencia: vs. capacidad realista esperada

                    EJEMPLO DETALLADO:
                    Produces 750 unidades
                    Capacidad efectiva esperada: 900 unidades
                    E = (750 / 900) × 100 = 83.33%

                    APLICACIONES:
                    • Evaluación de desempeño
                    • Mejora continua
                    • Establecimiento de metas realistas",
                    Ejemplo = "Cap. Real: 750 | Cap. Efectiva: 900\nEficiencia = 83.33%"
                }
            });

            // PUNTO DE EQUILIBRIO Y MÁRGENES
            formulasPorCategoria.Add("Punto de Equilibrio y Margenes", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Punto de Equilibrio (Unidades)",
                    Ecuacion = "PE = CF / (PVU - CVU)",
                    Descripcion = @"DEFINICIÓN:
                    El punto de equilibrio es el número de unidades que deben venderse para cubrir todos los costos, donde la utilidad es cero.

                    NOTACIÓN ESTÁNDAR:
                    • PE = Punto de Equilibrio en unidades
                    • CF = Costos Fijos Totales
                    • PVU = Precio de Venta Unitario
                    • CVU = Costo Variable Unitario

                    INTERPRETACIÓN:
                    • Por debajo del PE: Pérdidas
                    • En el PE: Cero ganancias/pérdidas
                    • Por encima del PE: Ganancias

                    EJEMPLO DETALLADO:
                    Costos fijos: $2,000
                    Precio venta unitario: $50
                    Costo variable unitario: $30
                    PE = 2000 / (50 - 30) = 2000 / 20 = 100 unidades

                    APLICACIONES:
                    • Planificación de producción
                    • Análisis de rentabilidad
                    • Toma de decisiones de precios",
                    Ejemplo = "CF: $2,000 | PVU: $50 | CVU: $30\nPunto de Equilibrio = 100 unidades"
                },
                new FormulaInfo
                {
                    Nombre = "Margen de Beneficio Neto",
                    Ecuacion = "Margen % = (Beneficio / Ingresos) × 100",
                    Descripcion = @"DEFINICIÓN:
                    El margen de beneficio neto indica qué porcentaje de cada dólar de ingresos se convierte en beneficio real después de todos los gastos.

                    NOTACIÓN ESTÁNDAR:
                    • Margen % = Porcentaje de margen neto
                    • Beneficio = Beneficio Neto
                    • Ingresos = Ingresos Totales

                    INTERPRETACIÓN:
                    • Alto margen: Operación eficiente
                    • Bajo margen: Posibles problemas de costos
                    • Negativo: Pérdidas operativas

                    EJEMPLO DETALLADO:
                    Ganancia neta: $1,500
                    Ingresos totales: $5,000
                    Margen = (1500 / 5000) × 100 = 30%

                    APLICACIONES:
                    • Análisis de rentabilidad
                    • Comparación entre empresas
                    • Evaluación de estrategias de precios",
                    Ejemplo = "Beneficio: $1,500 | Ingresos: $5,000\nMargen Neto = 30%"
                },
                new FormulaInfo
                {
                    Nombre = "Precio de Venta (Mark-up)",
                    Ecuacion = "P = CostoU × (1 + Margen)",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el precio de venta basado en el costo unitario y un porcentaje de margen de ganancia deseado.

                    NOTACIÓN ESTÁNDAR:
                    • P = Precio de Venta
                    • CostoU = Costo Unitario
                    • Margen = Porcentaje de margen (en decimal)

                    DIFERENCIA CON MARGEN:
                    • Mark-up: Porcentaje sobre el costo
                    • Margen: Porcentaje sobre el precio de venta

                    EJEMPLO DETALLADO:
                    Costo unitario: $80
                    Margen deseado: 25% (0.25)
                    P = 80 × (1 + 0.25) = 80 × 1.25 = $100

                    APLICACIONES:
                    • Estrategias de precios
                    • Análisis de competitividad
                    • Planificación de márgenes",
                    Ejemplo = "Costo Unitario: $80 | Margen: 25%\nPrecio Venta = $100"
                }
            });

            // COSTOS Y VARIACIONES
            formulasPorCategoria.Add("Costos y Variaciones", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Costo Fijo Unitario",
                    Ecuacion = "CFu = CF Total / Unidades",
                    Descripcion = @"DEFINICIÓN:
                    El costo fijo unitario representa la porción de costos fijos que se asigna a cada unidad producida.

                    NOTACIÓN ESTÁNDAR:
                    • CFu = Costo Fijo Unitario
                    • CF Total = Costos Fijos Totales
                    • Unidades = Número de unidades producidas

                    COMPORTAMIENTO:
                    • Disminuye a medida que aumenta la producción
                    • Es constante por unidad pero variable en total
                    • Importante para decisiones de precios

                    EJEMPLO DETALLADO:
                    Costos fijos totales: $5,000
                    Unidades producidas: 1,000
                    CFu = 5000 / 1000 = $5 por unidad

                    APLICACIONES:
                    • Análisis de costos
                    • Decisiones de precios
                    • Planificación de la producción",
                    Ejemplo = "CF Total: $5,000 | Unidades: 1,000\nCosto Fijo Unitario = $5"
                },
                new FormulaInfo
                {
                    Nombre = "Variación Total",
                    Ecuacion = "VT = Costo Real - Costo Estándar",
                    Descripcion = @"DEFINICIÓN:
                    La variación total mide la diferencia neta entre lo que realmente costó producir y lo que debería haber costado según los estándares.

                    NOTACIÓN ESTÁNDAR:
                    • VT = Variación Total
                    • Costo Real = Costo realmente incurrido
                    • Costo Estándar = Costo esperado según estándares

                    INTERPRETACIÓN:
                    • VT > 0: Costo mayor al esperado (desfavorable)
                    • VT < 0: Costo menor al esperado (favorable)
                    • VT = 0: En línea con estándares

                    EJEMPLO DETALLADO:
                    Costo real: $4,500
                    Costo estándar: $4,000
                    VT = 4500 - 4000 = $500 (desfavorable)

                    APLICACIONES:
                    • Control de costos
                    • Análisis de desempeño
                    • Mejora de procesos",
                    Ejemplo = "Costo Real: $4,500 | Costo Estándar: $4,000\nVariación Total = $500"
                },
                new FormulaInfo
                {
                    Nombre = "Variación Precio",
                    Ecuacion = "VP = (P.Real - P.Std) × Cant.Real",
                    Descripcion = @"DEFINICIÓN:
                    La variación de precio cuantifica cuánto de la variación total se debe específicamente a diferencias en los precios de los insumos.

                    NOTACIÓN ESTÁNDAR:
                    • VP = Variación de Precio
                    • P.Real = Precio Real pagado
                    • P.Std = Precio Estándar esperado
                    • Cant.Real = Cantidad Real utilizada

                    ANÁLISIS:
                    • Aísla el efecto de cambios en precios
                    • Útil para negociación con proveedores
                    • Complementa el análisis de variaciones

                    EJEMPLO DETALLADO:
                    Precio real: $12
                    Precio estándar: $10
                    Cantidad real: 200 unidades
                    VP = (12 - 10) × 200 = 2 × 200 = $400

                    APLICACIONES:
                    • Control de compras
                    • Análisis de proveedores
                    • Gestión de costos de materiales",
                    Ejemplo = "P.Real: $12 | P.Std: $10 | Cantidad: 200\nVariación Precio = $400"
                }
            });

            // INTERÉS Y CAPITALIZACIÓN
            formulasPorCategoria.Add("Interés y Capitalización", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Valor Futuro (Compuesto)",
                    Ecuacion = "VF = VP × (1 + i)^n",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el valor futuro de una inversión considerando el interés compuesto, donde los intereses se reinvierten y generan más intereses.

                    NOTACIÓN ESTÁNDAR:
                    • VF = Valor futuro
                    • VP = Valor presente (Capital inicial)
                    • i = Tasa de interés por período (en decimal)
                    • n = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (F/P, i%, N) = (1 + i)^n

                    FÓRMULA COMPLETA:
                    F = P × (F/P, i%, N)

                    EJEMPLO DETALLADO:
                    Inversión de $1,000 al 5% anual compuesto por 3 años:

                    Factor (F/P, 5%, 3):
                    = (1 + 0.05)³ = 1.157625

                    F = 1000 × 1.157625 = $1,157.63

                    COMPARACIÓN CON INTERÉS SIMPLE:
                    • Interés simple: $1,150.00
                    • Interés compuesto: $1,157.63
                    • Diferencia: $7.63

                    APLICACIONES:
                    • Inversiones a largo plazo
                    • Planes de ahorro
                    • Crecimiento de capital",
                    Ejemplo = "Inversión: $1,000 | Tasa: 5% compuesto | 3 años\nValor Futuro = $1,157.63"
                },
                new FormulaInfo
                {
                    Nombre = "Tasa Efectiva Anual (TEA)",
                    Ecuacion = "TEA = [(1 + j/m)ᵐ - 1] × 100%",
                    Descripcion = @"DEFINICIÓN:
                    Calcula la tasa de interés efectiva anual cuando la capitalización ocurre más de una vez al año.

                    NOTACIÓN ESTÁNDAR:
                    • TEA = Tasa Efectiva Anual (%)
                    • j = Tasa nominal anual (en decimal)
                    • m = Número de capitalizaciones por año

                    CASOS ESPECIALES:
                    • Capitalización mensual: m = 12
                    • Capitalización trimestral: m = 4
                    • Capitalización semestral: m = 2

                    EJEMPLO DETALLADO:
                    Tasa nominal del 12% con capitalización mensual:

                    j = 0.12, m = 12
                    TEA = [(1 + 0.12/12)¹² - 1] × 100%
                    = [(1 + 0.01)¹² - 1] × 100%
                    = [1.126825 - 1] × 100% = 12.6825%

                    COMPARACIÓN:
                    • Tasa nominal: 12.00%
                    • Tasa efectiva: 12.68%

                    APLICACIONES:
                    • Comparación de productos financieros
                    • Análisis de rendimiento real
                    • Decisiones de inversión",
                    Ejemplo = "Tasa nominal: 12% | Capitalización: mensual\nTEA = 12.6825%"
                },
                new FormulaInfo
                {
                    Nombre = "Interés Continuo",
                    Ecuacion = "i = (e^r) - 1",
                    Descripcion = @"DEFINICIÓN:
                    El interés continuo representa la capitalización en cada instante infinitesimal. Es el límite cuando el número de capitalizaciones por período tiende a infinito.

                    NOTACIÓN ESTÁNDAR:
                    • i = Tasa de interés efectiva
                    • r = Tasa de interés nominal continua (en decimal)
                    • e = Base del logaritmo natural (aproximadamente 2.71828)

                    CARACTERÍSTICAS:
                    • Capitalización instantánea
                    • Representa el máximo crecimiento posible
                    • Usado en modelos financieros avanzados

                    EJEMPLO DETALLADO:
                    Tasa instantánea: 8% (r = 0.08)
                    i = (e^0.08) - 1 = (2.71828^0.08) - 1 ≈ 0.083287
                    i = 8.3287%

                    APLICACIONES:
                    • Modelos financieros avanzados
                    • Cálculo de valor presente y futuro continuo
                    • Opciones y derivados financieros",
                    Ejemplo = "Tasa instantánea: 8%\nTasa Efectiva = 8.3287%"
                },
                new FormulaInfo
                {
                    Nombre = "Valor Presente (P/F)",
                    Ecuacion = "P = F × (1 + i)⁻ⁿ",
                    Descripcion = @"DEFINICIÓN:
                    Calcula el valor presente de un monto futuro, descontándolo a una tasa de interés específica.

                    NOTACIÓN ESTÁNDAR:
                    • P = Valor presente
                    • F = Valor futuro
                    • i = Tasa de interés por período (en decimal)
                    • N = Número de períodos

                    NOTACIÓN DE INGENIERÍA:
                    (P/F, i%, N) = (1 + i)⁻ᴺ

                    FÓRMULA COMPLETA:
                    P = F × (P/F, i%, N)

                    EJEMPLO DETALLADO:
                    Necesitas $20,000 en 5 años, con tasa de descuento del 6%:

                    Factor (P/F, 6%, 5):
                    = (1 + 0.06)⁻⁵ = 1/(1.06)⁵
                    = 1/1.338225 = 0.747258

                    P = 20000 × 0.747258 = $14,945.16

                    INTERPRETACIÓN:
                    Necesitas invertir $14,945.16 hoy al 6% anual para tener $20,000 en 5 años.

                    APLICACIONES:
                    • Valuación de bonos
                    • Análisis de inversiones
                    • Planificación financiera",
                    Ejemplo = "Meta futura: $20,000 | Tasa: 6% | 5 años\nInversión requerida = $14,945.16"
                }
            });

            // MODELOS PARAMÉTRICOS
            formulasPorCategoria.Add("Modelos Paramétricos", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Estimación Lineal Simple",
                    Ecuacion = "Costo = a + b × X",
                    Descripcion = @"DEFINICIÓN:
                    Modelo de estimación de costos que supone una relación lineal entre el costo y una variable independiente.

                    NOTACIÓN ESTÁNDAR:
                    • a = Costo fijo (intercepto)
                    • b = Costo variable por unidad (pendiente)
                    • X = Variable independiente (ej. horas, unidades, área)

                    CARACTERÍSTICAS:
                    • Simple y fácil de aplicar
                    • Requiere datos históricos confiables
                    • Asume relación lineal constante

                    EJEMPLO DETALLADO:
                    Costo base (fijo): $5,000
                    Costo variable: $200 por m²
                    Construyes 120 m²

                    Costo = 5000 + 200 × 120 = 5000 + 24000 = $29,000

                    APLICACIONES:
                    • Estimación de costos de construcción
                    • Presupuestos preliminares
                    • Análisis de costos en proyectos",
                    Ejemplo = "Costo base: $5,000 | Factor: $200/m² | Variable: 120 m²\nCosto Total = $29,000"
                },
                new FormulaInfo
                {
                    Nombre = "Costo por Índices",
                    Ecuacion = "C.Real = C.Base × (Índice/100)",
                    Descripcion = @"DEFINICIÓN:
                    Ajusta un costo histórico a valor presente usando índices de inflación o factores de actualización.

                    NOTACIÓN ESTÁNDAR:
                    • C.Real = Costo actualizado
                    • C.Base = Costo base histórico
                    • Índice = Factor de actualización

                    TIPOS DE ÍNDICES:
                    • Índices de precios al consumidor
                    • Índices de costos de construcción
                    • Índices sectoriales específicos

                    EJEMPLO DETALLADO:
                    Costo histórico: $8,000
                    Índice de inflación: 1.05 (5% de aumento)
                    C.Real = 8000 × 1.05 = $8,400

                    APLICACIONES:
                    • Actualización de presupuestos
                    • Análisis de costos históricos
                    • Comparación de costos en el tiempo",
                    Ejemplo = "Costo Base: $8,000 | Índice: 1.05\nCosto Actualizado = $8,400"
                }
            });

            // EVALUACIÓN DE PROYECTOS
            formulasPorCategoria.Add("Evaluación de Proyectos", new List<FormulaInfo>
            {
                new FormulaInfo
                {
                    Nombre = "Valor Presente Neto (VPN)",
                    Ecuacion = "VPN = -P + A(P/A,i,N)",
                    Descripcion = @"DEFINICIÓN:
                    Método para evaluar la rentabilidad de un proyecto, comparando el valor presente de los flujos de efectivo futuros con la inversión inicial.

                    NOTACIÓN ESTÁNDAR:
                    • VPN = Valor Presente Neto
                    • P = Inversión inicial
                    • A = Flujo de efectivo anual neto
                    • i = TMAR (Tasa Mínima Aceptable de Rendimiento)
                    • N = Vida del proyecto

                    CRITERIO DE DECISIÓN:
                    • VPN > 0: Proyecto aceptable (crea valor)
                    • VPN = 0: Proyecto indiferente
                    • VPN < 0: Proyecto rechazado

                    EJEMPLO DETALLADO:
                    Inversión: $10,000
                    Flujos anuales: $3,000 por 5 años
                    TMAR: 10%

                    Factor (P/A, 10%, 5) = 3.790787
                    VPN = -10000 + 3000 × 3.790787
                    = -10000 + 11372.36 = $1,372.36

                    INTERPRETACIÓN:
                    El proyecto genera $1,372.36 de valor por encima del rendimiento mínimo requerido.

                    APLICACIONES:
                    • Evaluación de proyectos de inversión
                    • Análisis de expansión empresarial
                    • Toma de decisiones financieras",
                    Ejemplo = "Inversión: $10,000 | Flujos: $3,000/año | TMAR: 10%\nVPN = $1,372.36"
                },
                new FormulaInfo
                {
                    Nombre = "Periodo de Recuperación Simple",
                    Ecuacion = "PRI = Inversión / Flujo Anual",
                    Descripcion = @"DEFINICIÓN:
                    El período de recuperación simple es el tiempo requerido para que los flujos de efectivo netos de un proyecto recuperen la inversión inicial.

                    NOTACIÓN ESTÁNDAR:
                    • PRI = Período de Recuperación Simple
                    • P = Inversión Inicial
                    • A = Flujo de Efectivo Anual Neto

                    CARACTERÍSTICAS:
                    • Simple de calcular
                    • No considera el valor del dinero en el tiempo
                    • Útil para análisis preliminar

                    EJEMPLO DETALLADO:
                    Inversión inicial: $15,000
                    Flujo de efectivo anual neto: $4,000
                    PRI = 15000 / 4000 = 3.75 años

                    INTERPRETACIÓN:
                    Se necesitan 3.75 años (aproximadamente 3 años y 9 meses) para recuperar la inversión.

                    APLICACIONES:
                    • Evaluación rápida de proyectos
                    • Análisis de riesgo
                    • Proyectos con flujos constantes",
                    Ejemplo = "Inversión: $15,000 | Flujo Anual: $4,000\nPeríodo de Recuperación = 3.75 años"
                },
                new FormulaInfo
                {
                    Nombre = "Relación Beneficio/Costo",
                    Ecuacion = "B/C = VP Beneficios / VP Costos",
                    Descripcion = @"DEFINICIÓN:
                    Ratio que compara el valor presente de los beneficios con el valor presente de los costos de un proyecto.

                    NOTACIÓN ESTÁNDAR:
                    • B/C = Relación Beneficio/Costo
                    • VP Beneficios = Valor presente de todos los beneficios
                    • VP Costos = Valor presente de todos los costos

                    CRITERIO DE DECISIÓN:
                    • B/C > 1: Proyecto económicamente viable
                    • B/C = 1: Punto de equilibrio
                    • B/C < 1: Proyecto no recomendable

                    EJEMPLO DETALLADO:
                    VP Beneficios: $50,000
                    VP Costos: $40,000
                    B/C = 50000 / 40000 = 1.25

                    INTERPRETACIÓN:
                    Por cada $1 invertido, se generan $1.25 en beneficios descontados.

                    APLICACIONES:
                    • Evaluación de proyectos públicos
                    • Análisis de inversiones sociales
                    • Priorización de proyectos",
                    Ejemplo = "VP Beneficios: $50,000 | VP Costos: $40,000\nB/C = 1.25"
                }
            });
        }

        private void CargarCategorias()
        {
            listBoxCategorias.Items.Clear();
            foreach (string categoria in formulasPorCategoria.Keys)
            {
                listBoxCategorias.Items.Add(categoria);
            }

            if (listBoxCategorias.Items.Count > 0)
            {
                listBoxCategorias.SelectedIndex = 0;
                categoriaActual = listBoxCategorias.SelectedItem.ToString();
                CargarFormulasDeCategoria();
            }
        }

        private void CargarFormulasDeCategoria()
        {
            listBoxFormulas.Items.Clear();
            if (formulasPorCategoria.ContainsKey(categoriaActual))
            {
                foreach (FormulaInfo formula in formulasPorCategoria[categoriaActual])
                {
                    listBoxFormulas.Items.Add(formula.Nombre);
                }

                if (listBoxFormulas.Items.Count > 0)
                {
                    listBoxFormulas.SelectedIndex = 0;
                    indiceFormulaActual = 0;
                    MostrarInformacionActual();
                }
            }
        }

        private void MostrarInformacionActual()
        {
            if (categoriaActual == "" || !formulasPorCategoria.ContainsKey(categoriaActual))
                return;

            if (indiceFormulaActual >= 0 && indiceFormulaActual < formulasPorCategoria[categoriaActual].Count)
            {
                FormulaInfo formula = formulasPorCategoria[categoriaActual][indiceFormulaActual];

                lblTituloTermino.Text = formula.Nombre;
                lblEcuacion.Text = formula.Ecuacion;
                txtDescripcion.Text = formula.Descripcion;
                txtEjemplo.Text = formula.Ejemplo;

                lblContador.Text = $"{indiceFormulaActual + 1} / {formulasPorCategoria[categoriaActual].Count}";
                Atras.Enabled = (indiceFormulaActual > 0);
                Adelante.Enabled = (indiceFormulaActual < formulasPorCategoria[categoriaActual].Count - 1);
            }
        }

        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCategorias.SelectedItem != null)
            {
                categoriaActual = listBoxCategorias.SelectedItem.ToString();
                CargarFormulasDeCategoria();
            }
        }

        private void listBoxFormulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFormulas.SelectedIndex >= 0)
            {
                indiceFormulaActual = listBoxFormulas.SelectedIndex;
                MostrarInformacionActual();
            }
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            if (indiceFormulaActual > 0)
            {
                indiceFormulaActual--;
                listBoxFormulas.SelectedIndex = indiceFormulaActual;
                MostrarInformacionActual();
            }
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            if (formulasPorCategoria.ContainsKey(categoriaActual) &&
                indiceFormulaActual < formulasPorCategoria[categoriaActual].Count - 1)
            {
                indiceFormulaActual++;
                listBoxFormulas.SelectedIndex = indiceFormulaActual;
                MostrarInformacionActual();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Información_Load(object sender, EventArgs e)
        {
            this.Text = "Información - Conceptos Financieros Detallados";
        }
    }

    public class FormulaInfo
    {
        public string Nombre { get; set; }
        public string Ecuacion { get; set; }
        public string Descripcion { get; set; }
        public string Ejemplo { get; set; }
    }
}