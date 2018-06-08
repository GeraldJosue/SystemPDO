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
    public partial class Horarios_Lista : UserControl
    {
        DataTable dt_horarios_activos;
        DataTable dt_horarios_inactivos;

        List<Horario> lista;

        public Horarios_Lista()
        {
            InitializeComponent();
            dt_horarios_activos = new DataTable();
            dt_horarios_activos.Columns.Add("Id");
            dt_horarios_activos.Columns.Add("Nombre");
            dt_horarios_activos.Columns.Add("Hora Inicio");
            dt_horarios_activos.Columns.Add("Hora Fin");
            dt_horarios_activos.Columns.Add("Estado");
                 
            dt_horarios_inactivos = new DataTable();
            dt_horarios_inactivos.Columns.Add("Id");
            dt_horarios_inactivos.Columns.Add("Nombre");
            dt_horarios_inactivos.Columns.Add("Hora Inicio");
            dt_horarios_inactivos.Columns.Add("Hora Fin");
            dt_horarios_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
        }

        public void obtener_lista_sys()
        {
            lista = new Horario().obtener_lista();
            dt_horarios_activos = llenar_tabla();
            dg_horarios.DataSource = dt_horarios_activos;
            dg_horarios.Columns["Id"].Visible = false;
        }

        public DataTable llenar_tabla()
        {
            dt_horarios_activos.Clear();
            foreach (Horario x in lista)
            {
                dt_horarios_activos.Rows.Add(x.Id, x.Nombre_Horario, x.Hora_Inicio.TimeOfDay, x.Hora_Fin.TimeOfDay, x.Estado ? "Activo" : "Inactivo");
            }
            return dt_horarios_activos;
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_horarios.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_horarios.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo el horario " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Horario horario = new Horario();
                horario.Id = id;
                horario.Estado = false;
                if (horario.eliminar())
                {
                    MessageBox.Show("Horario inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Horario obtener()
        {
            Horario horario = new Horario();
            Int32 id = Int32.Parse(dg_horarios.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Horario x in lista)
            {
                if (x.Id == id)
                {
                    horario = x;
                }
            }
            return horario;
        }
    }
}
