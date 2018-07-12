using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Aguinaldo_TO
    {
        public Int32 Id { get; set; }
        public Int32 Id_General { get; set; }
        public Int32 IdColaborador { get; set; }
        public DateTime FechaAguinaldo { get; set; }
        public Decimal Salario { get; set; }
        public String TransferenciaAguinaldo { get; set; }
        public Boolean EstadoAguinaldo { get; set; }
    }

}
