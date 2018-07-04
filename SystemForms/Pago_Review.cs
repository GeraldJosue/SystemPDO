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
    public partial class Pago_Review : UserControl
    {
        List<Pago> lista;
        List<Pago> lista_base;
        Progress_Form avance;
        Pago_Control parent;
        Boolean review_state;

        public Pago_Review(List<Pago> lista, Pago_Control parent, Boolean state)
        {
            InitializeComponent();
            this.parent = parent;
            this.lista = lista;
            this.lista_base = new List<Pago>();
            salvar_base();
            llenar_dg();
            review_state = state;
            parent.visibilidad(true, true, true);
        }

        public void llenar_dg()
        {
            dg_pagos_review.Rows.Clear();
            foreach (Pago p in lista)
            {
                dg_pagos_review.Rows.Add(p.Id, p.Id_colaborador, p.SalarioBruto.ToString("C"), p.SalarioNeto.ToString("C"), p.HorasLaboradas, p.HorasExtra, p.Id_planilla);
            }
           
        }

        public Boolean salvar_cambios(Pago pago)
        {
            foreach (Pago p in lista)
            {
                if (p.Id_colaborador == pago.Id_colaborador)
                {
                    p.Rebajo = pago.Rebajo;
                    p.Bono = pago.Bono;
                    p.SalarioBruto = pago.SalarioBruto;
                    p.SalarioNeto = pago.SalarioNeto;
                    p.TransferenciaPago = pago.TransferenciaPago;
                    p.EstadoPago = pago.EstadoPago;
                    llenar_dg();
                    return true;
                }
            }
            return false;
        }

        public void salvar_base()
        {
            foreach (Pago pago in lista)
            {
                lista_base.Add(new Pago(pago.Id, pago.Id_colaborador, pago.FechaPago, pago.SalarioBruto, pago.SalarioNeto, pago.Rebajo, pago.HorasLaboradas, pago.HorasExtra, pago.TransferenciaPago,
                    pago.EstadoPago, pago.Bono, pago.ProcesoPago, pago.Vacaciones, pago.Aguinaldo, pago.Adelanto, pago.Seguro, pago.Id_planilla));
            }
        }
        public void mostrar_detalle()
        {
            new Pago_Review_Form(buscar_lista(Convert.ToInt32(dg_pagos_review.CurrentRow.Cells["Id"].Value)), this).Show();
            //foreach (DataGridViewRow r in dg_pagos_review.Rows)
            //{
                //if (Convert.ToBoolean(r.Cells[0].Value))
                //{
                //    new Pago_Review_Form(buscar_lista(Convert.ToInt32(r.Cells[1].Value)), this).Show();
                //    r.Cells[0].Value = false;
                //}
            //}
        }

        public List<Int32> validar_cambios(Pago nuevo)
        {
            List<Int32> lista_cambios = new List<Int32>();
            foreach (Pago pago in lista_base) {
                if (pago.Id == nuevo.Id) {

                    if (pago.Bono != nuevo.Bono)
                    {
                        lista_cambios.Add(0);
                    }
                    if (pago.Rebajo != nuevo.Rebajo)
                    {
                        lista_cambios.Add(1);
                    }
                    if (pago.SalarioBruto != nuevo.SalarioBruto)
                    {
                        lista_cambios.Add(2);
                    }
                    if (pago.SalarioNeto != nuevo.SalarioNeto)
                    {
                        lista_cambios.Add(3);
                    }
                    if (!pago.TransferenciaPago.Equals(nuevo.TransferenciaPago))
                    {
                        lista_cambios.Add(4);
                    }
                    if (pago.EstadoPago != nuevo.EstadoPago)
                    {
                        lista_cambios.Add(5);
                    }
                    if (pago.ProcesoPago != nuevo.ProcesoPago)
                    {
                        lista_cambios.Add(6);
                    }
                    if (pago.Vacaciones != nuevo.Vacaciones)
                    {
                        lista_cambios.Add(7);
                    }
                    if (pago.Aguinaldo != nuevo.Aguinaldo)
                    {
                        lista_cambios.Add(8);
                    }
                    if (pago.Adelanto != nuevo.Adelanto)
                    {
                        lista_cambios.Add(9);
                    }
                    if (pago.Seguro != nuevo.Seguro)
                    {
                        lista_cambios.Add(10);
                    }
                    return lista_cambios;
                }
            }
        
            return lista_cambios;
        }

        public Pago buscar_lista(Int32 id)
        {
            foreach(Pago p in lista)
            {
                if(p.Id_colaborador == id)
                {
                    return p;
                }
            }
            return null;
        }

        public Boolean editar_sys()
        {
            bgw_pagos.RunWorkerAsync();
            avance = new Progress_Form();
            avance.ShowDialog();
            return true;
        }

        public void gestion()
        {
            Int32 flag = 0;
            Int32 avance;
            Planilla planilla = new Planilla();

            foreach (Pago p in lista)
            {
                planilla.Id = p.Id_planilla;
                planilla.Total += p.SalarioNeto;
                List<Int32> lista = validar_cambios(p);
                if (lista.Count != 0)
                {
                    p.editar(lista);
                    avance = ((++flag) * 100) / lista.Count;
                    bgw_pagos.ReportProgress(avance);
                    System.Threading.Thread.Sleep(500);
                }
            }
            planilla.set_total();
        }

        private void bgw_pagos_DoWork(object sender, DoWorkEventArgs e)
        {
            gestion();
        }

        private void bgw_pagos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bgw_pagos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
            parent.listar_pagos();
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (review_state)
            {
                parent.set_pagos(lista);
            }
            else
            {
                editar_sys();
            }
        }

        private void dg_pagos_review_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Pago p in lista)
            {
                if (p.Id == Convert.ToInt32(dg_pagos_review.CurrentRow.Cells["Id"].Value))
                {
                    new Pago_Review_Form(p, this).Show();
                }
            }
        }
    }
}
