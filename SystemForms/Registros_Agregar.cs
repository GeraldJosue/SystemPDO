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
    public partial class Registros_Agregar : UserControl
    {
        Registros_Control parent;
        List<Departamento> departamentos;
        List<Colaborador> colaboradores;
        List<Horario> horarios;
        Registro registro;

        public Registros_Agregar(Registros_Control parent)
        {
            InitializeComponent();
            this.parent = parent;
            departamentos = new Departamento().obtener_lista_activos();
            colaboradores = new Colaborador().obtener_lista_activos();
            llenar_cb_colaboradores();
            llenar_cb_departamentos();
            //horarios =

            calcular_horas();
        }

        public Registros_Agregar(Registro registro, Registros_Control parent)
        {
            InitializeComponent();
            this.parent = parent;

            colaboradores = new Colaborador().obtener_lista_activos();
            llenar_cb_colaboradores();
            this.registro = registro;
            setear_datos();
        }

        public Boolean agregar_sys()
        {
            if (pn_validacion.BackColor == Color.LimeGreen)
            {
                Registro registro = obtener_datos();
                if (registro.agregar())
                {
                    MessageBox.Show("Registro agregado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Ya existe un registro para esta fecha asignado al colaborador", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean editar_sys()
        {
            if (pn_validacion.BackColor == Color.LimeGreen)
            {
                Registro registro = obtener_datos();
                registro.Id = this.registro.Id;
                List<Int32> lista = validar_cambios(registro);
                if (lista.Count == 0)
                {
                    return true;
                }
                else if (registro.editar(lista))
                {
                    MessageBox.Show("Registro editado con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                MessageBox.Show("Ya existe un registro para esta fecha asignado al colaborador", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Registro obtener_datos()
        {
            Int32 id = Int32.Parse(cb_colaborador.SelectedValue.ToString());
            DateTime fecha = dt_fecha.Value.Date;
            DateTime entrada = dt_entrada.Value;
            DateTime salida = dt_salida.Value;
            DateTime desayuno = dt_desayuno.Value;
            DateTime almuerzo = dt_almuerzo.Value;
            DateTime cafe = dt_cafe.Value;
            Decimal horas = Decimal.Parse(nud_horas.Value.ToString());
            Decimal extras = Decimal.Parse(nud_extras.Value.ToString());
            Boolean estado = rb_valido.Checked;
            Boolean proceso = rb_completo.Checked;

            return new Registro(0, id, fecha, entrada, salida, desayuno, almuerzo, cafe, horas, extras, estado, proceso);

        }

        public List<Int32> validar_cambios(Registro nuevo)
        {
            List<Int32> lista = new List<Int32>();
            if (nuevo.Id_Colaborador != this.registro.Id_Colaborador)
            {
                lista.Add(0);
            }
            if (nuevo.Fecha.Date != this.registro.Fecha.Date)
            {
                lista.Add(1);
            }
            if (nuevo.Entrada.TimeOfDay != this.registro.Entrada.TimeOfDay)
            {
                lista.Add(2);
            }
            if (nuevo.Salida.TimeOfDay != this.registro.Salida.TimeOfDay)
            {
                lista.Add(3);
            }
            if (nuevo.Desayuno.TimeOfDay != this.registro.Desayuno.TimeOfDay)
            {
                lista.Add(4);
            }
            if (nuevo.Cafe.TimeOfDay != this.registro.Cafe.TimeOfDay)
            {
                lista.Add(5);
            }
            if (nuevo.Almuerzo.TimeOfDay != this.registro.Almuerzo.TimeOfDay)
            {
                lista.Add(6);
            }
            if (nuevo.Horas != this.registro.Horas)
            {
                lista.Add(7);
            }
            if (nuevo.Extras != this.registro.Extras)
            {
                lista.Add(8);
            }
            if (nuevo.Estado != this.registro.Estado)
            {
                lista.Add(9);
            }
            if (nuevo.Proceso != this.registro.Proceso)
            {
                lista.Add(10);
            }
            return lista;
        }

        public void limpiar_controles()
        {
            //calcular horas, setear datetimes
            dt_fecha.Value = dt_fecha.Value.Date.AddDays(1);
        }

        public void llenar_cb_colaboradores()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Colaborador c in colaboradores)
            {
                dt.Rows.Add(c.Id, c.Nombre + " " + c.Apellido);
            }

            cb_colaborador.ValueMember = "Id";
            cb_colaborador.DisplayMember = "Nombre";
            cb_colaborador.DataSource = dt;
        }
        public void llenar_cb_departamentos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Departamento d in departamentos)
            {
                dt.Rows.Add(d.Id, d.Nombre);
            }

            cb_departamento.ValueMember = "Id";
            cb_departamento.DisplayMember = "Nombre";
            cb_departamento.DataSource = dt;
        }

        public void calcular_horas()
        {
            TimeSpan horas = dt_salida.Value.TimeOfDay - dt_entrada.Value.TimeOfDay;
            if (dt_almuerzo.Checked)
            {
                horas = horas - new TimeSpan(1, 0, 0);
            }
            Double minutos = horas.Minutes;
            nud_horas.Value = Convert.ToDecimal(horas.Hours + (minutos / 60));
            nud_extras.Value = nud_horas.Value;
        }

        private void dt_entrada_ValueChanged(object sender, EventArgs e)
        {
            calcular_horas();
        }

        private void dt_salida_ValueChanged(object sender, EventArgs e)
        {
            calcular_horas();
        }

        private void dt_almuerzo_ValueChanged(object sender, EventArgs e)
        {
            if (!dt_almuerzo.Checked)
            {
                nud_horas.Value = nud_horas.Value + 1;
                nud_extras.Value = nud_extras.Value + 1;
            }
            else
            {
                calcular_horas();
            }
        }

        public void setear_datos()
        {
            //cb departamentos
            //cb horarios
            cb_colaborador.SelectedValue = registro.Id_Colaborador;
            dt_fecha.Value = registro.Fecha;
            dt_entrada.Value = registro.Entrada;
            dt_salida.Value = registro.Salida;
            dt_desayuno.Value = registro.Desayuno;
            dt_almuerzo.Value = registro.Almuerzo;
            dt_cafe.Value = registro.Cafe;

            nud_horas.Value = registro.Horas;
            nud_extras.Value = registro.Extras;

            rb_completo.Checked = registro.Proceso;
            rb_completo.Checked = registro.Proceso;
            rb_valido.Checked = registro.Estado;

            rb_proceso.Checked = rb_completo.Checked ? false : rb_proceso.Checked = true;
            rb_invalido.Checked = rb_valido.Checked ? false : rb_valido.Checked = true;
        }

        private void cb_colaborador_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (registro != null && registro.Fecha.Date == dt_fecha.Value.Date)
            {
                pn_validacion.BackColor = Color.LimeGreen;
            }
            else
            {

                if (!parent.buscar_registro(dt_fecha.Value.Date, Int32.Parse(cb_colaborador.SelectedValue.ToString())))
                {
                    pn_validacion.BackColor = Color.LimeGreen;
                }
                else
                {
                    pn_validacion.BackColor = Color.Red;
                }

            }
        }

        private void dt_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (registro != null && registro.Fecha.Date == dt_fecha.Value.Date)
            {
                pn_validacion.BackColor = Color.LimeGreen;
            }
            else
            {

                if (!parent.buscar_registro(dt_fecha.Value.Date, Int32.Parse(cb_colaborador.SelectedValue.ToString())))
                {
                    pn_validacion.BackColor = Color.LimeGreen;
                }
                else
                {
                    pn_validacion.BackColor = Color.Red;
                }

            }
        }
    }
}
