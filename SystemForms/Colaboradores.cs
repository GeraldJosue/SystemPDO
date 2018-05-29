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
    public partial class Colaboradores : UserControl
    {
        Colaboradores_Agregar agregar;
        Colaboradores_Lista lista;
        Boolean editar;
        public Colaboradores()
        {
            InitializeComponent();
            lista = new Colaboradores_Lista();
            lista.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(lista);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agregar = new Colaboradores_Agregar();
            agregar.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(agregar);
            editar = false;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (agregar.agregar_sys())
                {
                    lista.obtener_lista_sys();
                    pn_principal.Controls.Clear();
                    pn_principal.Controls.Add(lista);
                }
            }
            else
            {
                if (agregar.editar_sys())
                {
                    lista.obtener_lista_sys();
                    pn_principal.Controls.Clear();
                    pn_principal.Controls.Add(lista);
                }
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            agregar = new Colaboradores_Agregar(lista.obtener());
            agregar.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(agregar);
            editar = true;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista.eliminar_sys())
            {
                lista.obtener_lista_sys();
            }
        }
    }
}
