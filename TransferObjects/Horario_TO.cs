using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Horario_TO
    {
        public Int32 Id { get; set; }
        public String Nombre_Horario { get; set; }
        public DateTime Hora_Inicio { get; set; }
        public DateTime Hora_Fin { get; set; }
        public Boolean Estado { get; set; }
    }
}
