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
    public partial class Aguinaldo_Control : UserControl
    {

        Aguinaldo_Lista_Temporal aguinaldo_lista_calcular;
        Aguinaldo_Editar aguinaldo_agregar;
        Aguinaldo_Lista listaAguinaldos;
        List<Colaborador> lista;
       
        public Aguinaldo_Control()
        {
            InitializeComponent();
            listaAguinaldos = new Aguinaldo_Lista(this);
            listaAguinaldos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            //llenar_cb_colaborador();
            //editar = false;
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            aguinaldo_lista_calcular = new Aguinaldo_Lista_Temporal(this);
            aguinaldo_lista_calcular.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(aguinaldo_lista_calcular);
            //editar = false;
            pn_filtros.Enabled = false;
        }
       
        private void bt_listar_Click(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (listaAguinaldos.eliminar_sys())
            {
                listaAguinaldos.obtener_lista_sys();
            }
        }

        private void bt_up_Click(object sender, EventArgs e)
        {
            listaAguinaldos.subir_fila();
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaAguinaldos.bajar_fila();
        }

      

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                listaAguinaldos.set_datasource(false);
            }
            else
            {
                listaAguinaldos.set_datasource(true);
            }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            listaAguinaldos.filtro_datos(tb_buscar.Text);
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            listaAguinaldos.filtro_fecha(dt_inicio.Value.Date);
        }

        public void setList(List<Aguinaldo> lista)
        {
            new Aguinaldo_Editar().agregar_lista(lista);
            listaAguinaldos.obtener_lista_temps(lista);
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        public void loadList()
        {
            listaAguinaldos.obtener_lista_sys();
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        //public void llenar_cb_colaborador()
        //{
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Id");
        //    dt.Columns.Add("Nombre");
        //    lista = new Colaborador().obtener_lista_activos();

        //    foreach (Colaborador x in lista)
        //    {
        //        dt.Rows.Add(x.Id, x.Nombre);
        //    }

        //    cb_colaboradores.ValueMember = "Id";
        //    cb_colaboradores.DisplayMember = "Nombre";
        //    cb_colaboradores.DataSource = dt;
        //}

        private void cb_colaboradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listaAguinaldos.filtro_Col(cb_colaboradores.DisplayMember);
        }

        //private void bt_guardar_Click_1(object sender, EventArgs e)
        //{
        //    if (!editar)
        //    {
        //        if (aguinaldo_agregar.agregar_sys())
        //        {
        //            listaAguinaldos.obtener_lista_sys();
        //            pn_master.Controls.Clear();
        //            pn_master.Controls.Add(listaAguinaldos);
        //            pn_filtros.Enabled = true;
        //        }
        //    }
        //    else
        //    {
        //        if (aguinaldo_agregar.editar_sys())
        //        {
        //            listaAguinaldos.obtener_lista_sys();
        //            pn_master.Controls.Clear();
        //            pn_master.Controls.Add(listaAguinaldos);
        //            pn_filtros.Enabled = true;
        //        }
        //    }

        //}

        //private void bt_cancelar_Click_1(object sender, EventArgs e)
        //{
        //    pn_master.Controls.Clear();
        //    pn_master.Controls.Add(listaAguinaldos);
        //    pn_filtros.Enabled = true;
        //}


        public void cancelar()
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaAguinaldos);
            pn_filtros.Enabled = true;
        }

        public void editar_temp()
        {
            aguinaldo_agregar = new Aguinaldo_Editar(aguinaldo_lista_calcular.obtener(), this);
            aguinaldo_agregar.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(aguinaldo_agregar);
            //editar = true;
            pn_filtros.Enabled = false;
            cb_activos.Checked = false;
        }

    }
}
