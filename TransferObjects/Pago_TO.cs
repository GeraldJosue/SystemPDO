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
        public Int32 Id_colaborador { get; set; }
        public DateTime FechaPago { get; set; }
        public Decimal SalarioBruto { get; set; }
        public Decimal SalarioNeto { get; set; }
        public Decimal Rebajo { get; set; }
        public Decimal HorasLaboradas { get; set; }
        public Decimal HorasExtra { get; set; }
        public String TransferenciaPago { get; set; }
        public Boolean EstadoPago { get; set; }
        public Decimal Bono { get; set; }
        public Int32 Id_adelanto { get; set; }
        public Boolean ProcesoPago { get; set; }


    }

}
