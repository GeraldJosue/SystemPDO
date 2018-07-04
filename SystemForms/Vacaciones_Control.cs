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
    public partial class Vacaciones_Control : UserControl
    {
        Vacaciones_Agregar nueva_vacacion;
        Vacaciones_Lista lista_vacacaciones;
        Boolean editar;
        public Vacaciones_Control()
        {
            InitializeComponent();
            lista_vacacaciones = new Vacaciones_Lista();
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
            nueva_vacacion = new Vacaciones_Agregar(lista_vacacaciones.obtener());
            nueva_vacacion.Dock = DockStyle.Fill;
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
    }
}
