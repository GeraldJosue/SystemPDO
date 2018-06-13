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
    public partial class Adelanto_Lista : UserControl
    {
        List<Adelanto> lista;
        DataTable table_solicitados;//activos
        DataTable table_pagados;
        String filtro;
        String texto;
        String fecha;
            
        public Adelanto_Lista()
        {
            InitializeComponent();
            table_solicitados = new DataTable();
            table_pagados = new DataTable();

            table_solicitados.Columns.Add("Id");
            table_pagados.Columns.Add("Id");

            table_solicitados.Columns.Add("Colaborador");
            table_pagados.Columns.Add("Colaborador");

            table_solicitados.Columns.Add("Monto");
            table_pagados.Columns.Add("Monto");

            table_solicitados.Columns.Add("Fecha");
            table_pagados.Columns.Add("Fecha");

            table_solicitados.Columns.Add("Estado");
            table_pagados.Columns.Add("Estado");

            

            obtener_lista_sys();
            fecha = DateTime.Now.Month + "/" + DateTime.Now.Day + "/" + DateTime.Now.Year;
            texto = "";

        }

        public void obtener_lista_sys()
        {
            lista = new Adelanto().obtener_lista();
            llenar_tabla();
            dg_adelantos.DataSource = table_solicitados;
        }
        
        public void set_datasource(Boolean estado)
        {
            if (estado)
            {
                dg_adelantos.DataSource = table_solicitados;
            }
            else
            {
                dg_adelantos.DataSource = table_pagados;
            }
        }


        public Adelanto obtener()
        {
            Adelanto adelanto = new Adelanto();

            Int32 id = Int32.Parse(dg_adelantos.CurrentRow.Cells["Id"].Value.ToString());
            foreach (Adelanto x in lista)
            {
                if (x.Id == id)
                {
                    adelanto = x;
                }
            }

            return adelanto;

        }

        public Boolean eliminar_sys()
        {
            Int32 id = Int32.Parse(dg_adelantos.CurrentRow.Cells["Id"].Value.ToString());

            DialogResult dialogResult = MessageBox.Show("¿Desea establecer como pago el adelanto seleccionado?", "Inactivo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Adelanto adelanto = new Adelanto();
                adelanto.Id = id;
                adelanto.Estado = false;
                if (adelanto.eliminar())
                {
                    MessageBox.Show("Adelanto pagado", "Excelente!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void llenar_tabla()
        {
            table_solicitados.Clear();
            table_pagados.Clear();
            foreach (Adelanto x in lista)
            {
                if (x.Estado)
                {
                    table_solicitados.Rows.Add(x.Id, x.IdColaborador, x.Monto, x.Fecha.Date.ToShortDateString(),x.Estado);
                }
                else
                {
                    table_pagados.Rows.Add(x.Id, x.IdColaborador, x.Monto, x.Fecha.Date.ToShortDateString(), x.Estado);
                }
            }
        }

        public void bajar_fila()
        {
            Int32 i = dg_adelantos.CurrentCell.RowIndex;
            if (i + 1 < dg_adelantos.Rows.Count)
            {
                dg_adelantos.Rows[i].Selected = false;
                dg_adelantos.Rows[i + 1].Selected = true;
                dg_adelantos.CurrentCell = dg_adelantos.Rows[i + 1].Cells[0];
            }
        }

        public void subir_fila()
        {
            Int32 i = dg_adelantos.CurrentCell.RowIndex;
            if (i - 1 >= 0)
            {
                dg_adelantos.Rows[i].Selected = false;
                dg_adelantos.Rows[i - 1].Selected = true;
                dg_adelantos.CurrentCell = dg_adelantos.Rows[i - 1].Cells[0];
            }
        }

        public void filtro_monto(String busqueda)
        {
            texto = busqueda;
            filtro = "(Monto Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_adelantos.DataSource).DefaultView.RowFilter = filtro;
        }

        public void filtro_fecha_inicio(DateTime date)
        {
            fecha = date.Month + "/" + date.Day + "/" + date.Year;
            filtro = "(Monto Like '%" + texto + "%') AND (Fecha >= #" + fecha + "#)";
            ((DataTable)dg_adelantos.DataSource).DefaultView.RowFilter = filtro;
        }

    }
}
