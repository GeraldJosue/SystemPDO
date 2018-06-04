using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Departamentos_Control : UserControl
    {

        Departamento_Agregar departamentoNuevo;
        Departamento_Lista listaDepartamentos;
        Boolean editar;

        public Departamentos_Control()
        {
            InitializeComponent();            
            listaDepartamentos = new Departamento_Lista();
            listaDepartamentos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaDepartamentos);
            visibilidad(false, true);
            editar = false;
        }

        private void visibilidad(Boolean op, Boolean fil)
        {
            pn_opciones.Visible = op;
            pn_filtros.Visible = fil;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            departamentoNuevo = new Departamento_Agregar();
            departamentoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(departamentoNuevo);
            visibilidad(true, false);
            editar = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            departamentoNuevo = new Departamento_Agregar(listaDepartamentos.obtener());
            departamentoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(departamentoNuevo);
            visibilidad(true, false);
            editar = true;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaDepartamentos);
            visibilidad(false, true);
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (listaDepartamentos.eliminar_sys())
            {
                listaDepartamentos.obtener_lista_sys();
            }
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            listaDepartamentos.subir_fila();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaDepartamentos);
            visibilidad(false, true);
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaDepartamentos.bajar_fila();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (departamentoNuevo.agregar_sys())
                {
                    listaDepartamentos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaDepartamentos);
                    visibilidad(false, true);
                }
            }
            else
            {
                if (departamentoNuevo.editar_sys())
                {
                    listaDepartamentos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaDepartamentos);
                    visibilidad(false, true);
                }
            }
        }
    }
}
