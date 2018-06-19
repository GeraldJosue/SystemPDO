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
    public partial class Aguinaldo_Lista_Temporal : UserControl
    {
        List<Aguinaldo> lista;
        List<Colaborador> lista_col;
        DataTable tableActivos;
        

        public Aguinaldo_Lista_Temporal()
        {
            InitializeComponent();
            lista_col = new Colaborador().obtener_lista_activos();
            tableActivos = new DataTable();
            tableActivos.Columns.Add("Revisar");
            tableActivos.Columns.Add("Id");
            tableActivos.Columns.Add("Id Colaborador");
            tableActivos.Columns.Add("Fecha");
            tableActivos.Columns.Add("Salario Aguinaldo");
            tableActivos.Columns.Add("Transferencia");
            tableActivos.Columns.Add("Estado");

            obtener_lista_sys();
        }       

        public void obtener_lista_sys()
        {
            lista = new Aguinaldo().calcular_aguinaldo(lista_col);
            llenar_tabla();
            dg_lista_temp.DataSource = tableActivos;

        }


        public void llenar_tabla()
        {
            tableActivos.Clear();
            
            foreach (Aguinaldo x in lista)
            {               
                tableActivos.Rows.Add(x.Id, x.IdColaborador, x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);                
            }
        }


        public Aguinaldo obtener()
        {
            Aguinaldo aguinaldo = new Aguinaldo();
            Int32 id = Int32.Parse(dg_lista_temp.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Aguinaldo x in lista)
            {
                if (x.Id == id)
                {
                    aguinaldo = x;
                }
            }

            return aguinaldo;

        }

        public void bajar_fila()
        {
            Int32 i = dg_lista_temp.CurrentCell.RowIndex;
            if (i + 1 < dg_lista_temp.Rows.Count)
            {
                dg_lista_temp.Rows[i].Selected = false;
                dg_lista_temp.Rows[i + 1].Selected = true;
                dg_lista_temp.CurrentCell = dg_lista_temp.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_lista_temp.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_lista_temp.Rows[i].Selected = false;
                dg_lista_temp.Rows[i - 1].Selected = true;
                dg_lista_temp.CurrentCell = dg_lista_temp.Rows[i - 1].Cells[0];
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
