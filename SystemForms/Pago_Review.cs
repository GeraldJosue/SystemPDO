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
    public partial class Pago_Review : UserControl
    {
        List<Pago> lista;
        Progress_Form avance;

        public Pago_Review(List<Pago> lista)
        {
            InitializeComponent();
            this.lista = lista;
            llenar_dg();
        }

        public void llenar_dg()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Colaborador");
            dt.Columns.Add("Bruto");
            dt.Columns.Add("Neto");
            dt.Columns.Add("Horas");
            dt.Columns.Add("Extras");
            dt.Columns.Add("Rebajo");
            dt.Columns.Add("Bono");
            dt.Columns.Add("Transferencia");
            dt.Columns.Add("Estado");

            foreach (Pago p in lista)
            {
                dt.Rows.Add(p.Id_colaborador, p.SalarioBruto.ToString("C"), p.SalarioNeto.ToString("C"), p.HorasLaboradas, p.HorasExtra, p.Rebajo.ToString("C"), p.Bono.ToString("C"), p.TransferenciaPago, p.EstadoPago ? "Pagado" : "En trámite");
            }
            dg_pagos_review.DataSource = dt;
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
        public void mostrar_detalle()
        {
            foreach (DataGridViewRow r in dg_pagos_review.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value))
                {
                    new Pago_Review_Form(buscar_lista(Convert.ToInt32(r.Cells[1].Value)), this).Show();
                    r.Cells[0].Value = false;
                }
            }
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

        public Boolean agregar_sys()
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
            foreach (Pago p in lista)
            {
                p.agregar();
                avance = ((++flag) * 100) / lista.Count;
                bgw_pagos.ReportProgress(avance);
                System.Threading.Thread.Sleep(1000);
            }
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
        }
    }
}
