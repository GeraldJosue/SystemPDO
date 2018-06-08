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
    public partial class Vacaciones_Lista : UserControl
    {
        DataTable dt_vacaciones_activos;
        DataTable dt_vacaciones_inactivos;

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
            dt_vacaciones_activos.Columns.Add("Transferencia");
            dt_vacaciones_activos.Columns.Add("Estado");

            dt_vacaciones_inactivos = new DataTable();
            dt_vacaciones_inactivos.Columns.Add("Id");
            dt_vacaciones_inactivos.Columns.Add("Colaborador");
            dt_vacaciones_inactivos.Columns.Add("Fecha Salida");
            dt_vacaciones_inactivos.Columns.Add("Fecha Regreso");
            dt_vacaciones_inactivos.Columns.Add("Cantidad de días");
            dt_vacaciones_inactivos.Columns.Add("Salario Vacaciones");
            dt_vacaciones_inactivos.Columns.Add("Transferencia");
            dt_vacaciones_inactivos.Columns.Add("Estado");

            obtener_lista_sys();
        }

        public void obtener_lista_sys()
        {
            lista = new Vacacion().obtener_lista();
            dt_vacaciones_activos = llenar_tabla();
            dg_vacaciones.DataSource = dt_vacaciones_activos;
            dg_vacaciones.Columns["Id"].Visible = false;
        }

        public DataTable llenar_tabla()
        {
            dt_vacaciones_activos.Clear();
            foreach (Vacacion x in lista)
            {
                dt_vacaciones_activos.Rows.Add(x.Id, x.Id_Colaborador, x.Fecha_Salida, x.Fecha_Regreso, x.Numero_Dias, x.Salario, x.Transferencia, x.Estado ? "Activo" : "Inactivo");
            }
            return dt_vacaciones_activos;
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Id"].Value.ToString());
            Int32 colaborador = Int32.Parse(dg_vacaciones.CurrentRow.Cells["Colaborador"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo las vacaciones del colaborador " + colaborador + "?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Vacacion vacacion = new Vacacion();
                vacacion.Id = id;
                vacacion.Estado = false;
                if (vacacion.eliminar())
                {
                    MessageBox.Show("Vacaciones inactivas", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

