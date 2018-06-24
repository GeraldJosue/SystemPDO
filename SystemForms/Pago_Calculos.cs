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
using System.Threading;

namespace SystemForms
{
    public partial class Pago_Calculos : UserControl
    {
        Pago_Control parent;
        Progress_Form avance;
        List<Departamento> departamentos;
        List<Colaborador> colaboradores;
        List<Registro> registros;
        List<Pago> pagos;

        public Pago_Calculos(Pago_Control parent)
        {
            InitializeComponent();
            this.parent = parent;
            departamentos = new Departamento().obtener_lista_activos();
            colaboradores = new Colaborador().obtener_lista_activos();
            llenar_cb_departamentos();
            llenar_cb_periodos();
        }
        public void llenar_cb_departamentos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            foreach (Departamento d in departamentos)
            {
                dt.Rows.Add(d.Id, d.Nombre);
            }

            //cb_departamento.ValueMember = "Id";
            //cb_departamento.DisplayMember = "Nombre";
            //cb_departamento.DataSource = dt;
        }

        public void llenar_cb_periodos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");

            dt.Rows.Add(7, "Semana");
            dt.Rows.Add(14, "Quincena");
            dt.Rows.Add(30, "Mes");

            cb_periodo.ValueMember = "Id";
            cb_periodo.DisplayMember = "Nombre";
            cb_periodo.DataSource = dt;
            cb_periodo.SelectedValue = 14;
        }
        private void bgw_calculos_DoWork(object sender, DoWorkEventArgs e)
        {
            //int tamaño = 131;
            //for (int i = 0; i < tamaño; i++)
            //{
            //    int avance = ((i + 1) * 100) / tamaño;
            //    bgw_calculos.ReportProgress(avance);
            //}
            gestion();
        }

        private void bgw_calculos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bgw_calculos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
            parent.lista_review(pagos);
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            planeación();
            bgw_calculos.RunWorkerAsync();
            avance = new Progress_Form();
            avance.ShowDialog();
        }

        private void cb_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt_fin.Value = DateTime.Now.Date;
            dt_inicio.Value = dt_fin.Value.Date.AddDays(Convert.ToInt32(cb_periodo.SelectedValue) * -1);
        }

        public Boolean planeación()
        {
            DateTime inicio = dt_inicio.Value.Date;
            DateTime fin = dt_fin.Value.Date;

            registros = new Registro().obtener_lista_fechas(inicio, fin);
            return true;
        }
        public Boolean gestion()
        {
            pagos = new List<Pago>();
            
            Int32 flag = 0;
            Decimal horas = 0;
            Decimal extras = 0;
            Decimal bruto = 0;
            Decimal neto = 0;
            Int32 avance = 0;
            foreach (Colaborador c in colaboradores)
            {

                horas = 0;
                extras = 0;
                bruto = 0;
                neto = 0;

                foreach (Registro r in registros)
                {
                    if(c.Id == r.Id_Colaborador)
                    {
                        horas += r.Horas;
                        extras += r.Extras;
                    }
                }

                bruto = (horas * c.Precio) + (extras * (c.Precio * Convert.ToDecimal(1.5)));
                neto = bruto - (bruto * Convert.ToDecimal(0.1));
                pagos.Add(new Pago(0, c.Id, DateTime.Now.Date, bruto, neto, 0, horas, extras, "No disponible", true, 0, 0, false));
                avance = ((++flag) * 100) / colaboradores.Count;
                bgw_calculos.ReportProgress(avance);
                Thread.Sleep(500);
            }
            return true;
        }
    }
}
