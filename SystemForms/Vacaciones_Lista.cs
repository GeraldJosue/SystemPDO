using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Vacaciones_Lista : UserControl
    {
        DataTable dt_vacaciones_activos;
        DataTable dt_vacaciones_inactivos;
        String filtro;
        String texto;
        DateTime fecha_salida;
        DateTime fecha_regreso;

        List<Vacacion> lista;
        public Vacaciones_Lista()
        {
            InitializeComponent();

            dt_vacaciones_activos = new DataTable();
            dt_vacaciones_activos.Columns.Add("Id");
            dt_vacaciones_activos.Columns.Add("Colaborador");
            dt_vacaciones_activos.Columns.Add("Fecha Salida");
            dt_vacaciones_activos.Columns.Add("Fecha Regreso");
            dt_vacaciones_activos.Columns.Add("Cantidad de días");
            dt_vacaciones_activos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_activos.Columns.Add("Estado");

            dt_vacaciones_inactivos = new DataTable();
            dt_vacaciones_inactivos.Columns.Add("Id");
            dt_vacaciones_inactivos.Columns.Add("Colaborador");
            dt_vacaciones_inactivos.Columns.Add("Fecha Salida");
            dt_vacaciones_inactivos.Columns.Add("Fecha Regreso");
            dt_vacaciones_inactivos.Columns.Add("Cantidad de días");
            dt_vacaciones_inactivos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
            texto = "";
        }

        public void obtener_lista_sys()
        {
            lista = new Vacacion().obtener_lista();
            llenar_tabla();
            dg_vacaciones.DataSource = dt_vacaciones_activos;
            dg_vacaciones.Columns["Id"].Visible = false;
        }

        public DataTable llenar_tabla()
        {
            dt_vacaciones_activos.Clear();
            dt_vacaciones_inactivos.Clear();
            foreach (Vacacion vacacion in lista)
            {
                Colaborador colaborador = new Colaborador();
                colaborador.Id = vacacion.Id_Colaborador;
                colaborador.obtener_nombre();
                String nombre_colaborador = colaborador.Nombre + " " +colaborador.Apellido + " " + colaborador.Segundo_apellido;
                if (vacacion.Estado)
                {
                    dt_vacaciones_activos.Rows.Add(vacacion.Id, nombre_colaborador, formato_fecha(vacacion.Fecha_Salida), formato_fecha(vacacion.Fecha_Regreso), vacacion.Numero_Dias, vacacion.Salario, vacacion.Estado ? "Activo" : "Inactivo");
                }
                else
                {
                    dt_vacaciones_inactivos.Rows.Add(vacacion.Id, nombre_colaborador, vacacion.Fecha_Salida.ToString(), vacacion.Fecha_Regreso.ToString(), vacacion.Numero_Dias, vacacion.Salario, vacacion.Estado ? "Activo" : "Inactivo");
                }

            }
            return dt_vacaciones_activos;
        }

        private String formato_fecha(DateTime date)
        {
            return string.Format("{0:dd/MM/yyyy}", date);
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_vacaciones.CurrentRow.Cells["Colaborador"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactiva la vacación del colaborador " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Vacacion vacacion = new Vacacion();
                vacacion.Id = id;
                vacacion.Estado = false;
                if (vacacion.eliminar())
                {
                    MessageBox.Show("Vacación inactiva", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        public Vacacion obtener()
        {
            Vacacion vacacion = new Vacacion();
            Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Vacacion x in lista)
            {
                if (x.Id == id)
                {
                    vacacion = x;
                }
            }
            return vacacion;
        }

        public void bajar_fila()
        {
            Int32 i = dg_vacaciones.CurrentCell.RowIndex;
            if (i + 1 < dg_vacaciones.Rows.Count)
            {
                dg_vacaciones.Rows[i].Selected = false;
                dg_vacaciones.Rows[i + 1].Selected = true;
                dg_vacaciones.CurrentCell = dg_vacaciones.Rows[i + 1].Cells[1];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_vacaciones.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_vacaciones.Rows[i].Selected = false;
                dg_vacaciones.Rows[i - 1].Selected = true;
                dg_vacaciones.CurrentCell = dg_vacaciones.Rows[i - 1].Cells[1];
            }
        }

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_vacaciones.DataSource = dt_vacaciones_activos;
            }
            else
            {
                dg_vacaciones.DataSource = dt_vacaciones_inactivos;
            }
        }

        //    public void filtro_nombre(String busqueda)
        //    {
        //        texto = busqueda;
        //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
        //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        //    }

        //    public void filtro_hora_inicio(DateTime hora)
        //    {
        //        fecha_salida = hora;
        //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
        //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        //    }

        //    public void filtro_hora_fin(DateTime hora)
        //    {
        //        fecha_regreso = hora;
        //        filtro = "(Nombre Like '%" + texto + "%') AND ([Hora Inicio] >= #" + fecha_salida.TimeOfDay + "# AND [Hora Fin] <= #" + fecha_regreso.TimeOfDay + "#)";
        //        ((DataTable)dg_horarios.DataSource).DefaultView.RowFilter = filtro;
        //    }
    }
}

