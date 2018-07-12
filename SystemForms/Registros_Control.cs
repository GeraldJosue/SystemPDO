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
    public partial class Registros_Control : UserControl
    {
        Registros_Agregar nuevo_registro;
        Registros_Lista lista_registros;
        Boolean editar;

        public Registros_Control()
        {
            InitializeComponent();
            lista_registros = new Registros_Lista(this);
            lista_registros.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_registros);
          
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                //if (nuevo_registro.agregar_sys())
                {
                    lista_registros.obtener_lista_sys();
                    nuevo_registro.limpiar_controles();
                }
            } else
            {
                if (nuevo_registro.editar_sys())
                {
                    lista_registros.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_registros);
                    pn_filtros.Enabled = true;
                    if (cb_activos.Checked)
                    {
                        lista_registros.set_datasource(false);
                    }
                }
            }
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            nuevo_registro = new Registros_Agregar(this);
            nuevo_registro.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_registro);
            pn_filtros.Enabled = false;
            editar = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            lista_registros.obtener_lista_sys();
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_registros);
            pn_filtros.Enabled = true;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            cancelar_button();
        }

        public void cancelar_button()
        {
            lista_registros.obtener_lista_sys();
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_registros);
            pn_filtros.Enabled = true;
        }

        public void editar_registro(Registro registro, Colaborador colaborador, Horario horario)
        {
            nuevo_registro = new Registros_Agregar(registro, colaborador, horario, this);
            nuevo_registro.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_registro);
        }
        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista_registros.eliminar_sys())
            {
                lista_registros.obtener_lista_sys();
            }
        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                lista_registros.set_datasource(false);
            }
            else
            {
                lista_registros.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            lista_registros.filtro_nombre(tb_buscar.Text);
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            lista_registros.filtro_fecha_inicio(dt_inicio.Value.Date);
        }

        private void dt_fin_ValueChanged(object sender, EventArgs e)
        {
            lista_registros.filtro_fecha_fin(dt_fin.Value.Date);
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            lista_registros.subir_fila();
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            lista_registros.bajar_fila();
        }

        public Boolean buscar_registro(DateTime fecha, Int32 id)
        {
            return lista_registros.buscar_registro(fecha, id);
        }
        
    }
}
