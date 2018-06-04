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
    public partial class Home : UserControl
    {
        Colaboradores_Control colaborador;
        public Home()
        {
            InitializeComponent();
        }

        private void bt_colaboradores_Click(object sender, EventArgs e)
        {
            colaborador = new Colaboradores_Control();
            colaborador.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(colaborador);
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
            parent.inicio();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
            parent.sesion();
        }
    }
}
