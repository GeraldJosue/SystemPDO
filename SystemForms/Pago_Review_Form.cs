using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Pago_Review_Form : Form
    {
        Pago pago;
        Decimal bruto_base;
        Colaborador c;
        BusinessLogic.Configuracion config;
        Int32 tipo;
        Pago_Review parent;
        public Pago_Review_Form(Pago pago, Colaborador c, Pago_Review parent)
        {
            InitializeComponent();
            this.pago = pago;
            bruto_base = pago.SalarioBruto;
            this.c = c;
            config = new BusinessLogic.Configuracion().obtener_Configuracion();
            tipo = c.Tipo_planilla;
            this.parent = parent;
            setear_datos();
        }

        public void setear_datos()
        {
            dg_pago_detalle.Rows.Add(pago.Id, c.Nombre + " " + c.Apellido, pago.FechaPago.ToShortDateString(), pago.HorasLaboradas, pago.HorasExtra, pago.Id_planilla);
            dg_ingresos.Rows.Add(pago.Bono.ToString("N2"), pago.Vacaciones.ToString("N2"), pago.Aguinaldo.ToString("N2"));
            dg_deducciones.Rows.Add(pago.Adelanto.ToString("N2"), pago.Seguro, pago.Rebajo.ToString("N2"));
            dg_totales.Rows.Add(pago.SalarioBruto.ToString("N2"), pago.SalarioNeto.ToString("N2"));
            rb_activo.Checked = pago.EstadoPago;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            guardar_cambios();       
            parent.salvar_cambios(pago);
            this.Close();
        }

        private void guardar_cambios()
        {
            pago.Bono = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["bono"].Value);
            pago.Vacaciones = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["vacaciones"].Value);
            pago.Aguinaldo = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["aguinaldo"].Value);

            pago.Adelanto = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["adelanto"].Value);
            pago.Seguro = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["seguro"].Value);
            pago.Rebajo = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["rebajo"].Value);

            pago.SalarioBruto = Convert.ToDecimal(dg_totales.Rows[0].Cells["bruto"].Value);
            pago.SalarioNeto = Convert.ToDecimal(dg_totales.Rows[0].Cells["neto"].Value);

            pago.EstadoPago = rb_activo.Checked;
        }

        public void calcular_salarios()
        {

            dg_totales.Rows[0].Cells["bruto"].Value = pago.SalarioBruto.ToString("N2");
            dg_deducciones.Rows[0].Cells["seguro"].Value = pago.Seguro.ToString("N2");
            dg_totales.Rows[0].Cells["neto"].Value = pago.SalarioNeto.ToString("N2");

        }

        public void calcular_detalles()
        {
            pago.Bono = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["bono"].Value);
            pago.Vacaciones = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["vacaciones"].Value);
            pago.Aguinaldo = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["aguinaldo"].Value);

            pago.Rebajo = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["rebajo"].Value);
            pago.Adelanto = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["adelanto"].Value);
            
            Decimal bruto_original = (pago.HorasLaboradas * c.Precio) + (pago.HorasExtra * (c.Precio * Convert.ToDecimal(1.5)));

            if (bruto_original != pago.SalarioBruto)
            {
                bruto_base = bruto_original;
            }

            pago.SalarioBruto = bruto_base + pago.Bono + pago.Vacaciones + pago.Aguinaldo;
            pago.Seguro = (pago.SalarioBruto * (tipo == 14 ? (config.Porcentaje_Seguro / 2) : config.Porcentaje_Seguro)) / 100;
            pago.SalarioNeto = pago.SalarioBruto - pago.Seguro - pago.Adelanto - pago.Rebajo;

            calcular_salarios();
        }

        private void dg_ingresos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            calcular_detalles();
        }

        private void dg_deducciones_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            calcular_detalles();

        }

    
    }
}
