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
        Pago_Control pago;
        Aguinaldo_Control aguinaldo;
        Departamentos_Control departamento;
        Registros_Control registro;
        Horarios_Control horario;
        Adelanto_Control adelanto;
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

       private void bt_pago_Click(object sender, EventArgs e)
        {
            pago = new Pago_Control();
            pago.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(pago);
        }

        private void bt_aguinaldo_Click(object sender, EventArgs e)
        {
            aguinaldo = new Aguinaldo_Control();
            aguinaldo.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(aguinaldo);
        }

        private void bt_departamentos_Click(object sender, EventArgs e)
        {
            departamento = new Departamentos_Control();
            departamento.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(departamento);
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            Pantalla_Principal parent = (Pantalla_Principal)this.FindForm();
            parent.sesion();
        }

        private void bt_registro_Click(object sender, EventArgs e)
        {
            registro = new Registros_Control();
            registro.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(registro);
        }

        private void bt_horarios_Click(object sender, EventArgs e)
        {
            horario = new Horarios_Control();
            horario.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(horario);
        }

        private void bt_adelanto_Click(object sender, EventArgs e)
        {
            adelanto = new Adelanto_Control();
            adelanto.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(adelanto);
        }
    }
}
