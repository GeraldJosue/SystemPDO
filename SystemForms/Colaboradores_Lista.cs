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
    public partial class Colaboradores_Lista : UserControl
    {
        List<Colaborador> lista;
        DataTable table;

        public Colaboradores_Lista()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Nombre");
            table.Columns.Add("Apellido");
            table.Columns.Add("Telefono");
            table.Columns.Add("Cuenta");
            table.Columns.Add("Entidad");
            obtener_lista_sys();
        }

        public void obtener_lista_sys()
        {
            lista = new Colaborador().obtener_lista();
            table = llenar_tabla();
            dg_colaboradores.DataSource = table;
        }

        public Colaborador obtener()
        {
            Colaborador colaborador = new Colaborador();
            Int32 id = Int32.Parse(dg_colaboradores.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Colaborador x in lista)
            {
                if(x.Id == id)
                {
                    colaborador = x;
                }
            }
            
            return colaborador;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_colaboradores.CurrentRow.Cells["Id"].Value.ToString());
            String nombre = dg_colaboradores.CurrentRow.Cells["Nombre"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo al colaborador " + nombre + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Colaborador colaborador = new Colaborador();
                colaborador.Id = id;
                colaborador.Estado = false;
                if(colaborador.eliminar())
                {
                     MessageBox.Show("Colaborador inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable llenar_tabla()
        {
            table.Clear();
            foreach(Colaborador x in lista)
            {
                table.Rows.Add(x.Id, x.Nombre, x.Apellido, x.Telefono, x.Cuenta, x.Entidad);
            }
            return table;
        }
    }
}
