using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using TransferObjects;

namespace BusinessLogic
{
    public class Adelanto
    {
        public Int32 Id { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime Fecha { get; set; }
        public Double Monto { get; set; }
        public Boolean Estado { get; set; }

        public Adelanto(int id, int idColaborador, DateTime fecha, Double monto, Boolean estado)
        {
            this.Id = id;
            this.IdColaborador = idColaborador;
            this.Fecha = fecha;
            this.Monto = monto;
            this.Estado = estado;
        }

        public Adelanto()
        {

        }

        public Boolean agregar()
        {
            Adelanto_TO adelanto = bl_to_to();
            return new Adelanto_BD().agregar(adelanto);
        }

        public Boolean editar(List<Int32> lista)
        {
            Adelanto_TO adelanto = bl_to_to();
            return new Adelanto_BD().editar(adelanto, lista);
        }

        public List<Adelanto> obtener_lista()
        {
            List<Adelanto> lista = new List<Adelanto>();
            List<Adelanto_TO> lista_TO = new Adelanto_BD().obtener_lista();
            foreach (Adelanto_TO x in lista_TO)
            {
                lista.Add(to_to_bl(x));
            }
            return lista;
        }

        public Boolean eliminar()
        {
            Adelanto_TO aguinaldo = new Adelanto_TO();
            aguinaldo.Id = this.Id;
            return new Adelanto_BD().eliminar(aguinaldo);
        }


        public Adelanto_TO bl_to_to()
        {
            Adelanto_TO adelanto = new Adelanto_TO();
            adelanto.Id = this.Id;
            adelanto.IdColaborador = this.IdColaborador;
            adelanto.Fecha = this.Fecha;
            adelanto.Monto = this.Monto;            
            adelanto.Estado = this.Estado;
            return adelanto;
        }


        public Adelanto to_to_bl(Adelanto_TO to)
        {
            Adelanto adelanto = new Adelanto();
            adelanto.Id = to.Id;
            adelanto.IdColaborador = to.IdColaborador;
            adelanto.Fecha = to.Fecha;
            adelanto.Monto = Monto;
            adelanto.Estado = to.Estado;
            return adelanto;
        }

    }

}

