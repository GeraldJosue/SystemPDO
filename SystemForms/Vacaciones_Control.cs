using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class Vacaciones_Control : UserControl
    {
        Vacaciones_Agregar nueva_vacacion;
        Vacaciones_Lista lista_vacacaciones;
        Boolean editar;
        public Vacaciones_Control()
        {
            InitializeComponent();
            lista_vacacaciones = new Vacaciones_Lista(this);
            lista_vacacaciones.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_vacacaciones);

            editar = false;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
               nueva_vacacion = new Vacaciones_Agregar();
               nueva_vacacion.Dock = DockStyle.Fill;
               pn_master.Controls.Clear();
               pn_master.Controls.Add(nueva_vacacion);
               editar = false;
               pn_filtros.Enabled = false;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if(lista_vacacaciones.existen_registros())
            {
                nueva_vacacion = new Vacaciones_Agregar(lista_vacacaciones.obtener());
                nueva_vacacion.Dock = DockStyle.Fill;
                pn_master.Controls.Clear();
                pn_master.Controls.Add(nueva_vacacion);
                editar = true;
            }
           
        }
        public void limpiar_pn_master(Vacaciones_Agregar vacacion)
        {
            this.nueva_vacacion = vacacion;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nueva_vacacion);
            editar = true;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_vacacaciones);
            pn_filtros.Enabled = true;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista_vacacaciones.eliminar_sys())
            {
                lista_vacacaciones.obtener_lista_sys();
            }
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (nueva_vacacion.agregar_sys())
                {
                    lista_vacacaciones.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_vacacaciones);
                    pn_filtros.Enabled = true;
                }
            }
            else
            {
                if (nueva_vacacion.editar_sys())
                {
                    lista_vacacaciones.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_vacacaciones);
                    pn_filtros.Enabled = true;
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_vacacaciones);
            pn_filtros.Enabled = true;
        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                lista_vacacaciones.set_datasource(false);
            }
            else
            {
                lista_vacacaciones.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            lista_vacacaciones.filtro_nombre(tb_buscar.Text);
        }

        private void dt_fecha_salida_ValueChanged(object sender, EventArgs e)
        {
            lista_vacacaciones.filtro_fecha_salida(dt_fecha_salida.Value);
        }

        private void dt_fecha_regreso_ValueChanged(object sender, EventArgs e)
        {
            lista_vacacaciones.filtro_fecha_regreso(dt_fecha_regreso.Value);
        }
    }
}
