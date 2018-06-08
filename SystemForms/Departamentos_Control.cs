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
            editar = false;
        }        

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            departamentoNuevo = new Departamento_Agregar();
            departamentoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(departamentoNuevo);
            editar = false;
            pn_filtros.Enabled = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            departamentoNuevo = new Departamento_Agregar(listaDepartamentos.obtener());
            departamentoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(departamentoNuevo);
            editar = true;
            pn_filtros.Enabled = false;
            cb_activos.Checked = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaDepartamentos);
            pn_filtros.Enabled = true;
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

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaDepartamentos.bajar_fila();
        }

        //private void bt_cancelar_Click(object sender, EventArgs e)
        //{
        //    pn_master.Controls.Clear();
        //    pn_master.Controls.Add(listaDepartamentos);
        //    pn_filtros.Enabled = true;
        //}

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                listaDepartamentos.set_datasource(false);
            }
            else
            {
                listaDepartamentos.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            listaDepartamentos.filtro_nombre(tb_buscar.Text);
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
                    pn_filtros.Enabled = true;

                }
            }
            else
            {
                if (departamentoNuevo.editar_sys())
                {
                    listaDepartamentos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaDepartamentos);
                    pn_filtros.Enabled = true;

                }
            }
        }

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaDepartamentos);
            pn_filtros.Enabled = true;
        }
    }
}
