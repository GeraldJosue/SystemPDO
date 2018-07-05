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
    public partial class Colaboradores_Control : UserControl
    {
        Colaboradores_Agregar nuevo_colaborador;
        Colaboradores_Lista lista_colaboradores;
        Boolean editar;
        public Colaboradores_Control()
        {
            InitializeComponent();
            lista_colaboradores = new Colaboradores_Lista(this);
            lista_colaboradores.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            editar = false;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            nuevo_colaborador = new Colaboradores_Agregar(this);
            nuevo_colaborador.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_colaborador);
            editar = false;
            pn_filtros.Enabled = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            pn_filtros.Enabled = true;
        }

        private void visibilidad(Boolean op, Boolean fil)
        {

            //pn_opciones.Visible = op;
            //pn_filtros.Visible = fil;
        }

        public void listar()
        {
            lista_colaboradores.obtener_lista_sys();
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            pn_filtros.Enabled = true;
            if (cb_activos.Checked)
            {
                lista_colaboradores.set_datasource(false);
            }
        }

        public void cancelar()
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            pn_filtros.Enabled = true;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            nuevo_colaborador = new Colaboradores_Agregar(lista_colaboradores.obtener(), this);
            nuevo_colaborador.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_colaborador);
        }

        public void editar_col()
        {
            nuevo_colaborador = new Colaboradores_Agregar(lista_colaboradores.obtener(), this);
            nuevo_colaborador.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_colaborador);
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista_colaboradores.eliminar_sys())
            {
                lista_colaboradores.obtener_lista_sys();
            }
        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_activos.Checked)
            {
                lista_colaboradores.set_datasource(false);
            }
            else
            {
                lista_colaboradores.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            lista_colaboradores.filtro_nombre(tb_buscar.Text);
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            lista_colaboradores.filtro_fecha_inicio(dt_inicio.Value.Date);
        }

        private void dt_fin_ValueChanged(object sender, EventArgs e)
        {
            lista_colaboradores.filtro_fecha_fin(dt_fin.Value.Date);
        }

        public Boolean buscar_cedula(String cedula)
        {
            return lista_colaboradores.buscar_cedula(cedula);
        }
    }
}
