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
        String nombre;
        Pago_Review parent;
        public Pago_Review_Form(Pago pago, String nombre, Pago_Review parent)
        {
            InitializeComponent();
            this.pago = pago;
            bruto_base = pago.SalarioBruto;
            this.nombre = nombre;
            this.parent = parent;
            setear_datos();
        }

        public void setear_datos()
        {
            dg_pago_detalle.Rows.Add(pago.Id, nombre, pago.FechaPago.ToShortDateString(), pago.HorasLaboradas, pago.HorasExtra, pago.Id_planilla);
            dg_ingresos.Rows.Add(pago.Bono, pago.Vacaciones, pago.Aguinaldo);
            dg_deducciones.Rows.Add(pago.Adelanto, pago.Seguro, pago.Rebajo);
            dg_totales.Rows.Add(pago.SalarioBruto, pago.SalarioNeto);
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

            dg_totales.Rows[0].Cells["bruto"].Value = pago.SalarioBruto;
            dg_deducciones.Rows[0].Cells["seguro"].Value = pago.Seguro;
            dg_totales.Rows[0].Cells["neto"].Value = pago.SalarioNeto;

        }

        public void calcular_detalles()
        {
            pago.Bono = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["bono"].Value);
            pago.Vacaciones = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["vacaciones"].Value);
            pago.Aguinaldo = Convert.ToDecimal(dg_ingresos.Rows[0].Cells["aguinaldo"].Value);

            pago.Rebajo = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["rebajo"].Value);
            pago.Adelanto = Convert.ToDecimal(dg_deducciones.Rows[0].Cells["adelanto"].Value);
            
            Decimal bruto_original = (pago.HorasLaboradas * 3000) + (pago.HorasExtra * (3000 * Convert.ToDecimal(1.5)));

            if (bruto_original != pago.SalarioBruto)
            {
                bruto_base = bruto_original;
            }

            pago.SalarioBruto = bruto_base + pago.Bono + pago.Vacaciones + pago.Aguinaldo;
            pago.Seguro = pago.SalarioBruto * Convert.ToDecimal(0.1);
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
