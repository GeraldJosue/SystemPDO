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
    public partial class Pago_Lista : UserControl
    {
        List<Pago> lista;
        DataTable table;

        public Pago_Lista()
        {
            InitializeComponent();        
            table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Id Colaborador");
            table.Columns.Add("Fecha Pago");
            table.Columns.Add("Salario Bruto");
            table.Columns.Add("Salario Neto");
            table.Columns.Add("Rebajo");
            table.Columns.Add("Horas Laboradas");
            table.Columns.Add("Horas Extra");
            table.Columns.Add("Transferencia");
            table.Columns.Add("Estado");
            obtener_lista_sys();

        }


        public void obtener_lista_sys()
        {
            lista = new Pago().obtener_lista();
            table = llenar_tabla();
            dg_Pagos.DataSource = table;
        }


        public DataTable llenar_tabla()
        {
            table.Clear();
            foreach (Pago x in lista)
            {
                table.Rows.Add(x.Id, x.IdColaborador, x.FechaPago, x.SalarioBruto, x.SalarioNeto, x.Rebajo, x.HorasLaboradas, x.HorasExtra, x.TransferenciaPago, x.EstadoPago);
            }
            return table;
        }


        

    }
}
