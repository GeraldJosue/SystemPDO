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
    public partial class Aguinaldo_Control : UserControl
    {

        Aguinaldo_Agregar aguinaldoNuevo;
        Aguinaldo_Lista listaAguinaldos;
        Boolean editar;
        public Aguinaldo_Control()
        {
            InitializeComponent();
            listaAguinaldos = new Aguinaldo_Lista();
            listaAguinaldos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            editar = false;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            aguinaldoNuevo = new Aguinaldo_Agregar();
            aguinaldoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(aguinaldoNuevo);
            editar = false;
            pn_filtros.Enabled = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            aguinaldoNuevo = new Aguinaldo_Agregar(listaAguinaldos.obtener());
            aguinaldoNuevo.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(aguinaldoNuevo);
            editar = true;
            pn_filtros.Enabled = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (listaAguinaldos.eliminar_sys())
            {
                listaAguinaldos.obtener_lista_sys();
            }
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            listaAguinaldos.subir_fila();
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaAguinaldos.bajar_fila();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (aguinaldoNuevo.agregar_sys())
                {
                    listaAguinaldos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaAguinaldos);
                    pn_filtros.Enabled = true;
                }
            }
            else
            {
                if (aguinaldoNuevo.editar_sys())
                {
                    listaAguinaldos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaAguinaldos);
                    pn_filtros.Enabled = true;
                }
            }

        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                listaAguinaldos.set_datasource(false);
            }
            else
            {
                listaAguinaldos.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            listaAguinaldos.filtro_datos(tb_buscar.Text);
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            listaAguinaldos.filtro_fecha(dt_inicio.Value.Date);
        }
    }
}
