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
        public Colaboradores()
        {
            InitializeComponent();
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            agregar = new Colaboradores_Agregar();
            agregar.Dock = DockStyle.Fill;
            pn_principal.Controls.Clear();
            pn_principal.Controls.Add(agregar);

        }
    }
}
