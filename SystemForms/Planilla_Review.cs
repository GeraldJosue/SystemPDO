using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace SystemForms
{
    public partial class Planilla_Review : UserControl
    {
        List<Pago> pagos;
        List<Planilla> planillas;
        Pago_Control parent;
        public Planilla_Review(List<Planilla> planillas, List<Pago> pagos, Pago_Control parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.planillas = planillas;
            this.pagos = pagos;
            llenar_tabla();
        }

        public void llenar_tabla()
        {
            foreach (Planilla p in planillas)
            {
                dg_planillas.Rows.Add(p.Id, p.Total.ToString("C"), p.Fecha_inicio.ToShortDateString(), p.Fecha_fin.ToShortDateString(), p.Tipo == 14 ? "Quincenal" : "Mensual");
            }
        }

        public Planilla buscar_planilla()
        {
            foreach(Planilla p in planillas)
            {
                if (p.Id == Convert.ToInt32(dg_planillas.CurrentRow.Cells["encabezado"].Value.ToString()))
                {
                    return p;
                }
            }
            return new Planilla();
        }

        private void bt_revisar_Click(object sender, EventArgs e)
        {
            parent.lista_review_pagos(buscar_planilla());
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            foreach (Pago p in pagos)
            {
                p.agregar();
            }
            foreach (Planilla p in planillas)
            {
                p.agregar();
            }
        }
    }
}
