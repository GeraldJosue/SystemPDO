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
        Boolean editar;
        int cant_dias_vacaciones;
        public Vacaciones_Agregar()
        {
            InitializeComponent();
            vacacion = new Vacacion();
            colaborador = new Colaborador();
            llenar_cb_colaboradores();
            lb_cantidad_dias.Text = "0";
            rb_activo.Checked = true;
            editar = false;
            //setear_fechas_Y_salario();
        }

        public Vacaciones_Agregar(Vacacion vacacion)
        {
            InitializeComponent();
            this.vacacion = vacacion;
            colaborador = new Colaborador();
            lista_colaboradores = colaborador.obtener_lista_activos();
            setear_datos();
            rb_activo.Checked = true;
        }

        private void llenar_cb_colaboradores()
        { 
            lista_colaboradores = colaborador.obtener_lista_activos();
            colaborador = lista_colaboradores[0];
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

        //Setea los datos de la vacacion en los componentes del form
        private void setear_datos()
        {
            editar = true;
            cb_colaborador.ValueMember = vacacion.Id_Colaborador.ToString();
            colaborador.Id = vacacion.Id_Colaborador;
            colaborador.obtener_nombre();
            cb_colaborador.Text = colaborador.Nombre + " " + colaborador.Apellido + " " + colaborador.Segundo_apellido;
            cb_colaborador.Enabled = false;

            lb_dias_disponibles_vacaciones.Text = vacacion.total_cant_dias_vacaciones(colaborador).ToString();
            dtp_fecha_salida.Value = vacacion.Fecha_Salida;
            dtp_fecha_regreso.Value = vacacion.Fecha_Regreso;

            if (vacacion.Estado)
            {
                rb_activo.Checked = vacacion.Estado;
            }
            else
            {
                rb_inactivo.Checked = vacacion.Estado;
            }
        }

        //Muestra mensaje de confirmnacion si la vacacion fue agregado con exito ó mensaje de error en el caso contrario.
        public Boolean agregar_sys()
        {
            vacacion = obtener_datos();
            if (vacacion.agregar())
            {
                buscar_colaborador(Convert.ToInt32(cb_colaborador.SelectedValue));
                colaborador.reducir_vacaciones(Convert.ToInt32(lb_cantidad_dias.Text) + colaborador.Vacaciones);
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
            Int32 original = this.vacacion.Numero_Dias;
            BusinessLogic.Vacacion vacacion = obtener_datos();
            vacacion.Id = this.vacacion.Id;
            List<Int32> lista = validar_cambios(vacacion);
            if (lista.Count == 0)
            {
                return true;
            }
            else if (vacacion.editar(lista))
            {
                buscar_colaborador(Convert.ToInt32(cb_colaborador.SelectedValue));
                if (original < (Convert.ToInt32(lb_cantidad_dias.Text)))
                {
                    colaborador.reducir_vacaciones((Convert.ToInt32(lb_cantidad_dias.Text) - original) + colaborador.Vacaciones);
                    MessageBox.Show("Vacacion editada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (original > (Convert.ToInt32(lb_cantidad_dias.Text)))
                {
                    colaborador.reducir_vacaciones(colaborador.Vacaciones - (original - Convert.ToInt32(lb_cantidad_dias.Text)));
                    MessageBox.Show("Vacacion editada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            if(!editar)
            {
                int colaborador = Int32.Parse(cb_colaborador.SelectedValue.ToString());
            }
            DateTime fecha_salida = dtp_fecha_salida.Value;
            DateTime fecha_regreso = dtp_fecha_regreso.Value;
            int cant_dias = Int32.Parse(lb_cantidad_dias.Text.ToString());
            Decimal salario_vacaciones = Decimal.Parse(lb_salario_vacaciones.Text.ToString());
            Boolean estado = rb_activo.Checked ? true : rb_inactivo.Checked ? false : true;

            return new Vacacion(0, colaborador.Id, fecha_salida, fecha_regreso, cant_dias, salario_vacaciones, string.Empty, estado);
        }

        private List<int> validar_cambios(Vacacion vacacion)
        {
            List<Int32> lista = new List<Int32>();

            if (!(vacacion.Fecha_Salida == this.vacacion.Fecha_Salida))
            {
                lista.Add(0);
            }
            if (!(vacacion.Fecha_Regreso == this.vacacion.Fecha_Regreso))
            {
                lista.Add(1);
            }
            if(!(vacacion.Numero_Dias == this.vacacion.Numero_Dias))
            {
                lista.Add(2);
            }
            if (!(vacacion.Salario == this.vacacion.Salario))
            {
                lista.Add(3);
            }
            if (vacacion.Estado != this.vacacion.Estado)
            {
                lista.Add(4);
            }
            return lista;
        }

        private void dtp_fecha_regreso_ValueChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            if(cantidad_dias() >= 0)
            {
                lb_cantidad_dias.Text = cantidad_dias().ToString();
            } else
            {
                lb_cantidad_dias.Text = "0";                
            }
            
        }

        private void dtp_fecha_salida_ValueChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            
            if (cantidad_dias() >= 0)
            {
                lb_cantidad_dias.Text = cantidad_dias().ToString();
               
            }
            else
            {
                lb_cantidad_dias.Text = "0";
            }
        }

        private void cb_colaborador_SelectedIndexChanged(object sender, EventArgs e)
        {
            setear_fechas_Y_salario();
            lb_dias_disponibles_vacaciones.Text = Convert.ToString(cant_dias_vacaciones);
        }

        private Boolean setear_fechas_Y_salario()
        {
            if (validar_fecha_regreso()) return true;
           
            Decimal salario = vacacion.monto_dia(colaborador) * cantidad_dias(); //Salario de las vacaciones = monto por dia * cantidad de dias de vacaciones
            lb_salario_vacaciones.Text = Convert.ToString(salario);
            if (!editar)
            {
                buscar_colaborador(Int32.Parse(cb_colaborador.SelectedValue.ToString()));
            }
            cant_dias_vacaciones = vacacion.total_cant_dias_vacaciones(colaborador);
            //dtp_fecha_regreso.MaxDate = dtp_fecha_salida.Value.Add(new TimeSpan(cant_dias_vacaciones, 0, 0, 0));
            return true; 
        }

        public void buscar_colaborador(Int32 id)
        {
            foreach(Colaborador c in lista_colaboradores)
            {
                if(c.Id == id)
                {
                    colaborador = c;
                }
            }
        }

        public int cantidad_dias()
        {
            return (dtp_fecha_regreso.Value.Date - dtp_fecha_salida.Value.Date).Days;
        }

        private bool validar_fecha_regreso()
        {
            if (cantidad_dias() < 0)
            {
                MessageBox.Show("¡La fecha de regreso no puede ser menor a la fecha de salida!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtp_fecha_regreso.Value = dtp_fecha_salida.Value;
                return true;
            }
            return false;
        }


    }
}
