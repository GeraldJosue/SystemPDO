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
        List<Pago> lista;
        DataTable tableActivos;
        DataTable tableInactivos;
        String filtro;
        String texto;
        String fecha;

        public Pago_Lista()
        {
            InitializeComponent();
            tableActivos = new DataTable();
            tableActivos.Columns.Add("Id");
            tableActivos.Columns.Add("Id Colaborador");
            tableActivos.Columns.Add("Fecha Pago");
            tableActivos.Columns.Add("Salario Bruto");
            tableActivos.Columns.Add("Salario Neto");
            tableActivos.Columns.Add("Rebajo");
            tableActivos.Columns.Add("Horas Laboradas");
            tableActivos.Columns.Add("Horas Extra");
            tableActivos.Columns.Add("Transferencia");
            tableActivos.Columns.Add("Proceso");


            tableInactivos = new DataTable();
            tableInactivos.Columns.Add("Id");
            tableInactivos.Columns.Add("Id Colaborador");
            tableInactivos.Columns.Add("Fecha Pago");
            tableInactivos.Columns.Add("Salario Bruto");
            tableInactivos.Columns.Add("Salario Neto");
            tableInactivos.Columns.Add("Rebajo");
            tableInactivos.Columns.Add("Horas Laboradas");
            tableInactivos.Columns.Add("Horas Extra");
            tableInactivos.Columns.Add("Transferencia");
            tableInactivos.Columns.Add("Proceso");

            obtener_lista_sys();

            fecha = 1 + "/" + 1 + "/" + 1900;
            texto = "";

        }


        public void obtener_lista_sys()
        {
            lista = new Pago().obtener_lista();
            llenar_tabla();
            dg_Pagos.DataSource = tableActivos;
        }


        public void llenar_tabla()
        {
            tableActivos.Clear();
            tableInactivos.Clear();
            foreach (Pago x in lista)
            {
                if (x.EstadoPago)
                {
                    tableActivos.Rows.Add(x.Id, x.Id_colaborador, x.FechaPago.Date.ToShortDateString(), x.SalarioBruto.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.SalarioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.Rebajo.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.HorasLaboradas, x.HorasExtra, x.TransferenciaPago, x.ProcesoPago ? "Pagado" : "En trámite");
                }
                else
                {
                    tableInactivos.Rows.Add(x.Id, x.Id_colaborador, x.FechaPago.Date.ToShortDateString(), x.SalarioBruto.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.SalarioNeto.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.Rebajo.ToString("C", CultureInfo.CreateSpecificCulture("es-CR")), x.HorasLaboradas, x.HorasExtra, x.TransferenciaPago, x.ProcesoPago ? "Pagado" : "En trámite");
                }
            }
        }


        public Pago obtener()
        {
            Pago pago = new Pago();

            Int32 id = Int32.Parse(dg_Pagos.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Pago x in lista)
            {
                if (x.Id == id)
                {
                    pago = x;
                }
            }

            return pago;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_Pagos.CurrentRow.Cells["Id"].Value.ToString());
            String transferencia = dg_Pagos.CurrentRow.Cells["Transferencia"].Value.ToString();

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como inactivo el pago con el numero de transferencia " + transferencia + " ?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Pago pago = new Pago();
                pago.Id = id;
                pago.EstadoPago = false;
                if (pago.eliminar())
                {
                    MessageBox.Show("Colaborador inactivo", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void bajar_fila()
        {
            Int32 i = dg_Pagos.CurrentCell.RowIndex;
            if (i + 1 < dg_Pagos.Rows.Count)
            {
                dg_Pagos.Rows[i].Selected = false;
                dg_Pagos.Rows[i + 1].Selected = true;
                dg_Pagos.CurrentCell = dg_Pagos.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_Pagos.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_Pagos.Rows[i].Selected = false;
                dg_Pagos.Rows[i - 1].Selected = true;
                dg_Pagos.CurrentCell = dg_Pagos.Rows[i - 1].Cells[0];
            }
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

    }
}
