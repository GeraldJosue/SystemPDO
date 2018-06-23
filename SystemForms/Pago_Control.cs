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
    public partial class Pago_Control : UserControl
    {

        Pago_Calculos calculos;
        Pago_Lista listaPagos;
        Pago_Review review_pagos;
        Planilla_Review review_planillas;
        Pago_Editar nuevoPago;
        List<Pago> pagos;
        List<Planilla> planillas;
        Boolean editar;
        public Pago_Control()
        {
            InitializeComponent();
            listaPagos = new Pago_Lista(this);
            listaPagos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaPagos);
            editar = false;
        }

        public void lista_review_planillas(List<Pago> pagos, List<Planilla> planillas)
        {
            this.pagos = pagos;
            this.planillas = planillas;
            review_planillas = new Planilla_Review(planillas, pagos, this);
            review_planillas.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(review_planillas);
        }

        public void lista_review_pagos(Planilla planilla, Boolean state)
        {
            List<Pago> lista = new List<Pago>();
            if (!state)
            {
                this.pagos = new Pago().obtener_lista_por_planilla(planilla.Id);
            }
            foreach (Pago p in pagos)
            {
                if (planilla.Id == p.Id_planilla)
                    lista.Add(p);
            }

            review_pagos = new Pago_Review(lista, this, state);
            review_pagos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(review_pagos);
        }

        public void set_pagos(List<Pago> lista)
        {
            this.pagos = lista;
            review_planillas.set_pagos(pagos);
            pn_master.Controls.Clear();
            pn_master.Controls.Add(review_planillas);
        }

        private void bt_agregar_Click(object sender, EventArgs e)
        {
            calculos = new Pago_Calculos(this);
            calculos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(calculos);
            pn_filtros.Enabled = false;
            editar = false;
        }

        public void visibilidad(Boolean guardar, Boolean revisar, Boolean cancelar)
        {
            //bt_guardar.Enabled = guardar;
            //bt_revisar.Enabled = revisar;
            //bt_cancelar.Enabled = cancelar;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            //nuevoPago = new Pago_Editar(listaPagos.obtener());
            //nuevoPago.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            //pn_master.Controls.Add(nuevoPago);
            pn_filtros.Enabled = false;
            visibilidad(true, false, true);
            editar = true;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
            listar_pagos();
        }

        public void listar_pagos()
        {
            listaPagos.obtener_lista_sys();
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaPagos);
            pn_filtros.Enabled = true;
            visibilidad(false, false, false);
        }
        private void bt_eliminar_Click(object sender, EventArgs e)
        {
            if (listaPagos.eliminar_sys())
            {
                listaPagos.obtener_lista_sys();
            }
        }


        private void bt_guardar_Click(object sender, EventArgs e)
        {
        //    if (!editar)
        //    {
        //        if (nuevoPago.agregar_sys())
        //        {
        //            listaPagos.obtener_lista_sys();
        //            pn_master.Controls.Clear();
        //            pn_master.Controls.Add(listaPagos);
        //            pn_filtros.Enabled = true;

        //        }
        //    }
        //    else
        //    {
        //        if (nuevoPago.editar_sys())
        //        {
        //            listaPagos.obtener_lista_sys();
        //            pn_master.Controls.Clear();
        //            pn_master.Controls.Add(listaPagos);
        //            pn_filtros.Enabled = true;

        //        }
        //    }
        }

        private void tb_buscar_TextChanged(object sender, EventArgs e)
        {
            listaPagos.filtro_nombre(tb_buscar.Text);
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
            listaPagos.filtro_fecha(dt_inicio.Value.Date);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_activos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_activos.Checked)
            {
                listaPagos.set_datasource(false);
            }
            else
            {
                listaPagos.set_datasource(true);
            }
        }



        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaPagos);
            pn_filtros.Enabled = true;
        }
    }
}
