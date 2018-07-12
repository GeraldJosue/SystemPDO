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
        public Int32 Id_General { get; set; }



        public Aguinaldo(Int32 id, Int32 idColaborador, DateTime fecha, Decimal salario, String transferencia, Boolean estado, Int32 id_general)
        {
            this.Id = id;
            this.IdColaborador = idColaborador;
            this.FechaAguinaldo = fecha;
            this.Salario = salario;
            this.TransferenciaAguinaldo = transferencia;
            this.EstadoAguinaldo = estado;
            this.Id_General = id_general;
        }


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

        public List<Aguinaldo> obtener_lista_id_general(int id)
        {
            List<Aguinaldo> lista = new List<Aguinaldo>();
            List<Aguinaldo_TO> lista_TO = new Aguinaldo_BD().obtener_lista_id_general(id);
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
            aguinaldo.Id_General = this.Id_General;
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
            aguinaldo.Id_General = to.Id_General;
            aguinaldo.Id = to.Id;
            aguinaldo.IdColaborador = to.IdColaborador;
            aguinaldo.FechaAguinaldo = to.FechaAguinaldo;
            aguinaldo.Salario = to.Salario;
            aguinaldo.TransferenciaAguinaldo = to.TransferenciaAguinaldo;
            aguinaldo.EstadoAguinaldo = to.EstadoAguinaldo;
            return aguinaldo;
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
