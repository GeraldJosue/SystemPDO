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
        Boolean editar;
        public Vacaciones_Control()
        {
            InitializeComponent();
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
    }
}
