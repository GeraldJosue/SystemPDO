using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Aguinaldo
    {

        public Int32 Id { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime FechaAguinaldo { get; set; }
        public Decimal Salario { get; set; }
        public String TransferenciaAguinaldo { get; set; }
        public Boolean EstadoAguinaldo { get; set; }


       public Aguinaldo(Int32 id, Int32 idColaborador, DateTime fecha, Decimal salario, String transferencia, Boolean estado)
        {
            this.Id = id;
            this.IdColaborador = idColaborador;
            this.FechaAguinaldo = fecha;
            this.Salario = salario;
            this.TransferenciaAguinaldo = transferencia;
            this.EstadoAguinaldo = estado;
        }

        //public Aguinaldo(Int32 idColaborador, DateTime fecha, Decimal salario, String transferencia, Boolean estado)
        //{
            
        //    this.IdColaborador = idColaborador;
        //    this.FechaAguinaldo = fecha;
        //    this.Salario = salario;
        //    this.TransferenciaAguinaldo = transferencia;
        //    this.EstadoAguinaldo = estado;
        //}

        public Aguinaldo()
        {

        }

        public Boolean agregar()
        {
            Aguinaldo_TO aguinaldo = bl_to_to();
            return new Aguinaldo_BD().agregar(aguinaldo);
        }

        public Boolean editar(List<Int32> lista)
        {
            Aguinaldo_TO aguinaldo = bl_to_to();
            return new Aguinaldo_BD().editar(aguinaldo, lista);
        }

        public List<Aguinaldo> obtener_lista()
        {
            List<Aguinaldo> lista = new List<Aguinaldo>();
            List<Aguinaldo_TO> lista_TO = new Aguinaldo_BD().obtener_lista();
            foreach (Aguinaldo_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Aguinaldo_TO aguinaldo = new Aguinaldo_TO();
            aguinaldo.Id = this.Id;            
            return new Aguinaldo_BD().eliminar(aguinaldo);
        }


        public Aguinaldo_TO bl_to_to()
        {
            Aguinaldo_TO aguinaldo = new Aguinaldo_TO();
            aguinaldo.Id = this.Id;
            aguinaldo.IdColaborador = this.IdColaborador;
            aguinaldo.FechaAguinaldo = this.FechaAguinaldo;
            aguinaldo.Salario = this.Salario;
            aguinaldo.TransferenciaAguinaldo = this.TransferenciaAguinaldo;
            aguinaldo.EstadoAguinaldo = this.EstadoAguinaldo;
            return aguinaldo;
        }


        public Aguinaldo to_to_bl(Aguinaldo_TO to)
        {
            Aguinaldo aguinaldo = new Aguinaldo();
            aguinaldo.Id = to.Id;
            aguinaldo.IdColaborador = to.IdColaborador;
            aguinaldo.FechaAguinaldo = to.FechaAguinaldo;
            aguinaldo.Salario = to.Salario;
            aguinaldo.TransferenciaAguinaldo = to.TransferenciaAguinaldo;
            aguinaldo.EstadoAguinaldo = to.EstadoAguinaldo;
            return aguinaldo;
        }

        //public List<Aguinaldo> calcular_aguinaldo(List<Colaborador> lista_col)
        //{
        //    List<Aguinaldo> lista_aguinaldos = new List<Aguinaldo>();
        //    foreach (Colaborador x in lista_col)
        //    {
        //        lista_aguinaldos.Add(new Aguinaldo(x.Id, DateTime.Now, calcular_salario_aguinaldo(x), "", true));
        //    }

        //    return lista_aguinaldos;
        //}

        public Decimal calcular_salario_aguinaldo(Colaborador colaborador)
        {
            List<Registro> lista_r = new Registro().obtener_lista();
            //Registro reg = new BusinessLogic.Registro();
            //List<Registro> lista_reg = obtener_lista_reg_colaborador(colaborador.Id, reg.obtener_lista());
            List<Registro> lista_reg = obtener_lista_reg_colaborador(colaborador.Id, lista_r);
            DateTime fecha_inicio = lista_reg.First().Fecha;
            DateTime fecha_reciente = lista_reg.Last().Fecha;
            Decimal meses_laborados = Convert.ToDecimal(((fecha_reciente - fecha_inicio).TotalDays)/30);
            return (calcular_salario_mensual(colaborador) * meses_laborados) / 12;
        }

        public List<Registro> obtener_lista_reg_colaborador(Int32 colaboradorId, List<Registro> registros)
        {
            List<Registro> lista_nueva = new List<Registro>();
            foreach (Registro reg in registros)
            {
                if (reg.Estado && reg.Id_Colaborador == colaboradorId)
                {
                    lista_nueva.Add(reg);
                }
            }
            return lista_nueva;
        }

        public Decimal calcular_salario_mensual(Colaborador colaborador)
        {
            Pago pago = new Pago();            
            List<Pago> lista_pago = pago.obtener_lista();
            Decimal horas_extra = 0;        
            foreach (Pago p in lista_pago)
            {
                if (p.EstadoPago && p.Id_colaborador == colaborador.Id)
                {
                    horas_extra += p.HorasExtra;
                }
            }

            return (calcular_salario_diario(colaborador) * 30) + horas_extra;
        }

        public Decimal calcular_salario_diario(Colaborador colaborador)
        {
          
            Horario horario = new Horario();           
            List<Horario> lista_hora = horario.obtener_lista();            
            Decimal salario_diario = 0;            
            foreach(Horario h in lista_hora)
            {
                if (h.Estado && h.Id == colaborador.Id_horario)
                {
                    salario_diario = colaborador.Precio * Decimal.Parse(((h.Hora_Fin - h.Hora_Inicio).TotalHours).ToString());
                }
            }

            return salario_diario;
        }

        public List<Aguinaldo > obtener_lista_fechas(DateTime fecha_inicio, DateTime fecha_fin)
        {
            List<Aguinaldo> lista = new List<Aguinaldo>();
            List<Aguinaldo_TO> lista_TO = new Aguinaldo_BD().obtener_lista_fechas(fecha_inicio, fecha_fin);
            foreach (Aguinaldo_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

    }
}
