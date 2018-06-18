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

    public partial class Adelanto_Control : UserControl
    {

        Adelanto_Agregar nuevo_adelanto;
        Adelanto_Lista listaAdelantos;
        Boolean editar;
        public Adelanto_Control()
        {
            InitializeComponent();
            listaAdelantos = new Adelanto_Lista();
            listaAdelantos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAdelantos);
            editar = false;
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            listaAdelantos.subir_fila();
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaAdelantos.bajar_fila();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            nuevo_adelanto = new Adelanto_Agregar();
            nuevo_adelanto.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_adelanto);
            editar = false;
            pn_filtros.Enabled = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            nuevo_adelanto = new Adelanto_Agregar(listaAdelantos.obtener());
            nuevo_adelanto.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_adelanto);
            editar = true;
            pn_filtros.Enabled = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAdelantos);
            pn_filtros.Enabled = true;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (listaAdelantos.eliminar_sys())
            {
                listaAdelantos.obtener_lista_sys();
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (nuevo_adelanto.agregar_sys())
                {
                    listaAdelantos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaAdelantos);
                    pn_filtros.Enabled = true;

                }
            }
            else
            {
                if (nuevo_adelanto.editar_sys())
                {
                    listaAdelantos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaAdelantos);
                    pn_filtros.Enabled = true;

                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAdelantos);
            pn_filtros.Enabled = true;
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            listaAdelantos.filtro_monto(tb_buscar.Text);
        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_activos.Checked)
            {
                listaAdelantos.set_datasource(false);
            } else
            {
                listaAdelantos.set_datasource(true);
            }
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            listaAdelantos.filtro_fecha_inicio(dt_inicio.Value.Date);
        }
    }
}
