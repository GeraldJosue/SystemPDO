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
    public partial class Vacaciones_Agregar : UserControl
    {
        Vacacion vacacion;
        List<Colaborador> lista_colaboradores;
        Colaborador colaborador;
        TimeSpan cantidad_dias;
        public Vacaciones_Agregar()
        {
            InitializeComponent();
            vacacion = new Vacacion();
            llenar_cb_colaboradores();
            tb_cantidad_dias.Text = "0";
            setear_fechas_Y_salario();
        }

        private void llenar_cb_colaboradores()
        {
            colaborador = new Colaborador();
            lista_colaboradores = colaborador.obtener_lista();
            cb_colaborador.ValueMember = "Id";
            cb_colaborador.DisplayMember = "Nombre Completo";
            cb_colaborador.DataSource = llenar_dt_colaboradores();
        }

        private DataTable llenar_dt_colaboradores()
        {
            DataTable dt_colaboradores = new DataTable();
            dt_colaboradores.Columns.Add("Id");
            dt_colaboradores.Columns.Add("Nombre Completo");
            foreach(Colaborador colaborador in lista_colaboradores)
            {
                if (vacacion.tiene_vacaciones(colaborador))
                {
                    dt_colaboradores.Rows.Add(colaborador.Id, colaborador.Nombre + " " + colaborador.Apellido + " " + colaborador.Segundo_apellido);
                }
            }
            return dt_colaboradores;
        }

        public Vacaciones_Agregar(Vacacion vacacion)
        {
            InitializeComponent();
            this.vacacion = vacacion;
            setear_datos();
        }

        //Setea los datos de la vacacion en los componentes del form
        private void setear_datos()
        {
            //tb_nombre.Text = vacacion.Nombre_Horario;
            //dt_hora_inicio.Text = vacacion.Hora_Inicio.ToString();
            //dt_hora_fin.Text = vacacion.Hora_Fin.ToString();
            //if (vacacion.Estado)
            //{
            //    rb_activo.Checked = vacacion.Estado;
            //}
            //else
            //{
            //    rb_inactivo.Checked = vacacion.Estado;
            //}
        }

        //Muestra mensaje de confirmnacion si la vacacion fue agregado con exito ó mensaje de error en el caso contrario.
        public Boolean agregar_sys()
        {
            vacacion = obtener_datos();
            if (vacacion.agregar())
            {
                MessageBox.Show("La vacación fue agregada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            BusinessLogic.Vacacion vacacion = obtener_datos();
            vacacion.Id = this.vacacion.Id;
            List<Int32> lista = validar_cambios(vacacion);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (vacacion.editar(lista))
            {
                MessageBox.Show("Vacacion editada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al editar el horario", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        
        private Vacacion obtener_datos()
        {
            int colaborador = Int32.Parse(cb_colaborador.SelectedValue.ToString());
            DateTime fecha_salida = dtp_fecha_salida.Value;
            DateTime fecha_regreso = dtp_fecha_regreso.Value;
            int cant_dias = Int32.Parse(tb_cantidad_dias.Text.ToString());
            Decimal salario_vacaciones = Decimal.Parse(tb_salario.Text.ToString());
            Boolean estado = rb_activo.Checked ? true : rb_inactivo.Checked ? false : true;

            return new Vacacion(0, colaborador, fecha_salida, fecha_regreso, cant_dias, salario_vacaciones, string.Empty, estado);
        }

        private List<int> validar_cambios(Vacacion vacacion)
        {
            throw new NotImplementedException();
        }

        private void dtp_fecha_regreso_ValueChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            if(cantidad_dias.Days >= 0)
            {
                tb_cantidad_dias.Text = cantidad_dias.Days.ToString();
            } else
            {
                tb_cantidad_dias.Text = "0";
            }
        }

        private void dtp_fecha_salida_ValueChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            if (cantidad_dias.Days >= 0)
            {
                tb_cantidad_dias.Text = cantidad_dias.Days.ToString();
               
            }
            else
            {
                tb_cantidad_dias.Text = "0";
            }
        }

        private void cb_colaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            tb_dias_vacaciones_disp.Text = vacacion.total_cant_dias_vacaciones(colaborador).ToString();
           
        }

        private void setear_fechas_Y_salario()
        {
            colaborador.Id = Int32.Parse(cb_colaborador.SelectedValue.ToString());
            int cant_dias_vacaciones = vacacion.total_cant_dias_vacaciones(colaborador);
            dtp_fecha_regreso.MaxDate = dtp_fecha_salida.Value.Add(new TimeSpan(cant_dias_vacaciones, 0, 0, 0));
            dtp_fecha_regreso.MinDate = dtp_fecha_salida.Value;

            cantidad_dias = dtp_fecha_regreso.Value.Date - dtp_fecha_salida.Value.Date;
            Decimal salario = vacacion.monto_dia(colaborador) * cantidad_dias.Days; //Salario de las vacaciones = monto por dia * cantidad de dias de vacaciones
            tb_salario.Text = Convert.ToString(salario);
        }
    }
}
