using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Pago_TO
    {
        public Int32 Id { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime FechaPago { get; set; }
        public Double SalarioBruto { get; set; }
        public Double SalarioNeto { get; set; }
        public Double Rebajo { get; set; }
        public Double HorasLaboradas { get; set; }
        public Double HorasExtra { get; set; }
        public String TransferenciaPago { get; set; }
        public Boolean EstadoPago { get; set; }

    }

}
