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
    public partial class Aguinaldo_Lista_Temporal : UserControl
    {
        List<Aguinaldo> aguinaldos;
        List<Aguinaldo> lista_base;
        List<Colaborador> colaboradores;
        List<Horario> horarios;
        List<Pago> pagos;
        Aguinaldo_General aguinaldo_general;

        Progress_Form avance;
        Aguinaldo_Lista listaAguinaldos;
        Aguinaldo_Control parent;

        Boolean editar = false;


        public Aguinaldo_Lista_Temporal(Aguinaldo_Control parent_control)
        {
            InitializeComponent();
            this.parent = parent_control;

            //listaAguinaldos = new Aguinaldo_Lista(parent_control);
            //listaAguinaldos.Dock = DockStyle.Fill;

            colaboradores = new Colaborador().obtener_lista_activos();
            horarios = new Horario().obtener_lista_activos();           
        }

        public Aguinaldo_Lista_Temporal(Aguinaldo_Control parent_control, Aguinaldo_General general)
        {
            InitializeComponent();
            this.parent = parent_control;

            bt_calcular.Visible = false;
            editar = true;
            aguinaldo_general = general;
            colaboradores = new Colaborador().obtener_lista_activos();
            horarios = new Horario().obtener_lista_activos();
            aguinaldos = new Aguinaldo().obtener_lista_id_general(general.Id);
            salvar_base();
            llenar_tabla();

        }

        public void salvar_base()
        {
            lista_base = new List<Aguinaldo>();
            foreach (Aguinaldo aguinaldo in aguinaldos)
            {
                lista_base.Add(new Aguinaldo(aguinaldo.Id, aguinaldo.IdColaborador, aguinaldo.FechaAguinaldo, aguinaldo.Salario, aguinaldo.TransferenciaAguinaldo, aguinaldo.EstadoAguinaldo, aguinaldo.Id_General));
            }
        }

        public void llenar_tabla()
        {
            dg_lista_temp.Rows.Clear();

            foreach (Aguinaldo a in aguinaldos)
            {
                dg_lista_temp.Rows.Add(a.Id, a.Id_General, get_nombre(a.IdColaborador), a.Salario.ToString("C"), a.FechaAguinaldo, a.TransferenciaAguinaldo);
            }
        }

        public String get_nombre(Int32 id)
        {
            foreach (Colaborador c in colaboradores)
            {
                if(c.Id == id)
                {
                    return c.Nombre +" "+  c.Apellido + " "+ c.Segundo_apellido;
                }
            }
            return "No disponible";
        }


        private void bt_calcular_Click(object sender, EventArgs e)
        {
            if (planeacion())
            {
                bg_calcular_aguinaldo.RunWorkerAsync();
                avance = new Progress_Form();
                avance.ShowDialog();
            } else
            {
                MessageBox.Show("No existen pagos en el periodo especificado");
            }
        }
       
        public Boolean planeacion()
        {
            DateTime temporal = DateTime.Now;
            DateTime fecha = temporal;
            
            pagos = new Pago().obtener_lista_fechas(fecha.AddMonths(-11), fecha);
            if (pagos.Count != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public List<Int32> validar_cambios(Aguinaldo aguinaldoNuevo)
        {
            List<Int32> lista = new List<Int32>();
           
            foreach (Aguinaldo aguinaldo in lista_base)
            {
                if (aguinaldo.Id == aguinaldoNuevo.Id)
                {
                    if (aguinaldoNuevo.FechaAguinaldo != aguinaldo.FechaAguinaldo)
                    {
                        lista.Add(0);
                    }
                    if (aguinaldoNuevo.Salario != aguinaldo.Salario)
                    {
                        lista.Add(1);
                    }
                    if (aguinaldoNuevo.TransferenciaAguinaldo != aguinaldo.TransferenciaAguinaldo)
                    {
                        lista.Add(2);
                    }
                    if (aguinaldoNuevo.EstadoAguinaldo != aguinaldo.EstadoAguinaldo)
                    {
                        lista.Add(3);
                    }
                }
            }
            return lista;
        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            foreach (Aguinaldo a in aguinaldos)
            {
                if (!editar)
                {
                    a.agregar();
                }
                else
                {
                    List<Int32> lista = validar_cambios(a);
                    if (lista.Count != 0)
                    {
                        a.editar(lista);                      
                    }
                }
            }

            List<Int32> lista_total = new List<Int32>();
            lista_total.Add(1);
            recalcular_total();
            if (!editar && aguinaldo_general.agregar())
            {
                parent.listar();
            }
            else if (editar && aguinaldo_general.editar(lista_total))
            {
                parent.listar();
            }
            else
            {
                MessageBox.Show("Ocurrió un problema");
            }


        }

        public void recalcular_total()
        {
            aguinaldo_general.Monto_total = 0;
            foreach(Aguinaldo a in aguinaldos)
            {
                aguinaldo_general.Monto_total += a.Salario;
            }
        }

        private void bg_calcular_aguinaldo_DoWork(object sender, DoWorkEventArgs e)
        {
            gestion();
        }

        public void gestion()
        {
            Int32 avance = 0;
            Int32 flag = 0;
            DateTime fecha = DateTime.Now.Date;
            aguinaldos = new List<Aguinaldo>();
            Int32 id_general = Convert.ToInt32(fecha.Day + "" + fecha.Month + "" + fecha.Year);
            Decimal total_aguinaldo = 0;

            foreach(Colaborador c in colaboradores)
            {
                Horario horario = set_horario(c.Id_horario);
                Decimal salario_diario = c.Precio * (horario.Horas - 1);
                Decimal salario_mensual = salario_diario * 30;

                Decimal horas = 0;
                Decimal extras = 0;
                Int32 mes = 0;

                foreach (Pago p in pagos)
                {
                    
                    if(p.Id_colaborador == c.Id)
                    {
                        if (mes == 0)
                        {
                            mes = p.FechaPago.Month;
                        }
                        horas += p.HorasLaboradas;
                        extras += p.HorasExtra;
                    }
                }

                if (horas != 0)
                {
                    Decimal salario_anual = salario_mensual * 12;
                    BusinessLogic.Configuracion config = new BusinessLogic.Configuracion().obtener_Configuracion();
                    Decimal salario_extras = (c.Precio * config.Porcentaje_Hora_Extra) * extras;
                    Decimal salario_final = (salario_anual / 12) + salario_extras;
                    total_aguinaldo += salario_final;
                    aguinaldos.Add(new Aguinaldo(c.Id, c.Id, fecha, salario_final, "No disponible", true, id_general));
                }
                avance = ((++flag) * 100) / colaboradores.Count;
                bg_calcular_aguinaldo.ReportProgress(avance);
                Thread.Sleep(500);
            }
            aguinaldo_general = new Aguinaldo_General(id_general, fecha, total_aguinaldo, true);
            
        }

        public Horario set_horario(Int32 Id)
        {
            foreach(Horario h in horarios)
            {
                if(Id == h.Id)
                {
                    return h;
                }
            }
            return null;
        }

        private void bg_calcular_aguinaldo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            avance.progreso(e.ProgressPercentage);
        }

        private void bg_calcular_aguinaldo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            avance.Close();
            llenar_tabla();
        }

       

        private void dg_lista_temp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Aguinaldo a in aguinaldos)
            {
                if (a.Id == Convert.ToInt32(dg_lista_temp.CurrentRow.Cells["Id"].Value))
                {
                    new Aguinaldo_Editar(a, this).Show();
                }
            }
        }
    }
}
