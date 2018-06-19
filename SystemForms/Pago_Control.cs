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
        Pago_Review review;
        Pago_Editar nuevoPago;
        Boolean editar;
        public Pago_Control()
        {
            InitializeComponent();
            listaPagos = new Pago_Lista();
            listaPagos.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaPagos);
            editar = false;
        }

        public void lista_review(List<Pago> lista)
        {
            review = new Pago_Review(lista, this);
            review.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(review);
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
            bt_guardar.Enabled = guardar;
            bt_revisar.Enabled = revisar;
            bt_cancelar.Enabled = cancelar;
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            nuevoPago = new Pago_Editar(listaPagos.obtener());
            nuevoPago.Dock = DockStyle.Fill;
            pn_master.Controls.Clear();
            pn_master.Controls.Add(nuevoPago);
            pn_filtros.Enabled = false;
            visibilidad(true, false, true);
            editar = true;
        }

        private void bt_listar_Click(object sender, EventArgs e)
        {
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

        private void bt_up_Click(object sender, EventArgs e)
        {
            listaPagos.subir_fila();
        }

        private void bt_down_Click(object sender, EventArgs e)
        {
            listaPagos.bajar_fila();
        }

        //private void bt_guardar_Click(object sender, EventArgs e)
        //{
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
        //}

        //private void bt_cancelar_Click(object sender, EventArgs e)
        //{
        //    pn_master.Controls.Clear();
        //    pn_master.Controls.Add(listaPagos);
        //    pn_filtros.Enabled = true;
        //}

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

        private void bt_guardar_Click_1(object sender, EventArgs e)
        {
            if (editar)
            {
                if (nuevoPago.editar_sys())
                {
                    listaPagos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaPagos);
                    pn_filtros.Enabled = true;

                }
            } else
            {
                if (review.agregar_sys())
                {
                    listaPagos.obtener_lista_sys();
                    pn_master.Controls.Clear();
                    pn_master.Controls.Add(listaPagos);
                    pn_filtros.Enabled = true;

                }
            }
        }
            
        

        private void bt_cancelar_Click_1(object sender, EventArgs e)
        {
            pn_master.Controls.Clear();
            pn_master.Controls.Add(listaPagos);
            pn_filtros.Enabled = true;
        }

        private void bt_revisar_Click(object sender, EventArgs e)
        {
            //review.mostrar_detalle();
            bt_cancelar.Visible = true;
        }
    }
}
