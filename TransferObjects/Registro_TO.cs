using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObjects
{
    public class Registro_TO
    {
        public Int32 Id { get; set; }
        public Int32 Id_Colaborador { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Salida { get; set; }
        public DateTime Desayuno { get; set; }
        public DateTime Almuerzo { get; set; }
        public DateTime Cafe { get; set; }
        public Decimal Horas { get; set; }
        public Decimal Extras { get; set; }
        public Boolean Estado { get; set; }
        public Boolean Proceso { get; set; }
    }
}
