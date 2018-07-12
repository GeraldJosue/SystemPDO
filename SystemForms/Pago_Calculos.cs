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
        List<Adelanto> adelantos;
        List<Vacacion> vacaciones;
        List<Aguinaldo> aguinaldos;
        List<Pago> pagos;
        List<Planilla> planillas;
        BusinessLogic.Configuracion config;
        DateTime inicio;
        DateTime fin;
        Planilla planilla;
        Int32 tipo;

        public Pago_Calculos(Pago_Control parent)
        {
            InitializeComponent();
            this.parent = parent;
            config = new BusinessLogic.Configuracion().obtener_Configuracion();
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
            
            dt.Rows.Add(14, "Quincenal");
            dt.Rows.Add(30, "Mensual");

            cb_periodo.ValueMember = "Id";
            cb_periodo.DisplayMember = "Nombre";
            cb_periodo.DataSource = dt;
            cb_periodo.SelectedValue = 14;
        }
        private void bgw_calculos_DoWork(object sender, DoWorkEventArgs e)
        {
            
            gestion();
            calcular_planillas();
        }

        private void bgw_calculos_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bgw_calculos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
            parent.lista_review_planillas(pagos, planillas);
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if (planeación())
            {
                bgw_calculos.RunWorkerAsync();
                avance = new Progress_Form();
                avance.ShowDialog();
            } else
            {
                MessageBox.Show("No existen registros para el rango de fechas especificado");
            }
        }

        private void cb_periodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set_fechas(dt_fin.Value.AddDays(Convert.ToInt32(cb_periodo.SelectedValue) * -1) , dt_fin.Value);
        }

        private void set_fechas(DateTime min, DateTime max)
        {
            dt_inicio.MinDate = min;
            dt_fin.MinDate = min;

            dt_inicio.MaxDate = max;
            dt_fin.MaxDate = max;

            dt_inicio.Value = min;
            dt_fin.Value = max;
        }

        public Boolean planeación()
        {
            inicio = dt_inicio.Value.Date;
            fin = dt_fin.Value.Date;
            tipo = Convert.ToInt32(cb_periodo.SelectedValue);
            registros = new Registro().obtener_lista_fechas(inicio, fin);
            if (registros.Count != 0)
            {
                adelantos = new Adelanto().obtener_lista_fechas(inicio, fin);
                vacaciones = new Vacacion().obtener_lista_fechas(inicio, fin);
                aguinaldos = new Aguinaldo().obtener_lista_fechas(inicio, fin);
                return true;

            }
            else
            {
                return false;
            }
        }
        public Boolean gestion()
        {
            pagos = new List<Pago>();
            
            Int32 flag = 0;
            Decimal horas = 0;
            Decimal extras = 0;
            Decimal bruto = 0;
            Decimal neto = 0;
            Decimal seguro = 0;
            Decimal adelanto = 0;
            Decimal vacacion = 0;
            Decimal aguinaldo = 0;
            Int32 avance = 0;
            foreach (Colaborador c in colaboradores)
            {
                if (c.Tipo_planilla == tipo)
                {
                    horas = 0;
                    extras = 0;
                    bruto = 0;
                    neto = 0;
                    seguro = 0;
                    adelanto = 0;
                    vacacion = 0;
                    aguinaldo = 0;

                    foreach (Registro r in registros)
                    {
                        if (c.Id == r.Id_Colaborador)
                        {
                            horas += r.Horas;
                            extras += r.Extras;
                        }
                    }

                    if (horas != 0)
                    {

                        foreach (Vacacion v in vacaciones)
                        {
                            if (v.Id_Colaborador == c.Id)
                            {
                                vacacion += v.Salario;

                            }
                        }

                        foreach (Aguinaldo a in aguinaldos)
                        {
                            if (a.IdColaborador == c.Id)
                            {
                                aguinaldo += a.Salario;

                            }
                        }

                        foreach (Adelanto a in adelantos)
                        {
                            if (a.IdColaborador == c.Id)
                            {
                                adelanto += a.Monto;
                            }
                        }

                        bruto = (horas * c.Precio) + (extras * (c.Precio * config.Porcentaje_Hora_Extra)) + vacacion + aguinaldo;
                        seguro = (bruto * (tipo == 14 ? (config.Porcentaje_Seguro / 2) : config.Porcentaje_Seguro)) / 100;
                        neto = bruto - (seguro) - adelanto;
                        Int32 id = Convert.ToInt32(fin.Day.ToString() + fin.Month.ToString() + fin.Year.ToString());
                        pagos.Add(new Pago(flag, c.Id, DateTime.Now.Date, bruto, neto, 0, horas, extras, "No disponible", true, 0, false, vacacion, aguinaldo, adelanto, seguro, id));
                        avance = ((++flag) * 100) / colaboradores.Count;
                        bgw_calculos.ReportProgress(avance);
                        Thread.Sleep(500);
                    }
                }
            }
            return true;
        }
        public void calcular_planillas()
        {
            Decimal total = 0;
            Int32 avance = 0;
            Int32 flag = 0;

            foreach (Pago p in pagos)
            {
                total += p.SalarioNeto;
                avance = ((++flag) * 100) / pagos.Count;
                bgw_calculos.ReportProgress(avance);
                Thread.Sleep(500);
            }
            Int32 id = Convert.ToInt32(fin.Day.ToString() + fin.Month.ToString() + fin.Year.ToString());
            planillas =  new List<Planilla>();
            planilla = new Planilla(id, inicio, fin, total, tipo, true);
            planillas.Add(planilla);
        }

        private void dt_fin_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dt_inicio_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
