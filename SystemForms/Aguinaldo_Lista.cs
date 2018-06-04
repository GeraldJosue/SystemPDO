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
    public partial class Aguinaldo_Lista : UserControl
    {
        List<Aguinaldo> lista;
        DataTable table;

        public Aguinaldo_Lista()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Id Colaborador");
            table.Columns.Add("Fecha Aguinaldo");
            table.Columns.Add("Salario Aguinaldo");
            table.Columns.Add("Transferencia");
            table.Columns.Add("Estado");            
            obtener_lista_sys();

        }


        public void obtener_lista_sys()
        {
            lista = new Aguinaldo().obtener_lista();
            table = llenar_tabla();
            dgv_Aguinaldo.DataSource = table;
        }


        public DataTable llenar_tabla()
        {
            table.Clear();
            foreach (Aguinaldo x in lista)
            {
                table.Rows.Add(x.Id, x.IdColaborador, x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
            }
            return table;
        }

    }
}
