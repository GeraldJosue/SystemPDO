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
    public partial class Departamento_Lista : UserControl
    {

        List<Departamento> lista;
        DataTable tableActivos;
        DataTable tableInactivos;
        String texto;
        String filtro;

        public Departamento_Lista()
        {
            InitializeComponent();        
            tableActivos = new DataTable();
            tableInactivos = new DataTable();

            tableActivos.Columns.Add("Id");
            tableActivos.Columns.Add("Nombre Departamento");           
            tableActivos.Columns.Add("Estado");

            tableInactivos.Columns.Add("Id");
            tableInactivos.Columns.Add("Nombre Departamento");
            tableInactivos.Columns.Add("Estado");

            obtener_lista_sys();                      
            texto = "";
        }


        public void obtener_lista_sys()
        {
            lista = new Departamento().obtener_lista();
            llenar_tabla();
            dg_Departamentos.DataSource = tableActivos;
            
        }


        public void llenar_tabla()
        {
            tableActivos.Clear();
            tableInactivos.Clear();
            foreach (Departamento x in lista)
            {
                if (x.Estado)
                {
                    tableActivos.Rows.Add(x.Id, x.Nombre, x.Estado);
                }
                else
                {
                    tableInactivos.Rows.Add(x.Id, x.Nombre, x.Estado);
                }
            }
        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_Departamentos.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_Departamentos.CurrentRow.Cells["Nombre Departamento"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo el departamento " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Departamento departamento = new Departamento();
                departamento.Id = id;
                departamento.Estado = false;
                if (departamento.eliminar())
                {
                    MessageBox.Show("Departamento inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public Departamento obtener()
        {
            Departamento departamento = new Departamento();
            Int32 id = Int32.Parse(dg_Departamentos.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Departamento x in lista)
            {
                if (x.Id == id)
                {
                    departamento = x;
                }
            }

            return departamento;

        }

        public void bajar_fila()
        {
            Int32 i = dg_Departamentos.CurrentCell.RowIndex;
            if (i + 1 < dg_Departamentos.Rows.Count)
            {
                dg_Departamentos.Rows[i].Selected = false;
                dg_Departamentos.Rows[i + 1].Selected = true;
                dg_Departamentos.CurrentCell = dg_Departamentos.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_Departamentos.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_Departamentos.Rows[i].Selected = false;
                dg_Departamentos.Rows[i - 1].Selected = true;
                dg_Departamentos.CurrentCell = dg_Departamentos.Rows[i - 1].Cells[0];
            }
        }

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_Departamentos.DataSource = tableActivos;
            }
            else
            {
                dg_Departamentos.DataSource = tableInactivos;
            }
        }

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Nombre Like '%" + texto + "%')";
            ((DataTable)dg_Departamentos.DataSource).DefaultView.RowFilter = filtro;
        }

    }
}
