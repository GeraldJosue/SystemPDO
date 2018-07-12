using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;



namespace BusinessLogic
{
    public class Aguinaldo_General
    {
        public Int32 Id {get; set;}
        public DateTime Fecha { get; set; }
        public Decimal Monto_total { get; set; }
        public Boolean Estado { get; set; }


        public Aguinaldo_General(Int32 id, DateTime fecha, Decimal monto, Boolean Estado)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Monto_total = monto;
            this.Estado = Estado;
        }

        public Aguinaldo_General() { }

        public Boolean agregar()
        {
            Aguinaldo_General_TO aguinaldo = bl_to_to();
            return new Aguinaldo_General_BD().agregar(aguinaldo);
        }

        public Boolean editar(List<Int32> lista)
        {
            Aguinaldo_General_TO aguinaldo = bl_to_to();
            return new Aguinaldo_General_BD().editar(aguinaldo, lista);
        }

        public List<Aguinaldo_General> obtener_lista()
        {
            List<Aguinaldo_General> lista = new List<Aguinaldo_General>();
            List<Aguinaldo_General_TO> lista_TO = new Aguinaldo_General_BD().obtener_lista();
            foreach (Aguinaldo_General_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Aguinaldo_General_TO aguinaldo = new Aguinaldo_General_TO();
            aguinaldo.Id = this.Id;
            return new Aguinaldo_General_BD().eliminar(aguinaldo);
        }


        public Aguinaldo_General_TO bl_to_to()
        {
            Aguinaldo_General_TO aguinaldo = new Aguinaldo_General_TO();            
            aguinaldo.Id = this.Id;            
            aguinaldo.Fecha = this.Fecha;
            aguinaldo.Monto = this.Monto_total;            
            aguinaldo.Estado = this.Estado;
            return aguinaldo;
        }


        public Aguinaldo_General to_to_bl(Aguinaldo_General_TO to)
        {
            Aguinaldo_General aguinaldo = new Aguinaldo_General();            
            aguinaldo.Id = to.Id;            
            aguinaldo.Fecha = to.Fecha;
            aguinaldo.Monto_total = to.Monto;
            aguinaldo.Estado = to.Estado;
            return aguinaldo;
        }

    }
}
