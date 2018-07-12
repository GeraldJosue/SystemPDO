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
using System.Globalization;

namespace SystemForms
{
    public partial class Pago_Lista : UserControl
    {
        List<Planilla> lista;
        DataTable tableActivos;
        DataTable tableInactivos;
        Pago_Control parent;
        String filtro;
        String texto;
        String fecha;

        public Pago_Lista(Pago_Control parent)
        {

            InitializeComponent();
            this.parent = parent;

            tableActivos = new DataTable();
            tableActivos.Columns.Add("Encabezado");
            tableActivos.Columns.Add("Total");
            tableActivos.Columns.Add("Desde");
            tableActivos.Columns.Add("Hasta");
            tableActivos.Columns.Add("Tipo");

            tableInactivos = new DataTable();
            tableInactivos.Columns.Add("Encabezado");
            tableInactivos.Columns.Add("Total");
            tableInactivos.Columns.Add("Desde");
            tableInactivos.Columns.Add("Hasta");
            tableInactivos.Columns.Add("Tipo");

            obtener_lista_sys();

            fecha = 1 + "/" + 1 + "/" + 1900;
            texto = "";

        }


        public void obtener_lista_sys()
        {
            lista = new Planilla().obtener_lista();
            llenar_tabla();
            dg_Pagos.DataSource = tableActivos;
        }


        public void llenar_tabla()
        {
            tableActivos.Clear();
            tableInactivos.Clear();
            foreach (Planilla x in lista)
            {
                if (x.Estado)
                {
                    tableActivos.Rows.Add(x.Id, x.Total.ToString("C"), x.Fecha_inicio.Date.ToShortDateString(), x.Fecha_fin.Date.ToShortDateString(), x.Tipo == 14 ? "Quincenal" : "Mensual");
                }
                else
                {
                    tableInactivos.Rows.Add(x.Id, x.Total.ToString("C"), x.Fecha_inicio.Date.ToShortDateString(), x.Fecha_fin.Date.ToShortDateString(), x.Tipo == 14 ? "Quincenal" : "Mensual");
                }
            }
        }


        public Planilla obtener()
        {
            Planilla planilla = new Planilla();


            Int32 id = Int32.Parse(dg_Pagos.CurrentRow.Cells["Encabezado"].Value.ToString());
            foreach (Planilla x in lista)
            {
                if (x.Id == id)
                {
                    planilla = x;
                }
            }

            return planilla;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_Pagos.CurrentRow.Cells["Encabezado"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo el pago con el encabezado " + id + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Planilla planila = new Planilla();
                planila.Id = id;
                planila.Estado = false;
                if (planila.eliminar())
                {
                    MessageBox.Show("Pago inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_Pagos.DataSource = tableActivos;
            }
            else
            {
                dg_Pagos.DataSource = tableInactivos;
            }
        }

        public void filtro_nombre(String busqueda)
        {
            texto = busqueda;
            filtro = "(Transferencia Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_Pagos.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha(DateTime date)
        {
            fecha = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Transferencia Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_Pagos.DataSource).DefaultView.RowFilter = filtro;
        }

        private void dg_Pagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            parent.lista_review_pagos(obtener(), false);
        }

        private void bt_exportar_Click(object sender, EventArgs e)
        {
            if (lista.Count != 0)
            {
                List<Pago> lista = new Pago().obtener_lista_por_planilla(obtener().Id);
                new ExcelManager().export(lista);
            } else
            {
                MessageBox.Show("No existen planillas");
            }
        }
    }
}
