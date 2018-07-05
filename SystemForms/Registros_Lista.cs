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
    public partial class Registros_Lista : UserControl
    {
        List<Registro> lista;
        DataTable table_validos;
        DataTable table_invalidos;
        List<Colaborador> colaboradores;
        Registros_Control parent;

        String filtro;
        String texto;
        String fecha_inicio;
        String fecha_fin;

        public Registros_Lista(Registros_Control parent)
        {
            InitializeComponent();
            this.parent = parent;

            colaboradores = new Colaborador().obtener_lista_activos();
            crear_datatables();
            obtener_lista_sys();

            dg_registros.Columns["Id"].Visible = false;
            fecha_inicio = 1 + "/" + 1 + "/" + 1900;
            fecha_fin = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            texto = "";
        }

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Colaborador Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";
            ((DataTable)dg_registros.DataSource).DefaultView.RowFilter = filtro;
        }
        public void filtro_fecha_inicio(DateTime date)
        {
            fecha_inicio = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Colaborador Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";

            ((DataTable)dg_registros.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_fin(DateTime date)
        {
            fecha_fin = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Colaborador Like '%" + texto + "%') AND (Fecha >= #" + fecha_inicio + "# AND Fecha <= #" + fecha_fin + "#)";
            ((DataTable)dg_registros.DataSource).DefaultView.RowFilter = filtro;
        }

        public void crear_datatables()
        {
            table_validos = new DataTable();
            table_invalidos = new DataTable();

            table_validos.Columns.Add("Id");
            table_invalidos.Columns.Add("Id");

            table_validos.Columns.Add("Colaborador");
            table_invalidos.Columns.Add("Colaborador");

            table_validos.Columns.Add("Fecha");
            table_invalidos.Columns.Add("Fecha");

            table_validos.Columns.Add("Horas");
            table_invalidos.Columns.Add("Horas");

            table_validos.Columns.Add("HorasExtras");
            table_invalidos.Columns.Add("HorasExtras");

            table_validos.Columns.Add("Proceso");
            table_invalidos.Columns.Add("Proceso");

            table_validos.Columns.Add("Entrada");
            table_invalidos.Columns.Add("Entrada");

            table_validos.Columns.Add("Salida");
            table_invalidos.Columns.Add("Salida");

            table_validos.Columns.Add("Desayuno");
            table_invalidos.Columns.Add("Desayuno");

            table_validos.Columns.Add("Almuerzo");
            table_invalidos.Columns.Add("Almuerzo");

            table_validos.Columns.Add("Cafe");
            table_invalidos.Columns.Add("Cafe");
        }


        public void obtener_lista_sys()
        {
            lista = new Registro().obtener_lista();
            llenar_tabla();
            set_datasource(true);
        }

        public String set_nombre(Int32 id)
        {
            foreach (Colaborador c in colaboradores)
            {
                if (id == c.Id)
                {
                    return c.Nombre + " " + c.Apellido + " " + c.Segundo_apellido;
                }
            }
            return "No disponible";
        }

        public void llenar_tabla()
        {
            table_validos.Clear();
            table_invalidos.Clear();
            foreach (Registro x in lista)
            {
                
                if (x.Estado)
                {
                    table_validos.Rows.Add(x.Id, set_nombre(x.Id_Colaborador), x.Fecha.Date.ToShortDateString(), x.Horas, x.Extras, x.Proceso ? "Completo" : "En proceso", x.Entrada.ToShortTimeString(), x.Salida.ToShortTimeString(),
                        x.Desayuno.ToShortTimeString(), x.Almuerzo.ToShortTimeString(), x.Cafe.ToShortTimeString());
                }
                else
                {
                    table_invalidos.Rows.Add(x.Id, set_nombre(x.Id_Colaborador), x.Fecha.Date.ToShortDateString(), x.Horas, x.Extras, x.Proceso ? "Completo" : "En proceso", x.Entrada.ToShortTimeString(), x.Salida.ToShortTimeString(),
                        x.Desayuno.ToShortTimeString(), x.Almuerzo.ToShortTimeString(), x.Cafe.ToShortTimeString());
                }
            }
        }
        public Registro obtener()
        {
            Registro registro = new Registro();
            
            Int32 id = Int32.Parse(dg_registros.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Registro x in lista)
            {
                if (x.Id == id)
                {
                    registro = x;
                }
            }

            return registro;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_registros.CurrentRow.Cells["Id"].Value.ToString());
            String fecha = dg_registros.CurrentRow.Cells["Fecha"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inválido el registro del día " + fecha + "?", "Inválido", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Registro registro = new Registro();
                registro.Id = id;
                registro.Estado = false;
                if (registro.eliminar())
                {
                    MessageBox.Show("Registro invalidado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_registros.DataSource = table_validos;
            }
            else
            {
                dg_registros.DataSource = table_invalidos;
            }
        }
    
        public void bajar_fila()
        {
            Int32 i = dg_registros.CurrentCell.RowIndex;
            if (i + 1 < dg_registros.Rows.Count)
            {
                dg_registros.Rows[i].Selected = false;
                dg_registros.Rows[i + 1].Selected = true;
                dg_registros.CurrentCell = dg_registros.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_registros.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_registros.Rows[i].Selected = false;
                dg_registros.Rows[i - 1].Selected = true;
                dg_registros.CurrentCell = dg_registros.Rows[i - 1].Cells[0];
            }
        }
        public Boolean buscar_registro(DateTime fecha, Int32 id)
        {
            foreach (DataRow r in table_validos.Rows)
            {
                if (Convert.ToDateTime(r["Fecha"]) == fecha.Date && Int32.Parse(r["Colaborador"].ToString()) == id)
                {
                    return true;
                }
            }
            return false;
        }

        public Colaborador obtener_colaborador(Int32 id)
        {
            Colaborador col = new Colaborador();
            foreach(Colaborador c in colaboradores)
            {
                if(c.Id == id)
                {
                    return c;
                }
            }
            return col;
        }

        private void dg_registros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Registro registro = obtener();
            Colaborador colaborador = obtener_colaborador(registro.Id_Colaborador);
            Horario horario = new Horario().obtener_horario_colaborador(colaborador);
            parent.editar_registro(registro, colaborador, horario);
        }
    }
}
