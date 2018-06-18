using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Adelanto_TO
    {
        public Int32 Id { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime Fecha { get; set; }
        public Decimal Monto { get; set; }
        public Boolean Estado { get; set; }
    }
}
