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
        Progress_Form avance;
        Aguinaldo_Lista listaAguinaldos;
        Aguinaldo_Control parent;


        public Aguinaldo_Lista_Temporal(Aguinaldo_Control parent_control)
        {
            InitializeComponent();
            this.parent = parent_control;
            listaAguinaldos = new Aguinaldo_Lista(parent_control);
            listaAguinaldos.Dock = DockStyle.Fill;
            lista = new List<Aguinaldo>();
            lista_col = new Colaborador().obtener_lista_activos();
            tableActivos = new DataTable();
            tableActivos.Columns.Add("Id");
            tableActivos.Columns.Add("Colaborador");
            tableActivos.Columns.Add("Fecha");
            tableActivos.Columns.Add("Salario Aguinaldo");
            tableActivos.Columns.Add("Transferencia");
            tableActivos.Columns.Add("Estado");


        }


        public void obtener_lista_sys()
        {
            //Int32 flag = 1;
            //Int32 avance;
            foreach (Colaborador x in lista_col)
            {
                //if (lista_col.Count != 0)
                //{
                    lista.Add(new Aguinaldo(x.Id, x.Id, DateTime.Now, new Aguinaldo().calcular_salario_aguinaldo(x), "", true));
                //    avance = ((++flag) * 100) / lista_col.Count;
                //    bg_calcular_aguinaldo.ReportProgress(avance);
                //    System.Threading.Thread.Sleep(500);
                //}

            }


            llenar_tabla();
            //CheckForIllegalCrossThreadCalls = false;
            dg_lista_temp.DataSource = tableActivos;
            dg_lista_temp.Columns["Id"].Visible = false;
            dg_lista_temp.Columns["Estado"].Visible = false;

        }


        public void llenar_tabla()
        {
            tableActivos.Clear();

            foreach (Aguinaldo x in lista)
            {
                tableActivos.Rows.Add(x.Id, get_nombre(x.IdColaborador), x.FechaAguinaldo, x.Salario, x.TransferenciaAguinaldo, x.EstadoAguinaldo);
            }
        }

        public String get_nombre(Int32 id)
        {
            foreach (Colaborador c in lista_col)
            {
                if(c.Id == id)
                {
                    return c.Nombre +" "+  c.Apellido + " "+ c.Segundo_apellido;
                }
            }
            return "No disponible";
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


        private void bt_calcular_Click(object sender, EventArgs e)
        {
            //bg_calcular_aguinaldo.RunWorkerAsync();
            //avance = new Progress_Form();
            //avance.ShowDialog();
            obtener_lista_sys();
        }
       

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            parent.setList(lista);
        }

        private void bg_calcular_aguinaldo_DoWork(object sender, DoWorkEventArgs e)
        {
            obtener_lista_sys();
        }

        private void bg_calcular_aguinaldo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bg_calcular_aguinaldo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
        }

        public void set_lista(Aguinaldo aguinaldo)
        {
            foreach(Aguinaldo a in lista)
            {
                if (aguinaldo.Id == a.Id)
                {
                    a.FechaAguinaldo = aguinaldo.FechaAguinaldo;
                    a.Salario = aguinaldo.Salario;
                    a.TransferenciaAguinaldo = aguinaldo.TransferenciaAguinaldo;
                }
            }

            llenar_tabla();
            //CheckForIllegalCrossThreadCalls = false;
            dg_lista_temp.DataSource = tableActivos;
        }

        private void dg_lista_temp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Aguinaldo a in lista)
            {
                if (a.Id == Convert.ToInt32(dg_lista_temp.CurrentRow.Cells["Id"].Value))
                {
                    new Aguinaldo_Editar(a, this).Show();
                }
            }
        }
    }
}
