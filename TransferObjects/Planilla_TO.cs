using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Planilla_TO
    {
        public Int32 Id { get; set; }
        public DateTime Fecha_inicio { get; set; }
        public DateTime Fecha_fin { get; set; }
        public Decimal Total { get; set; }
        public Int32 Tipo { get; set; }
        public Boolean Estado { get; set; }

    }
}
