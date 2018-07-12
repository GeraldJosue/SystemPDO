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
        String fecha_salida;
        String fecha_regreso;
        Vacaciones_Control parent;
        List<Vacacion> lista;
        public Vacaciones_Lista(Vacaciones_Control parent)
        {
            InitializeComponent();
            this.parent = parent;

            dt_vacaciones_activos = new DataTable();
            dt_vacaciones_activos.Columns.Add("Id");
            dt_vacaciones_activos.Columns.Add("Nombre");
            dt_vacaciones_activos.Columns.Add("Apellidos");
            dt_vacaciones_activos.Columns.Add("Fecha Salida");
            dt_vacaciones_activos.Columns.Add("Fecha Regreso");
            dt_vacaciones_activos.Columns.Add("Cantidad de días");
            dt_vacaciones_activos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_activos.Columns.Add("Estado");

            dt_vacaciones_inactivos = new DataTable();
            dt_vacaciones_inactivos.Columns.Add("Id");
            dt_vacaciones_inactivos.Columns.Add("Nombre");
            dt_vacaciones_inactivos.Columns.Add("Apellidos");
            dt_vacaciones_inactivos.Columns.Add("Fecha Salida");
            dt_vacaciones_inactivos.Columns.Add("Fecha Regreso");
            dt_vacaciones_inactivos.Columns.Add("Cantidad de días");
            dt_vacaciones_inactivos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
            fecha_salida = 1 + "/" + 1 + "/" + 1900;
            fecha_regreso = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
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
                String nombre = colaborador.Nombre;
                String apellidos = colaborador.Apellido + " " + colaborador.Segundo_apellido;
                if (vacacion.Estado)
                {
                    dt_vacaciones_activos.Rows.Add(vacacion.Id, nombre, apellidos, formato_fecha(vacacion.Fecha_Salida), formato_fecha(vacacion.Fecha_Regreso), vacacion.Numero_Dias, vacacion.Salario, vacacion.Estado ? "Activo" : "Inactivo");
                }
                else
                {
                    dt_vacaciones_inactivos.Rows.Add(vacacion.Id, nombre, apellidos, formato_fecha(vacacion.Fecha_Salida), formato_fecha(vacacion.Fecha_Regreso), vacacion.Numero_Dias, vacacion.Salario, vacacion.Estado ? "Activo" : "Inactivo");
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
            if(existen_registros())
            {
                Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
                String nombre = dg_vacaciones.CurrentRow.Cells["Nombre"].Value.ToString() + " " + dg_vacaciones.CurrentRow.Cells["Apellidos"].Value.ToString();
                
                DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactiva la vacación del colaborador " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        public bool existen_registros()
        {
            if (dg_vacaciones.RowCount >= 1)
            {
                return true;
            }
            return false;
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

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellidos Like '%" + texto + "%') AND ([Fecha Salida] >= #" + fecha_salida + "# AND [Fecha Regreso] <= #" + fecha_regreso + "#)";
            ((DataTable)dg_vacaciones.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_salida(DateTime date)
        {
            fecha_salida = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellidos Like '%" + texto + "%') AND ([Fecha Salida] >= #" + fecha_salida + "# AND [Fecha Regreso] <= #" + fecha_regreso + "#)";
            ((DataTable)dg_vacaciones.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_regreso(DateTime date)
        {
            fecha_regreso = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Nombre Like '%" + texto + "%' OR Apellidos Like '%" + texto + "%') AND ([Fecha Salida] >= #" + fecha_salida + "# AND [Fecha Regreso] <= #" + fecha_regreso + "#)";
            ((DataTable)dg_vacaciones.DataSource).DefaultView.RowFilter = filtro;
        }

        private void dg_vacaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Vacaciones_Agregar nuevo_horario;
            if (existen_registros())
            {
                nuevo_horario = new Vacaciones_Agregar(obtener());
                nuevo_horario.Dock = DockStyle.Fill;
                parent.limpiar_pn_master(nuevo_horario);
            }
        }
    }
}

