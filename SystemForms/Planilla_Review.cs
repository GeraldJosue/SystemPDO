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

        public void set_pagos(List<Pago> lista)
        {
            this.pagos = lista;
            Decimal total = 0;
            foreach(Pago p in pagos)
            {
                total += p.SalarioNeto;
            }

            foreach(Planilla pl in planillas)
            {
                pl.Total = total;
            }
            llenar_tabla();
        }

        public void llenar_tabla()
        {
            dg_planillas.Rows.Clear();
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
            parent.lista_review_pagos(buscar_planilla(), true);
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            foreach (Pago p in pagos)
            {
                if (!p.agregar())
                {
                    MessageBox.Show("Ocurrió un error con los pagos", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            foreach (Planilla p in planillas)
            {
                if (p.agregar())
                {
                    MessageBox.Show("Planilla agregada con éxito", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error con la planilla", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            parent.listar_pagos();
        }
    }
}
