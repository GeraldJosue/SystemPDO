using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Aguinaldo_General
    {
        public Int32 Id {get; set;}
        public DateTime Fecha { get; set; }
        public Decimal Monto_total { get; set; }


        public Aguinaldo_General(Int32 id, DateTime fecha, Decimal monto)
        {
            this.Id = id;
            this.Fecha = fecha;
            this.Monto_total = monto;
        }

        public Aguinaldo_General() { }



    }
}
