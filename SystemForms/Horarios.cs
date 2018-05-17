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
    public partial class Horarios : UserControl
    {
        Horarios_Agregar agregar;
        Horarios_Lista lista;
        public Horarios()
        {
            InitializeComponent();
            lista = new Horarios_Lista();
            lista.Dock = DockStyle.Fill;
            pn_principal.Controls.Add(lista);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agregar = new Horarios_Agregar();
            agregar.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(agregar);
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            //tomar indice de la tabla
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(lista);
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            //tomar objeto de la tabla
        }
    }
}
