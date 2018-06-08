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
    public partial class Aguinaldo_Agregar : UserControl
    {

        Aguinaldo aguinaldo;
        public Aguinaldo_Agregar()
        {
            InitializeComponent();
        }


        public Aguinaldo_Agregar(Aguinaldo aguinaldo)
        {
            InitializeComponent();
            this.aguinaldo = aguinaldo;
            setear_datos();
        }

        public Boolean agregar_sys()
        {
            Aguinaldo aguinaldo = obtener_datos();
            if (aguinaldo.agregar())
            {
                MessageBox.Show("Aguinaldo agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Aguinaldo aguinaldo = obtener_datos();
            aguinaldo.Id = this.aguinaldo.Id;
            List<Int32> lista = validar_cambios(aguinaldo);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (aguinaldo.editar(lista))
            {
                MessageBox.Show("Aguinaldo editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public Aguinaldo obtener_datos()
        {
            //analizar lo de departamento y lo de las fechas            
            Int32 colaborador = cb_colaborador.SelectedIndex == -1 ? 1 : cb_colaborador.SelectedIndex;
            DateTime fecha = dtp_fecha.Value.Date;
            Double salarioAguinaldo = tb_monto.Text.Equals("") ? 0 : Double.Parse(tb_monto.Text);            
            String transferencia = tb_transferencia.Text.Equals("") ? "No disponible" : tb_transferencia.Text;
            Boolean estado = cb_estado.Checked ? true : false;

            //Revisar datos por defecto
            return new Aguinaldo(0, colaborador, fecha, salarioAguinaldo, transferencia, estado);
        }

        public void setear_datos()
        {
            //Setear el selected index
            //cb_colaborador.SelectedIndex
            dtp_fecha.Text = aguinaldo.FechaAguinaldo.ToString();
            tb_monto.Text = aguinaldo.Salario.ToString();
            tb_transferencia.Text = aguinaldo.TransferenciaAguinaldo;
            cb_estado.Checked = aguinaldo.EstadoAguinaldo;
        }

        public List<Int32> validar_cambios(Aguinaldo aguinaldoNuevo)
        {
            List<Int32> lista = new List<Int32>();
            if (aguinaldoNuevo.IdColaborador != this.aguinaldo.IdColaborador)
            {
                lista.Add(0);
            }
            if (aguinaldoNuevo.FechaAguinaldo != this.aguinaldo.FechaAguinaldo)
            {
                lista.Add(1);
            }
            if (aguinaldoNuevo.Salario != this.aguinaldo.Salario)
            {
                lista.Add(2);
            }            
            if (aguinaldoNuevo.TransferenciaAguinaldo != this.aguinaldo.TransferenciaAguinaldo)
            {
                lista.Add(3);
            }
            if (aguinaldoNuevo.EstadoAguinaldo != this.aguinaldo.EstadoAguinaldo)
            {
                lista.Add(4);
            }
            return lista;
        }


    }
}
