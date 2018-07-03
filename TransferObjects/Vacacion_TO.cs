using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Vacacion_TO
    {
        public Int32 Id { get; set; }
        public Int32 Id_Colaborador { get; set; }
        public DateTime Fecha_Salida { get; set; }
        public DateTime Fecha_Regreso { get; set; }
        public Int32 Numero_Dias { get; set; }
        public Decimal Salario { get; set; }
        public String Transferencia { get; set; }
        public Boolean Estado { get; set; }
    }
}
