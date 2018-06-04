using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Pago_Agregar : UserControl
    {

        BusinessLogic.Pago pago;
        public Pago_Agregar()
        {
            InitializeComponent();
        }

        public Pago_Agregar(BusinessLogic.Pago pago)
        {
            InitializeComponent();
            this.pago = pago;
            setear_datos();
        }

        public Boolean agregar_sys()
        {
            BusinessLogic.Pago pago = obtener_datos();
            if (pago.agregar())
            {
                MessageBox.Show("Pago agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Boolean editar_sys()
        {
            BusinessLogic.Pago pago = obtener_datos();
            pago.Id = this.pago.Id;
            List<Int32> lista = validar_cambios(pago);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (pago.editar(lista))
            {
                MessageBox.Show("Pago editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public BusinessLogic.Pago obtener_datos()
        {
            //analizar lo de departamento y lo de las fechas
            Int32 departamento = cb_departamento.SelectedIndex == -1 ? 1 : cb_departamento.SelectedIndex;
            Int32 colaborador = cb_colaborador.SelectedIndex == -1 ? 1 : cb_colaborador.SelectedIndex;
            DateTime fechaDesde = dtp_desde.Value.Date;
            DateTime fechaHasta = dtp_hasta.Value.Date;
            Double salarioBruto = tb_salarioBruto.Text.Equals("") ? 0 : Double.Parse(tb_salarioBruto.Text);
            Double salarioNeto = tb_salarioNeto.Text.Equals("") ? 0 : Double.Parse(tb_salarioNeto.Text);
            Double rebajo = tb_rebajo.Text.Equals("") ? 0 : Double.Parse(tb_rebajo.Text);
            Double horasLaboradas = tb_horas_laboradas.Text.Equals("") ? 0 : Double.Parse(tb_horas_laboradas.Text);
            Double horasExtra = tb_horas_extra.Text.Equals("") ? 0 : Double.Parse(tb_horas_extra.Text);
            String transferencia = tb_transferencia.Text.Equals("") ? "No disponible" : tb_transferencia.Text;           
            Boolean estado = cb_estado.Checked ? true : false;

            //Revisar datos por defecto
            return new BusinessLogic.Pago(0, colaborador, fechaDesde, salarioBruto, salarioNeto, rebajo, horasLaboradas, horasExtra, transferencia, estado);
        }

        public void setear_datos()
        {
            //Setear el selected index
            //cb_departamento.SelectedIndex
            //cb_colaborador.SelectedIndex

            tb_salarioBruto.Text = pago.SalarioBruto.ToString();
            tb_salarioNeto.Text = pago.SalarioNeto.ToString();
            tb_rebajo.Text = pago.Rebajo.ToString();
            tb_horas_laboradas.Text = pago.HorasLaboradas.ToString();
            tb_horas_extra.Text = pago.HorasExtra.ToString();
            tb_transferencia.Text = pago.TransferenciaPago;            
            cb_estado.Checked = pago.EstadoPago;
        }

        public List<Int32> validar_cambios(BusinessLogic.Pago pagoNuevo)
        {
            List<Int32> lista = new List<Int32>();
            if (pagoNuevo.IdColaborador != this.pago.IdColaborador)
            {
                lista.Add(0);
            }
            if (pagoNuevo.FechaPago != this.pago.FechaPago)
            {
                lista.Add(1);
            }
            if (pagoNuevo.SalarioBruto != this.pago.SalarioBruto)
            {
                lista.Add(2);
            }
            if (pagoNuevo.SalarioNeto!= this.pago.SalarioNeto)
            {
                lista.Add(3);
            }
            if (pagoNuevo.Rebajo != this.pago.Rebajo)
            {
                lista.Add(4);
            }
            if (pagoNuevo.HorasLaboradas != this.pago.HorasLaboradas)
            {
                lista.Add(5);
            }
            if (pagoNuevo.HorasExtra != this.pago.HorasExtra)
            {
                lista.Add(6);
            }
            if (pagoNuevo.TransferenciaPago != this.pago.TransferenciaPago)
            {
                lista.Add(7);
            }            
            if (pagoNuevo.EstadoPago != this.pago.EstadoPago)
            {
                lista.Add(8);
            }
            return lista;
        }
    }
}
