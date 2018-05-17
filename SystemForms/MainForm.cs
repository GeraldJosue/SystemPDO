using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemForms
{
    public partial class MainForm : Form
    {
        private Login login;
        private Horarios horarios;
        private Colaboradores colaborares;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            login = new Login();
            login.Dock = DockStyle.Fill;
            pn_contenido.Controls.Add(login);
        }

        public void enable_disable(Boolean estate, Color color)
        {
            bt_horarios.BackColor = color;
            bt_horarios.Enabled = estate;
            bt_departamentos.BackColor = color;
            bt_departamentos.Enabled = estate;
            bt_colaboradores.BackColor = color;
            bt_colaboradores.Enabled = estate;
            bt_registros.BackColor = color;
            bt_registros.Enabled = estate;
            bt_pagos.BackColor = color;
            bt_pagos.Enabled = estate;
            bt_vacaciones.BackColor = color;
            bt_vacaciones.Enabled = estate;
            bt_aguinaldos.BackColor = color;
            bt_aguinaldos.Enabled = estate;
            bt_reportes.BackColor = color;
            bt_reportes.Enabled = estate;
            bt_config.BackColor = color;
            bt_config.Enabled = estate;
            bt_salir.BackColor = color;
            bt_salir.Enabled = estate;
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            enable_disable(false, Color.Gainsboro);
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(login);
        }

        private void bt_horarios_Click(object sender, EventArgs e)
        {
            horarios = new Horarios();
            horarios.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(horarios);
        }

        private void bt_departamentos_Click(object sender, EventArgs e)
        {
            //pn_contenido.Controls.Clear();
        }

        private void bt_colaboradores_Click(object sender, EventArgs e)
        {
            colaborares = new Colaboradores();
            colaborares.Dock = DockStyle.Fill;
            pn_contenido.Controls.Clear();
            pn_contenido.Controls.Add(colaborares);
        }
    }
}
