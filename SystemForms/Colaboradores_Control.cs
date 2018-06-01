﻿using System;
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
    public partial class Colaboradores_Control : UserControl
    {
        Colaboradores_Agregar nuevo_colaborador;
        Colaboradores_Lista lista_colaboradores;
        Boolean editar;
        public Colaboradores_Control()
        {
            InitializeComponent();
            lista_colaboradores = new Colaboradores_Lista();
            lista_colaboradores.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            visibilidad(false, true);
            editar = false;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            nuevo_colaborador = new Colaboradores_Agregar();
            nuevo_colaborador.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_colaborador);
            visibilidad(true, false);
            editar = false;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            visibilidad(false, true);
        }

        private void visibilidad(Boolean op, Boolean fil)
        {

            pn_opciones.Visible = op;
            pn_filtros.Visible = fil;
        }

        private void bt_guardar_Click_1(object sender, EventArgs e)
        {
            if (!editar)
            {
                if (nuevo_colaborador.agregar_sys())
                {
                    lista_colaboradores.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_colaboradores);
                    visibilidad(false, true);
                }
            } else
            {
                if (nuevo_colaborador.editar_sys())
                {
                    lista_colaboradores.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(lista_colaboradores);
                    visibilidad(false, true);
                }
            }
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(lista_colaboradores);
            visibilidad(false, true);
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            lista_colaboradores.bajar_fila();
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            lista_colaboradores.subir_fila();
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            nuevo_colaborador = new Colaboradores_Agregar(lista_colaboradores.obtener());
            nuevo_colaborador.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevo_colaborador);
            visibilidad(true, false);
            editar = true;
        }

        private void pn_master_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (lista_colaboradores.eliminar_sys())
            {
                lista_colaboradores.obtener_lista_sys();
            }
        }
    }
}
